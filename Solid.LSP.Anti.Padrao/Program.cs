using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP.Anti.Padrao
{
    class Program
    {
        static void Main(string[] args)
        {
            var retangulo = new Retangulo(10, 15);
            var quadrado = new Quadrado(15);

            ObterAreaRetangulo(retangulo);
            ObterAreaRetangulo(quadrado);

            Console.WriteLine(new List<Retangulo>()
            {
                retangulo,
                quadrado,
            });

            Console.ReadLine();
        }

        public static void ObterAreaRetangulo(Retangulo retangulo)
        {
            Console.Write($"A área deste retangulo é: {retangulo.GetArea()} \n");
        }

        public static int ContarTotalRetangulos(List<Retangulo> lista)
        {
            return lista.Count;
        }
    }
}