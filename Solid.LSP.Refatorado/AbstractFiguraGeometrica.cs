using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP.Refatorado
{
    public abstract class AbstractFiguraGeometrica
    {
        public double Altura { get; private set; }
        public double Largura { get; private set; }

        public AbstractFiguraGeometrica(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        protected double GetArea()
        {
            return Altura * Largura;
        }
    }
}