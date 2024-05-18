using Core.Utilities.Result;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHemsireService
    {
        IDataResult<List<Hemsire>> GetAll();
        IDataResult<Hemsire> GetById(int id);
        IResult Add(Hemsire Hemsire);
        IResult Update(Hemsire Hemsire);
        IResult Delete(Hemsire Hemsire);
    }
}
