using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingleResponsabilityPrinciple
{
    public class CustomerGood
    {
        private FileLogger _fileLogger;
        public CustomerGood()
        {
            _fileLogger = new FileLogger();
        }
        public void Add()
        {
            try
            {
                //operations
            }
            catch (Exception ex)
            {
                _fileLogger.Handle(ex.ToString()); //now the logging is handled in the FileLogger class.
            }
        }
    }

    public class FileLogger
    {
        public void Handle(string error)
        {
            File.WriteAllText(@"file.txt", error);
        }
    }
}
