using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecratorRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository<Product> rpproduct = new Repository<Product>();
            LoggerRepository<Product> lgproduct = new LoggerRepository<Product>(rpproduct);

            Product ptest = new Product();
            ptest.ProductName = "x";

            lgproduct.Add(ptest);


        }
    }
}
