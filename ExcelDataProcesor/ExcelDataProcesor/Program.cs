using ExcelDataProcesor.Entities;
using LinqToExcel;
using System;
using System.Collections.Generic;
using System.IO;
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


            string eleviInscrisi = "elevi.txt";

            using (FileStream fs = new FileStream(eleviInscrisi, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            {
                StreamWriter writer = new StreamWriter(fs, Encoding.UTF8);
                foreach (var elev in dataElevi)
                {
                    //take first and second name
                    var firstNameAndSurname = elev.Nume.Split(' ');
                    if(String.IsNullOrEmpty(elev.Nume) || firstNameAndSurname.Length == 0)
                    {
                        Console.WriteLine("We don't have name for this user, we'll not create the user");
                        continue;
                    }

                    StringBuilder finalResult = new StringBuilder();
                    finalResult.Append(firstNameAndSurname[0].ToString()).Append(';');

                    string lastName = string.Empty;
                    for(int i = 1; i < firstNameAndSurname.Length; ++i)
                    {
                        if ( i < firstNameAndSurname.Length - 1)
                        {
                            lastName = lastName + firstNameAndSurname[i] + " ";
                        }
                        else
                        {
                            lastName = lastName + firstNameAndSurname[i];
                        }
                    }
                    finalResult.Append(lastName).Append(';');


                    //profesor indrumator
                    if(String.IsNullOrEmpty(elev.ProfesorIndrumator))
                    {
                        Console.WriteLine($"We don't have profesor indrumator for this user {elev.Nume}, we'll not create the user");
                        continue;
                    }
                    finalResult.Append(elev.ProfesorIndrumator).Append(';');

                    //class
                    if (String.IsNullOrEmpty(elev.Clasa))
                    {
                        Console.WriteLine($"We don't have class for this user {elev.Nume}, we'll not create the user");
                        continue;
                    }
                    finalResult.Append(elev.Clasa).Append(';');

                    //scoala
                    if (String.IsNullOrEmpty(elev.Scoala))
                    {
                        Console.WriteLine($"We don't have scoala for this user {elev.Nume}, we'll not create the user");
                        continue;
                    }
                    finalResult.Append(elev.Scoala).Append(';');


                    writer.WriteLine(finalResult.ToString());
                }
                writer.Flush();
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }


}
