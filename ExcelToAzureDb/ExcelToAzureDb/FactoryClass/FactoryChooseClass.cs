using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToAzureDb.FactoryClass
{
    public class FactoryChooseClass
    {
        public static string[] GetClasa(string clasa)
        {
            string[] arr = null;
            switch (clasa)
            {
                case "IX":
                    {
                        arr = Constants.Clasa9;
                        break;
                    }
                case "X":
                    {
                        arr = Constants.Clasa10;
                        break;
                    }
                case "XI":
                    {
                        arr = Constants.Clasa11;
                        break;
                    }
                case "XII":
                    {
                        arr = Constants.Clasa12;
                        break;
                    }
                default:
                    {
                        arr = Constants.Gimnaziu;
                        break;
                    }
            }
            return arr;
        }
    }
}
