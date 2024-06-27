using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public interface IPrinterTasks
    {
        void Print(string PrintContent);
        void Scan(string ScanContent);

        //Now these functions are moved to new interfaces
       // void Fax(string FaxContent);
       // void PrintDuplex(string PrintDuplexContent);
    }
}
