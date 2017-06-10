using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDbMock
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductRepository productRepo = new ProductRepository();

            var listOfProducts = productRepo.GetAllProducts();
            foreach (var item in listOfProducts)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();
            Console.WriteLine("Helooo. Press any key to quit");
        }
    }
}
