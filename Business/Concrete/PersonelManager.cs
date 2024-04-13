using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constans;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Entity;

namespace Business.Concrete
{

    public class PersonelManager : IPersonelService
    {
        IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public IResult Add(Personel personel)
        {
            _personelDal.Add(personel);
            return new SuccessResult(Messages.PersonelAdded);
        }

        public IResult Delete(Personel personel)
        {
            _personelDal.Delete(personel);
            return new SuccessResult(Messages.PersonelDeleted);
        }

        public IDataResult<List<Personel>> GetAll()
        {
            return new SuccessDataResult<List<Personel>>(_personelDal.GetAll(), Messages.PersonelListed);
        }

        public IDataResult<Personel> GetById(int id)
        {
            return new SuccessDataResult<Personel>(_personelDal.Get(p => p.personelID == id), Messages.PersonelListed);
        }

        public IDataResult<Personel> GetByUserNameAndPassword(string userName, string password)
        {
            var result = _personelDal.Get(p => p.kullaniciAd == userName && p.passwordSalt == password);
            if (result == null)
            {
                return new ErrorDataResult<Personel>(Messages.PersonelNotFound);
            }
            return new SuccessDataResult<Personel>(result,Messages.PersonelFound);
        }

        public IResult Update(Personel personel)
        {
            _personelDal.Update(personel);
            return new SuccessResult(Messages.PersonelUpdated);
        }
    }

}
