using Core.Utilities.Result;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHastalikService
    {
        IDataResult<List<Hastalik>> GetAll();
        IDataResult<Hastalik> GetById(int id);
        IDataResult<Hastalik> GetByName(string name);
        IResult Add(Hastalik Hastalik);
        IResult Update(Hastalik Hastalik);
        IResult Delete(Hastalik Hastalik);
    }
}
