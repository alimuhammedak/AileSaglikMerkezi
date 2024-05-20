using Core.DataAccess.EntityFramework;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs;
using Entities.DTOs.HastaKayitDtos;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfHastaKayitDal : EfEntityRepositoryBase<HastaKayit, SODBContext>, IHastaKayitDal
    {
        public List<HastaCagirmaDto> GetAllHastaCagirma(Expression<Func<HastaCagirmaDto, bool>> filter = null)
        {
            using (var context = new SODBContext())
            {
                var query = context.HastaKayit.Where(hk => hk.aktifMi == true)
                    .Select(hk => new HastaCagirmaDto
                    {
                        DoktorAdi = hk.Doktor.Kullanici.ad + " " + hk.Doktor.Kullanici.soyad,
                        DoktorID = hk.Doktor.doktorID,
                        DoktorUnvan = hk.Doktor.Unvan.ad,
                        HastaAd = hk.Hasta.ad,
                        HastaSoyad = hk.Hasta.soyad,
                        HastaTc = hk.Hasta.identityNumber,
                        HastaSira = hk.hastaSira.Value,
                        HastaKayitID = hk.hastaKayitID,
                        HastaKayitTarih = hk.kayitTarih.Value,
                        DogumTarih = hk.Hasta.dogumTarih.Value,
                        Cinsiyet = hk.Hasta.Cinsiyet.ad,
                        IletisimNo = hk.Hasta.iletisimNo
                    });

                if (filter != null)
                    query = query.Where(filter);

                var result = query.ToList();
                return new List<HastaCagirmaDto>(result);
            }
        }

        public List<HastaKayitDetayDto> GetAllHastaKayitDetay(Expression<Func<HastaKayitDetayDto, bool>> filter = null)
        {
            using (var context = new SODBContext())
            {
                var query = context.HastaKayit
                    .Select(hk => new HastaKayitDetayDto
                    {
                        HastaKayit = hk,
                        Doktor = hk.Doktor,
                        Hemsire = hk.Hemsire,
                        Hasta = hk.Hasta,
                        Kullanici = hk.Doktor.Kullanici
                    });

                if (filter != null)
                    query = query.Where(filter);

                var result = query.ToList();
                return new List<HastaKayitDetayDto>(result);
            }
        }

        public List<HastaCagirmaKayitDetayDtos> GetHastaCagirmaKayitDetay(Expression<Func<HastaCagirmaKayitDetayDtos, bool>> filter)
        {
            using (var context = new SODBContext())
            {
                var query = context.HastaKayit
                    .Select(hk => new HastaCagirmaKayitDetayDtos
                    {
                       DoktorAdi = hk.Doktor.Kullanici.ad + " " + hk.Doktor.Kullanici.soyad,
                       DoktorID = hk.Doktor.doktorID,
                       DoktorUnvan = hk.Doktor.Unvan.ad,
                       HastaAd = hk.Hasta.ad + " " + hk.Hasta.soyad,
                       HastaTc = hk.Hasta.identityNumber,
                       HastaKayitID = hk.hastaKayitID,
                       KayitTarih = hk.kayitTarih.Value.ToString() 
                    });

                if (filter != null)
                    query = query.Where(filter);

                var result = query.ToList();
                return new List<HastaCagirmaKayitDetayDtos>(result);
            }
        }
    }
}
