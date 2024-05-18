using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Result;

namespace Business.Abstract
{
    public interface IRaporService
    {
        IDataResult<List<Rapor>> GetAll();
        IDataResult<Rapor> GetById(int id);
        IResult Add(Rapor Rapor);
        IResult Update(Rapor Rapor);
        IResult Delete(Rapor Rapor);
    }
}
