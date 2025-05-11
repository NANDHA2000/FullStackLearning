using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntPreCode.SolidPrinciple
{

/*     
      Interface Segregation Principle (ISP)

      "Clients should not be forced to depend upon interfaces that they do not use."
*/

    public class InterfaceSegregationPrinciple
    {
        #region ISP Code

        // Without ISP:
        public interface IMachine
        {
            void Print(string content);
            void Scan(string content);
            void Fax(string content);
        }

        public class Printer1 : IMachine
        {
            public void Print(string content)
            {
                Console.WriteLine($"Printing: {content}");
            }

            // Printer doesn't need Scan, but must implement it
            public void Scan(string content)
            {
                throw new NotImplementedException();
            }

            // Printer doesn't need Fax, but must implement it
            public void Fax(string content)
            {
                throw new NotImplementedException();
            }
        }

        // With ISP:
        public interface IPrinter
        {
            void Print(string content);
        }

        public interface IScanner
        {
            void Scan(string content);
        }

        public interface IFax
        {
            void Fax(string content);
        }

        public class Printer2 : IPrinter
        {
            public void Print(string content)
            {
                Console.WriteLine($"Printing: {content}");
            }
        }

        public class Scanner : IScanner
        {
            public void Scan(string content)
            {
                Console.WriteLine($"Scanning: {content}");
            }
        }

        public class MultiFunctionMachine : IPrinter, IScanner, IFax
        {
            public void Print(string content)
            {
                Console.WriteLine($"Printing: {content}");
            }

            public void Scan(string content)
            {
                Console.WriteLine($"Scanning: {content}");
            }

            public void Fax(string content)
            {
                Console.WriteLine($"Faxing: {content}");
            }
        }
        #endregion
    }
}
