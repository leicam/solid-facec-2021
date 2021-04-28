using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SRP.Refatorado
{
    class Program
    {
        static void Main(string[] args)
        {
            var gerenteExecutivo = new GerenteExecutivo("00000000000", "Gerente Executivo", 1200.00m);

            Console.WriteLine(gerenteExecutivo.ToString());
            Console.ReadLine();
        }
    }
}
