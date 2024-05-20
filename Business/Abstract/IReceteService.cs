using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Result;

namespace Business.Abstract
{
    public interface IReceteService
    {
        IDataResult<List<Recete>> GetAll();
        IDataResult<Recete> GetById(int id);
        IResult Add(Recete Recete);
        IResult Update(Recete Recete);
        IResult Delete(Recete Recete);
        IDataResult<Recete> GetByReceteNo(string receteNo);
    }
}
