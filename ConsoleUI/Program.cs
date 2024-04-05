using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Entity;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HastaManager hastaManager = new HastaManager(new EfHastaDal());

            var result = hastaManager.Add(new Hasta
            {
                ad = "Ali",
                soyad = "Veli",
            });

            Console.WriteLine(result.IsSuccess + " " +result.Message);
            Console.ReadLine();
        }
    }
}
