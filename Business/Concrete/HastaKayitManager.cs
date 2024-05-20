using Business.Abstract;
using Business.Constans;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.DTOs;
using Entities.DTOs.HastaKayitDtos;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    internal class HastaKayitManager : IHastaKayitService
    {
        private readonly IHastaKayitDal _hastaKayitDal;

        public HastaKayitManager(IHastaKayitDal hastaDal)
        {
            _hastaKayitDal = hastaDal;
        }

        public IResult Add(HastaKayit HastaKayit)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(HastaKayit HastaKayit)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<HastaKayit>> GetAll()
        {
            var result = _hastaKayitDal.GetAll();
            return new SuccessDataResult<List<HastaKayit>>(result);
        }

        public IDataResult<List<HastaKayitDetayDto>> GetAllHastaKayitDetay()
        {
            var result = _hastaKayitDal.GetAllHastaKayitDetay();
            return new SuccessDataResult<List<HastaKayitDetayDto>>(result);
        }

        public IDataResult<List<HastaCagirmaDto>> GetAllHastaCagirma()
        {
            var result = _hastaKayitDal.GetAllHastaCagirma();
            return new SuccessDataResult<List<HastaCagirmaDto>>(result);
        }

        public IDataResult<List<HastaKayitDetayDto>> GetAllHastaKayitDetayByTc(string tc)
        {
            var result = _hastaKayitDal.GetAllHastaKayitDetay(hk => hk.Hasta.identityNumber.Contains(tc));
            return new SuccessDataResult<List<HastaKayitDetayDto>>(result);
        }

        public IDataResult<HastaKayit> GetById(int id)
        {
            var result = _hastaKayitDal.Get(hk => hk.hastaKayitID == id && hk.aktifMi == true);
            return new SuccessDataResult<HastaKayit>(result);
        }

        public IResult Update(HastaKayit HastaKayit)
        {
            _hastaKayitDal.Update(HastaKayit);
            return new SuccessResult();
        }

        public IDataResult<List<HastaCagirmaDto>> GetAllHastaCagirmaByDoktorID(int id)
        {
            var result = _hastaKayitDal.GetAllHastaCagirma(hk => hk.DoktorID == id);
            return new SuccessDataResult<List<HastaCagirmaDto>>(result);
        }

        //public IDataResult<List<HastaKayit>> GetByIdentityNumberList(string identityNumber)
        //{
        //    var result = _hastaKayitDal.Get(hk => hk.Hasta.identityNumber == identityNumber);
        //    if (result is null)
        //    {
        //        return new ErrorDataResult<HastaKayit>(result);
        //    }

        //    return new SuccessDataResult<HastaKayit>(result);
        //}

        public IDataResult<List<HastaCagirmaKayitDetayDtos>> GetHastaCagirmaKayitDetayByTc(string tc)
        {
            var result = _hastaKayitDal.GetHastaCagirmaKayitDetay(hk => hk.HastaTc == tc);
            if (result is null)
            {
                return new ErrorDataResult<List<HastaCagirmaKayitDetayDtos>>(result, Messages.HastaNotFound);
            }
            return new SuccessDataResult<List<HastaCagirmaKayitDetayDtos>>(result);
        }

        public IDataResult<List<HastaCagirmaDto>> GetAllHastaCagirmaByDoktorIDToDay(int id)
        {
            var result = _hastaKayitDal.GetAllHastaCagirma(hk => hk.DoktorID == id && DbFunctions.TruncateTime(hk.HastaKayitTarih) == DateTime.Today);
            return new SuccessDataResult<List<HastaCagirmaDto>>(result);
        }

        public IDataResult<HastaKayit> GetFirstByDoktorIDToDay(int id)
        {
            var result = _hastaKayitDal.GetAll(hk => hk.doktorID == id &&
            DbFunctions.TruncateTime(hk.kayitTarih) == DateTime.Today && hk.aktifMi == true).First();
            return new SuccessDataResult<HastaKayit>(result);
        }
    }
}
