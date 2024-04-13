using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess;
using DataAccess.Concrete.EntityFramework;
using Entities.Entity;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HastaManager hastaManager = new HastaManager(new EfHastaDal());
            IlacManager ilacManager = new IlacManager(new EfIlacDal());

            var result = hastaManager.Add(new Hasta
            {
                soyad = "Veli",
            });

            Console.WriteLine(result.IsSuccess + " " + result.Message);
            Console.ReadLine();
        }
    }
}
