using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    public class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("laserjet Printing");
        }
        public override void Print()
        {
            Console.WriteLine("Display dimension : yy");
        }
    }
}
