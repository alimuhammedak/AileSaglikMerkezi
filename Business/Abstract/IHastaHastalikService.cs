using Core.Utilities.Result;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHastaHastalikService
    {
        IDataResult<List<HastaHastalik>> GetAll();
        IDataResult<HastaHastalik> GetById(int id);
        IResult Add(HastaHastalik HastaHastalik);
        IResult Update(HastaHastalik HastaHastalik);
        IResult Delete(HastaHastalik HastaHastalik);
    }
}
