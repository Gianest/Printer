using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    public class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Epson Printing");
        }
        public override void Print()
        {
            Console.WriteLine("Display dimension : xx");
        }
    }
}
