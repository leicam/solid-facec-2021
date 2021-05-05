using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP.Refatorado
{
    public class Quadrado : AbstractFiguraGeometrica
    {
        public Quadrado(double valor) : base(valor, valor) { }

        //public Quadrado(double altura, double largura) : base(altura, largura)
        //{
        //    if (altura != largura)
        //        throw new ArgumentOutOfRangeException("Altura não pode ser diferente de largura para um quadrado");
        //}

        public override string ToString()
        {
            return $"Área do Quadrado corresponde a: { GetArea() }";
        }
    }
}