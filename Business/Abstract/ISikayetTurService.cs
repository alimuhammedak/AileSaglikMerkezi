using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Result;

namespace Business.Abstract
{
    public interface ISikayetTurService
    {
        IDataResult<List<SikayetTur>> GetAll();
        IDataResult<SikayetTur> GetById(int id);
        IResult Add(SikayetTur SikayetTur);
        IResult Update(SikayetTur SikayetTur);
        IResult Delete(SikayetTur SikayetTur);
    }
}
