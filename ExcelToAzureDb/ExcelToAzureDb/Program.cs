using System;
using System.Linq;
using LinqToExcel;
using Repository.Services;
using EntitiesAzure.Domain;
using ExcelToAzureDb.FactoryClass;
using ExcelToAzureDb.Operation;
using System.Collections.Generic;

namespace ExcelToAzureDb
{
    class Program
    {
        static void Main(string[] args)
        {
            //bag intr-un dictionar: cheie (nume elev)-> valoare clasa. dintr-un fisier initial.

            var excelElevi = new ExcelQueryFactory(@"F:\Downloads\newbddorna.xlsx"); //iau excel-ul cu baza de date
            var dataElevi = (from c in excelElevi.Worksheet<ModelElevi>("BAZA")
                             select c)?.ToList();

            Dictionary<string, string> idToClass = new Dictionary<string, string>(); 
            idToClass = new BuildDictionary().GetDb(); //build the dictionary between id's and class

            Dictionary<string, int> classToNormal = new Dictionary<string, int>();
            classToNormal["XII"] = 12;
            classToNormal["XI"] = 11;
            classToNormal["X"] = 10;
            classToNormal["IX"] = 9;
            classToNormal["VI"] = 6;



            var excel = new ExcelQueryFactory(@"F:\Downloads\DornaGood.xlsx"); // de aici iau xlsx-ul cu rezultate (bnnm.xlsx)
            var data = (from c in excel.Worksheet<ModelToExport>("Dorna") //sheet-ul unde e rezultatul
                        select c)?.ToList();

            foreach (ModelToExport item in data)
            {
                Type type = item.GetType();
                var propertyInfo = type.GetProperties();
                string id = item.ID;
                string clasa = idToClass[id];

                //add to cloud db the results
                var resultToAdd = new Rezultate
                {
                    Nume = item.Nume,
                    Prenume = item.Prenume,
                    Scoala = item.Scoala,
                    Clasa = classToNormal[clasa]
                };

                //loop over all the properties
                foreach (var prop in propertyInfo)
                {
                    if (FactoryChooseClass.GetClasa(clasa).Contains(prop.Name))
                    {
                        object val = prop.GetValue(item, null); //valoarea
                        if (val != null)
                        {
                            //see if you can convert the value
                            AssignPointToModel.AssignProblemPoint(ref resultToAdd, val);
                        }
                    }
                }

                //save in db (local or azure)

            }


            //IRepository<Rezultate> repo = new LocalRepository();
            //repo.Add(new Rezultate { Clasa = 12, Nume = "Mock1", P1 = 30, P2 = 20, P3 = 15, Prenume = "PrenMock", Scoala = "Cnlr" });
            //repo.Save();

            //IRepository<Rezultate> repo = new AzureRepository();
            //repo.Add(new Rezultate { Clasa = 12, Nume = "Mock1", P1 = 30, P2 = 20, P3 = 15, Prenume = "PrenMock", Scoala = "Cnlr" });
            //repo.Save();

            Console.WriteLine("Hello Luciiiii");
            Console.ReadLine();
        }
    }
}
