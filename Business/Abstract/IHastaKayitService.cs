using Core.Utilities.Result;
using Entities.DTOs;
using Entities.DTOs.DoktorHastaListeDtos;
using Entities.DTOs.HastaKayitDtos;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHastaKayitService
    {
        IDataResult<List<HastaKayit>> GetAll();
        IDataResult<HastaKayit> GetById(int id);
        IResult Add(HastaKayit HastaKayit);
        IResult Update(HastaKayit HastaKayit);
        IResult Delete(HastaKayit HastaKayit);
        IDataResult<List<HastaKayitDetayDto>> GetAllHastaKayitDetay();
        IDataResult<List<HastaCagirmaDto>> GetAllHastaCagirma();
        IDataResult<HastaKayit> GetByIdentityNumber(string identityNumber);
        IDataResult<List<HastaCagirmaDto>> GetAllHastaCagirmaByDoktorID(int id);
        IDataResult<List<HastaKayitDetayDto>> GetAllHastaKayitDetayByTc(string tc);
        IDataResult<List<HastaCagirmaKayitDetayDtos>> GetHastaCagirmaKayitDetayByTc(string tc);
    }
}
