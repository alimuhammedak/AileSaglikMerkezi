using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        IKullaniciDal _KullaniciDal;

        public KullaniciManager(IKullaniciDal KullaniciDal)
        {
            _KullaniciDal = KullaniciDal;
        }

        public IResult Add(Kullanici Kullanici)
        {
            _KullaniciDal.Add(Kullanici);
            return new SuccessResult(Messages.KullaniciAdded);
        }

        public IResult Delete(Kullanici Kullanici)
        {
            _KullaniciDal.Delete(Kullanici);
            return new SuccessResult(Messages.KullaniciDeleted);
        }

        public IDataResult<List<Kullanici>> GetAll()
        {
            return new SuccessDataResult<List<Kullanici>>(_KullaniciDal.GetAll(), Messages.KullaniciListed);
        }

        public IDataResult<Kullanici> GetById(int id)
        {
            return new SuccessDataResult<Kullanici>(_KullaniciDal.Get(k => k.kullaniciID == id), Messages.KullaniciListed);
        }

        public IDataResult<Kullanici> GetByIdentityNumber(string identityNumber)
        {
            var result = _KullaniciDal.Get(k => k.identityNumber == identityNumber);
            if (result != null)
            {
                return new SuccessDataResult<Kullanici>(result);
            }
            return new ErrorDataResult<Kullanici>(result, Messages.KullaniciNotFound);
        }

        [ValidationAspect(typeof(KullaniciValidator))]
        public IDataResult<Kullanici> GetByUserNameAndPassword(string userName, string password)
        {
            var result = _KullaniciDal.Get(k => k.kullaniciAd == userName && k.passwordSalt == password && k.aktifMi == true);
            if (result != null)
            {
                return new SuccessDataResult<Kullanici>(result);
            }
            return new ErrorDataResult<Kullanici>(result, Messages.KullaniciNotFound);
        }

        public IResult GetByUserPasswordReset(string identityNumber, string firstName, string lastName)
        {
            var result = _KullaniciDal.Get(k => k.identityNumber == identityNumber && k.ad == firstName && k.soyad == lastName);
            if (result != null)
            {
                return new SuccessResult();
            }
            return new ErrorResult(Messages.KullaniciNotFound);
        }

        public IResult Update(Kullanici Kullanici)
        {
            _KullaniciDal.Update(Kullanici);
            return new SuccessResult(Messages.KullaniciUpdated);
        }
    }
}
