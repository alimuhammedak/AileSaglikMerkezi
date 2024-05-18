using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Result;

namespace Business.Abstract
{
    public interface ITahlilTurService
    {
        IDataResult<List<TahlilTur>> GetAll();
        IDataResult<TahlilTur> GetById(int id);
        IResult Add(TahlilTur TahlilTur);
        IResult Update(TahlilTur TahlilTur);
        IResult Delete(TahlilTur TahlilTur);
    }
}
