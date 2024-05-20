using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Result;

namespace Business.Abstract
{
    public interface ITetkikService
    {
        IDataResult<List<Tetkik>> GetAll();
        IDataResult<Tetkik> GetById(int id);
        IDataResult<Tetkik> GetByName(string name);
        IResult Add(Tetkik Tetkik);
        IResult Update(Tetkik Tetkik);
        IResult Delete(Tetkik Tetkik);
    }
}
