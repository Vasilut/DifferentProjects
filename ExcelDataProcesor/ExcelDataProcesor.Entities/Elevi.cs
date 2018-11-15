using LinqToExcel.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExcelDataProcesor.Entities
{
    public class Elevi
    {

        [ExcelColumn("Nume și prenume")]
        public string Nume { get; set; }
        public string Clasa { get; set; }
        [ExcelColumn("Școala de proveniență")]
        public string Scoala { get; set; }
        [ExcelColumn("Profesor îndrumător")]
        public string ProfesorIndrumator { get; set; }
    }
}
