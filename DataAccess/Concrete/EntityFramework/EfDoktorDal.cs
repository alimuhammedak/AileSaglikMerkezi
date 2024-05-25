using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.DTOs;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDoktorDal : EfEntityRepositoryBase<Doktor, SODBContext>, IDoktorDal
    {
        public List<DoktorDto> GetAllDoktorListe(Expression<Func<DoktorDto, bool>> filter = null)
        {

            using (var context = new SODBContext())
            {
                var query = context.Doktor.Select(doktor => new DoktorDto
                {
                    doktorID = doktor.doktorID,
                    ad = doktor.Kullanici.ad,
                    soyad = doktor.Kullanici.soyad,
                    unvan = doktor.Unvan.ad,
                });

                if (filter != null)
                    query = query.Where(filter);

                var result = query.ToList();
                return new List<DoktorDto>(result);
            }

        }
    }
}
