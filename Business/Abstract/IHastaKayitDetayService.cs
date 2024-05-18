using Core.Utilities.Result;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHastaKayitDetayService
    {
        IDataResult<List<HastaKayitDetay>> GetAll();
        IDataResult<HastaKayitDetay> GetById(int id);
        IResult Add(HastaKayitDetay HastaKayitDetay);
        IResult Update(HastaKayitDetay HastaKayitDetay);
        IResult Delete(HastaKayitDetay HastaKayitDetay);
    }
}
