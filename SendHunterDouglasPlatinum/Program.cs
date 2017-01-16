using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinimalisticTelnet;


namespace SendHunterDouglasPlatinum
{
    class Program
    {
        static void Main(string[] args)
        {
            TelnetConnection tc = new TelnetConnection("192.168.1.243", 522);
            System.Threading.Thread.Sleep(100);

            if (args[0] == "NIGHT")
                tc.Write("$inm0- \r");
            else if (args[0] == "MORNING")
                tc.Write("$inm2- \r");
            else if (args[0] == "DAY")
                tc.Write("$inm1- \r");
            System.Threading.Thread.Sleep(200);
        }
    }
}
