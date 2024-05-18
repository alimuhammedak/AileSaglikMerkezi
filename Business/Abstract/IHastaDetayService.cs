using Core.Utilities.Result;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHastaDetayService
    {
        IDataResult<List<HastaDetay>> GetAll();
        IDataResult<HastaDetay> GetById(int id);
        IResult Add(HastaDetay HastaDetay);
        IResult Update(HastaDetay HastaDetay);
        IResult Delete(HastaDetay HastaDetay);
    }
}
