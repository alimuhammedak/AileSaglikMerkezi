using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Result;

namespace Business.Abstract
{
    public interface ITedarikciService
    {
        IDataResult<List<Tedarikci>> GetAll();
        IDataResult<Tedarikci> GetById(int id);
        IResult Add(Tedarikci Tedarikci);
        IResult Update(Tedarikci Tedarikci);
        IResult Delete(Tedarikci Tedarikci);
    }
}
