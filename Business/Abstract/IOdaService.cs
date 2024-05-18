using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Result;

namespace Business.Abstract
{
    public interface IOdaService
    {
        IDataResult<List<Oda>> GetAll();
        IDataResult<Oda> GetById(int id);
        IResult Add(Oda Oda);
        IResult Update(Oda Oda);
        IResult Delete(Oda Oda);
    }
}
