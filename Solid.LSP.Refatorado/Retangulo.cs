using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP.Refatorado
{
    public class Retangulo : AbstractFiguraGeometrica
    {
        public Retangulo(double altura, double largura) : base(altura, largura) { }

        public override string ToString()
        {
            return $"Área do Retangulo corresponde há: { GetArea() }";
        }
    }
}