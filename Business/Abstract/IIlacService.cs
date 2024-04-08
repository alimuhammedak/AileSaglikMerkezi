using Core.Utilities.Result;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IIlacService
    {
        IDataResult<List<Ilac>> GetAll();
        IDataResult<Ilac> GetById(int id);
        IResult Add(Ilac ilac);
        IResult Update(Ilac ilac);
        IResult Delete(Ilac ilac);
    }
}
