using Business.Abstract;
using Business.Constans;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ReceteManager : IReceteService
    {
        private IReceteDal _receteDal;

        public ReceteManager(IReceteDal receteDal)
        {
            _receteDal = receteDal;
        }

        public IResult Add(Recete recete)
        {
            try
            {
                // Benzersiz bir reçete numarası oluşturma
                recete.gecerliMi = true;
                // Veritabanına ekleme işlemi
                _receteDal.Add(recete);
                return new SuccessResult(Messages.ReceteAdded);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.ReceteAddFailed + ": " + ex.Message);
            }
        }

        public IResult Delete(Recete recete)
        {
            try
            {
                // Veritabanından silme işlemi
                _receteDal.Delete(recete);
                return new SuccessResult(Messages.ReceteDeleted);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.ReceteDeleteFailed + ": " + ex.Message);
            }
        }

        public IDataResult<List<Recete>> GetAll()
        {
            try
            {
                // Tüm reçeteleri getirme işlemi
                var result = _receteDal.GetAll();
                return new SuccessDataResult<List<Recete>>(result);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<Recete>>(null, Messages.ReceteGetAllFailed + ": " + ex.Message);
            }
        }

        public IDataResult<Recete> GetById(int id)
        {
            try
            {
                // ID'ye göre reçete getirme işlemi
                var result = _receteDal.Get(x => x.receteID == id);
                if (result == null)
                {
                    return new ErrorDataResult<Recete>(null, Messages.ReceteNotFound);
                }
                return new SuccessDataResult<Recete>(result);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<Recete>(null, Messages.ReceteGetByIdFailed + ": " + ex.Message);
            }
        }

        public IDataResult<Recete> GetByReceteNo(string receteNo)
        {
            var result =  _receteDal.Get(x => x.receteNo == receteNo);  
            if (result == null)
            {
                return new ErrorDataResult<Recete>(null, Messages.ReceteNotFound);
            }
            return new SuccessDataResult<Recete>(result);
        }

        public IResult Update(Recete recete)
        {
            try
            {
                // Veritabanında güncelleme işlemi
                _receteDal.Update(recete);
                return new SuccessResult(Messages.ReceteUpdated);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.ReceteUpdateFailed + ": " + ex.Message);
            }
        }
    }
    public static class ReceteNumaraUretici
    {
        public static string ReceteNumaraOlusturucu()
        {
            // Yeni bir GUID oluşturur ve ilk 8 karakterini alır
            return Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
        }
    }
}
