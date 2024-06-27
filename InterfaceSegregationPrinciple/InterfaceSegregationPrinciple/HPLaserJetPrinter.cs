using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class HPLaserJetPrinter : IPrinterTasks, IFaxTasks, IPrintDuplexTasks //before implementing ISP it was only IPrinterTasks
    {
        public void Fax(string FaxContent)
        {
            Console.WriteLine("Fax content");
        }

        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }

        public void PrintDuplex(string PrintDuplexContent)
        {
            Console.WriteLine("Print Duplex content");
        }

        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
    }
}
