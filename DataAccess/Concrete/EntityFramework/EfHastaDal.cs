using Core.DataAccess.EntityFramework;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.DTOs.DoktorHastaListeDtos;
using System.Linq.Expressions;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfHastaDal : EfEntityRepositoryBase<Hasta, SODBContext>, IHastaDal
    {
        public List<HastaListeDto> GetAllHastaListe(Expression<Func<HastaListeDto, bool>> filter = null)
        {
            using (var context = new SODBContext())
            {
                var query = context.Hasta
                    .Select(hk => new HastaListeDto
                    {
                        ad = hk.ad,
                        soyad = hk.soyad,
                        identityNumber = hk.identityNumber,
                        hastaID = hk.hastaID,
                        cinsiyet = hk.Cinsiyet.ad,
                        dogumYer = hk.dogumYer,
                        iletisimNo = hk.iletisimNo,
                        sosyalGuvenlikNo = hk.sosyalGuvenlikNo,
                        dogumTarih = hk.dogumTarih,
                        adres = hk.adres,
                        email = hk.email
                    });

                if (filter != null)
                    query = query.Where(filter);

                var result = query.ToList();
                return new List<HastaListeDto>(result);
            }
        }
    }
}
