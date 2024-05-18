using Core.Utilities.Result;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IIlacRaporService
    {
        IDataResult<List<IlacRapor>> GetAll();
        IDataResult<IlacRapor> GetById(int id);
        IResult Add(IlacRapor IlacRapor);
        IResult Update(IlacRapor IlacRapor);
        IResult Delete(IlacRapor IlacRapor);
    }
}
