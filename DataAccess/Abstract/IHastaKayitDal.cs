using Core.DataAccess;
using Core.Utilities.Result;
using Entities.DTOs;
using Entities.DTOs.HastaKayitDtos;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IHastaKayitDal : IEntityRepository<HastaKayit>
    {
        List<HastaKayitDetayDto> GetAllHastaKayitDetay(Expression<Func<HastaKayitDetayDto, bool>> filter = null);
        List<HastaCagirmaDto> GetAllHastaCagirma(Expression<Func<HastaCagirmaDto, bool>> filter = null);
        List<HastaCagirmaKayitDetayDtos> GetHastaCagirmaKayitDetay(Expression<Func<HastaCagirmaKayitDetayDtos, bool>> filter);
    }
}
