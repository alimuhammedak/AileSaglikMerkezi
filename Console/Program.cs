using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            PersonelManager p = new PersonelManager(new EfPersonelDal());
            var result = p.GetAll();
            System.Console.WriteLine(result);
        }
    }
}
