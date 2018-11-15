using ExcelDataProcesor.Entities;
using LinqToExcel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelDataProcesor
{
    class Program
    {
        static void Main(string[] args)
        {

            var excelElevi = new ExcelQueryFactory(@"F:\Downloads\newbddorna.xlsx"); //iau excel-ul cu baza de date
            var dataElevi = (from c in excelElevi.Worksheet<Elevi>("BAZA")
                             select c)?.ToList();

            var x = 2;

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }


}
