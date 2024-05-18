using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Result;

namespace Business.Abstract
{
    public interface ITahlilService
    {
        IDataResult<List<Tahlil>> GetAll();
        IDataResult<Tahlil> GetById(int id);
        IResult Add(Tahlil Tahlil);
        IResult Update(Tahlil Tahlil);
        IResult Delete(Tahlil Tahlil);
    }
}
