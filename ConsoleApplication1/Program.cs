using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IElement resistor = new Resistor();
            resistor.Value = 15.0;
            resistor.Name = "R1";
            var impedanceR = resistor.GetImpedance(1.0);
            Console.WriteLine(impedanceR.ToString());

            IElement inductor = new Inductor();
            inductor.Value = 25.0;
            inductor.Name = "L1";
            var impedanceI = inductor.GetImpedance(33);
            Console.WriteLine(impedanceI.ToString());

            IElement capacitor = new Capacitor();
            capacitor.Value = 32.2;
            capacitor.Name = "C1";
            var impendanceC = capacitor.GetImpedance(22);
            Console.WriteLine(impendanceC.ToString());
        }
    }
}
