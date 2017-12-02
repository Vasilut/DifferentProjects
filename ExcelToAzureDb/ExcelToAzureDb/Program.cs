using System;
using System.Linq;
using LinqToExcel;
using Repository.Services;
using EntitiesAzure.Domain;
using ExcelToAzureDb.FactoryClass;
using ExcelToAzureDb.Operation;

namespace ExcelToAzureDb
{
    class Program
    {
        static void Main(string[] args)
        {
            //bag intr-un dictionar: cheie (nume elev)-> valoare clasa. dintr-un fisier initial.


            //var excel = new ExcelQueryFactory(@"F:\Downloads\bnnm.xlsx");
            //var data = (from c in excel.Worksheet<ModelToExport>("Clasament")
            //            select c)?.ToList();

            //foreach (ModelToExport item in data)
            //{
            //    Type type = item.GetType();
            //    var propertyInfo = type.GetProperties();

            //    //add to cloud db the results
            //    var resultToAdd = new Rezultate
            //    {
            //        Nume = item.Nume,
            //        Prenume = item.Prenume,
            //        Scoala = item.Scoala
            //    };

            //    //loop over all the properties
            //    foreach (var prop in propertyInfo)
            //    {
            //        if (FactoryChooseClass.GetClasa("12").Contains(prop.Name))
            //        {
            //            object val = prop.GetValue(item, null); //valoarea
            //            if (val != null)
            //            {
            //                AssignPointToModel.AssignProblemPoint(ref resultToAdd,val);
            //            }
            //        }
            //    }

            //}


            //IRepository<Rezultate> repo = new LocalRepository();
            //repo.Add(new Rezultate { Clasa = 12, Nume = "Mock1", P1 = 30, P2 = 20, P3 = 15, Prenume = "PrenMock", Scoala = "Cnlr" });
            //repo.Save();

            IRepository<Rezultate> repo = new AzureRepository();
            repo.Add(new Rezultate { Clasa = 12, Nume = "Mock1", P1 = 30, P2 = 20, P3 = 15, Prenume = "PrenMock", Scoala = "Cnlr" });
            repo.Save();

            Console.WriteLine("Hello Luciiiii");
            Console.ReadLine();
        }
    }
}
