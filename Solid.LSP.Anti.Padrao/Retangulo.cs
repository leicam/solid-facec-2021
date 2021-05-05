using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP.Anti.Padrao
{
    public class Retangulo
    {
        public double Altura { get; private set; }
        public double Largura { get; private set; }

        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double GetArea()
        {
            return Altura * Largura;
        }
    }
}