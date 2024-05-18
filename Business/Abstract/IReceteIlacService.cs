using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Result;

namespace Business.Abstract
{
    public interface IReceteIlacService
    {
        IDataResult<List<ReceteIlac>> GetAll();
        IDataResult<ReceteIlac> GetById(int id);
        IResult Add(ReceteIlac ReceteIlac);
        IResult Update(ReceteIlac ReceteIlac);
        IResult Delete(ReceteIlac ReceteIlac);
    }
}
