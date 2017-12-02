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
            switch (clasa)
            {
                case "9":
                    {
                        return Constants.Clasa9;
                    }
                case "10":
                    {
                        return Constants.Clasa10;
                    }
                case "11":
                    {
                        return Constants.Clasa11;
                    }
                case "12":
                    {
                        return Constants.Clasa12;
                    }
            }
            return null;
        }
    }
}
