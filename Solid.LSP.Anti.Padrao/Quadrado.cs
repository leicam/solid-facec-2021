using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP.Anti.Padrao
{
    public class Quadrado : Retangulo
    {
        public Quadrado(double largura) : base(largura, largura) { }
    }
}