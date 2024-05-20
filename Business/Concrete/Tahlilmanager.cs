using Business.Abstract;
using Business.Constans;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Entity;
using System.Collections.Generic;

public class TahlilManager : ITahlilService
{
    private readonly ITahlilDal _tahlilDal;

    public TahlilManager(ITahlilDal tahlilDal)
    {
        _tahlilDal = tahlilDal;
    }

    public IResult Add(Tahlil tahlil)
    {
        _tahlilDal.Add(tahlil);
        return new SuccessResult(Messages.TahlilAdded);
    }

    public IResult Delete(Tahlil tahlil)
    {
        _tahlilDal.Delete(tahlil);
        return new SuccessResult(Messages.TahlilDeleted);
    }

    public IDataResult<List<Tahlil>> GetAll()
    {
        var result = _tahlilDal.GetAll();
        return new SuccessDataResult<List<Tahlil>>(result, Messages.TahlilListed);
    }

    public IDataResult<Tahlil> GetById(int id)
    {
        var result = _tahlilDal.Get(t => t.tahlilID == id);
        if (result == null)
        {
            return new ErrorDataResult<Tahlil>(Messages.TahlilNotFound);
        }
        return new SuccessDataResult<Tahlil>(result, Messages.TahlilFound);
    }

    public IResult Update(Tahlil tahlil)
    {
        _tahlilDal.Update(tahlil);
        return new SuccessResult(Messages.TahlilUpdated);
    }
}
