using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Result;

namespace Business.Abstract
{
    public interface IReceteTurService
    {
        IDataResult<List<ReceteTur>> GetAll();
        IDataResult<ReceteTur> GetById(int id);
        IResult Add(ReceteTur ReceteTur);
        IResult Update(ReceteTur ReceteTur);
        IResult Delete(ReceteTur ReceteTur);
    }
}
