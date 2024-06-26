﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.DTOs.DoktorHastaListeDtos;
using Entities.Entity;

namespace Business.Concrete
{

    public class HastaManager : IHastaService
    {
        private IHastaDal _hastaDal;

        public HastaManager(IHastaDal hastaDal)
        {
            _hastaDal = hastaDal;
        }

        [ValidationAspect(typeof(HastaValidator))]
        public IResult Add(Hasta hasta)
        {
            //Business codes

            //hasat kayıt sadece 08-17 saatleri arasında yapılabilir
            if (DateTime.Now.Hour < 8 || DateTime.Now.Hour > 17)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }

            _hastaDal.Add(hasta);
            return new SuccessResult(Messages.HastaAdded);
        }

        public IResult Delete(Hasta hasta)
        {
            if (hasta.sosyalGuvenlikNo.EndsWith("3")) //sosyal güvenlik numarası 3 ile biten hastalar silinemez
            {
                return new ErrorResult("Sosyal güvenlik numarası 3 ile biten hastalar silinemez");
            }
            _hastaDal.Delete(hasta);
            return new SuccessResult(Messages.HastaAdded);
        }

        public IDataResult<List<Hasta>> GetAll()
        {
            
            return new SuccessDataResult<List<Hasta>>(_hastaDal.GetAll(),Messages.HastaListed);
        }

        public IDataResult<List<HastaListeDto>> GetAllList()
        {
            var result = _hastaDal.GetAllHastaListe();
            if(result is null)
            {
                return new ErrorDataResult<List<HastaListeDto>>(Messages.HastaNotFound);
            }
            return new SuccessDataResult<List<HastaListeDto>>(result,Messages.HastaListed);
        }

        public IDataResult<Hasta> GetById(int id)
        {
            return new SuccessDataResult<Hasta>(_hastaDal.Get(h => h.hastaID == id));

        }

        public IDataResult<List<HastaListeDto>> GetListByIdentityNumber(string identityNumber)
        {
            var result = _hastaDal.GetAllHastaListe(h => h.identityNumber.StartsWith(identityNumber));
            if (result is null)
            {
                return new ErrorDataResult<List<HastaListeDto>>(Messages.HastaNotFound);
            }
            return new SuccessDataResult<List<HastaListeDto>>(result,Messages.HastaListed);
        }

        public IResult Update(Hasta hasta)
        {
            _hastaDal.Update(hasta);
            return new SuccessResult(Messages.HastaUpdated);
        }

        IDataResult<Hasta> IHastaService.GetByIdentityNumber(string identityNumber)
        {
            var result = _hastaDal.Get(h => h.identityNumber == identityNumber);
            if (result is null)
            {
                return new ErrorDataResult<Hasta>(Messages.HastaNotFound);
            }
            return new SuccessDataResult<Hasta>(result, Messages.HastaListed);
        }
    }
}
