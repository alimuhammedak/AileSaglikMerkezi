using Core.Utilities.Result;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IIlacOlcekService
    {
        IDataResult<List<IlacOlcek>> GetAll();
        IDataResult<IlacOlcek> GetById(int id);
        IResult Add(IlacOlcek IlacOlcek);
        IResult Update(IlacOlcek IlacOlcek);
        IResult Delete(IlacOlcek IlacOlcek);
    }
}
