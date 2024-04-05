using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Result;

namespace Business.Abstract
{
    public interface IHastaService
    {
        IDataResult<List<Hasta>> GetAll();
        IDataResult<Hasta> GetById(int id);
        IResult Add(Hasta hasta);
        IResult Update(Hasta hasta);
        IResult Delete(Hasta hasta);
    }
}
