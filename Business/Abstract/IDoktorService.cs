using Core.Utilities.Result;
using Entities.DTOs;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDoktorService
    {
        IDataResult<List<Doktor>> GetAll();
        IDataResult<Doktor> GetById(int id);
        IDataResult<Doktor> GetByKullaniciId(int id);
        IDataResult<List<DoktorDto>> GetAllKayit();
        IResult Add(Doktor doktor);
        IResult Update(Doktor doktor);
        IResult Delete(Doktor doktor);
    }
}
