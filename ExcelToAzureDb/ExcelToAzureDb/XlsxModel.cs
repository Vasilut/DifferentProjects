using LinqToExcel.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToAzureDb
{
    public class ModelToExport 
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Scoala { get; set; }
        public string ID { get; set; }
        public string flori { get; set; }
        public string castel { get; set; }
        public string agheu { get; set; }
        public string stelica { get; set; }
        public string numarare { get; set; }
        public string valoare { get; set; }
        public string sumegal { get; set; }
        public string indice { get; set; }
        public string loterie { get; set; }
        public string sefuti { get; set; }
        public string librarie { get; set; }
        public string centura { get; set; }
        public string sritech { get; set; }
        public string galaxia { get; set; }

    }

    public class ModelElevi
    {
        [ExcelColumn("Nume și prenume")]
        public string Nume { get; set; }
        public string Clasa { get; set; }
        public string ID { get; set; }
    }
}
