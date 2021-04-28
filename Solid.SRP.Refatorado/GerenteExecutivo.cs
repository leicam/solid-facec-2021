using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SRP.Refatorado
{
    public class GerenteExecutivo : IFuncionario
    {
        private const decimal _percentualINSS = 10.00m;
        private const decimal _bonus = 100.00m;

        public string Documento { get; private set; }
        public string Nome { get; private set; }
        public decimal SalarioBase { get; private set; }

        public GerenteExecutivo(string documento, string nome, decimal salarioBase)
        {
            Documento = documento;
            Nome = nome;
            SalarioBase = salarioBase;
        }

        public decimal CalcularRemuneracao()
        {
            var salarioBruto = SalarioBase + _bonus;

            return salarioBruto - (salarioBruto * (_percentualINSS / 100));
        }

        public override string ToString()
        {
            return $"Funcionário: { Nome }, Remuneração: { CalcularRemuneracao() }";
        }
    }
}
