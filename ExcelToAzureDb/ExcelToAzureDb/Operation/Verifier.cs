using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToAzureDb.Operation
{
    public static class Verifier
    {
        public static bool IsNumber(this object value)
        {
            return value is sbyte
            || value is byte
            || value is short
            || value is ushort
            || value is int
            || value is uint
            || value is long
            || value is ulong
            || value is float
            || value is double
            || value is decimal;
        }

        public static bool ContainsOnlyNumbers(this object value)
        {
            string val = (string)value;
            for (int i = 0; i < val.Length; ++i)
            {
                if (!IsCifra(val[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsCifra(char c)
        {
            return (c >= '0' && c < '9');
        }
    }
}
