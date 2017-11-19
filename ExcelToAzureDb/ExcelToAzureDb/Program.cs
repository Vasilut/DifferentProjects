using System;
using System.Linq;
using LinqToExcel;
using Entities.Repository;
using Entities.Domain;

namespace ExcelToAzureDb
{
    class Program
    {
        static void Main(string[] args)
        {

            var excel = new ExcelQueryFactory(@"F:\Downloads\bnnm.xlsx");
            var data = from c in excel.Worksheet<MockModel>("Clasament")
                       select c;

            IRepository<Rezultate> repo = new LocalRepository();
            repo.Add(new Rezultate { Clasa = 12, Nume = "Mock1", P1 = 30, P2 = 20, P3 = 15, Prenume = "PrenMock", Scoala = "Cnlr" });
            repo.Save();

            Console.WriteLine("Hello Luciiiii");
            Console.ReadLine();
        }
    }
}
