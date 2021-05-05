using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP.Refatorado
{
    class Program
    {
        static void Main(string[] args)
        {
            //var teste = new AbstractFiguraGeometrica(10, 15);
            //var retangulo = new Retangulo(10, 15);
            //var quadrado = new Quadrado(20);

            //quadrado.GetArea();

            Console.WriteLine(new Retangulo(10, 15).ToString());
            Console.WriteLine(new Quadrado(20).ToString());

            //erro de instancia
            //Console.WriteLine(new List<Retangulo>()
            //{
            //    retangulo,
            //    quadrado,
            //});

            Console.ReadLine();
        }

        public static int ContarTotalRetangulos(List<Retangulo> lista)
        {
            return lista.Count;
        }
    }
}