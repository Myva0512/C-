using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosicionConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ubicacion IG1 = new Ubicacion();
            IG1.MovimientoH();
            Console.ReadKey();
        }
    }
}
