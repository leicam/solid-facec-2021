using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SRP.Anti.Padrao
{
    public class Funcionario
    {
        private const decimal _percentualINSS = 10.00m;

        public string Documento { get; private set; }
        public string Nome { get; private set; }
        public decimal SalarioBase { get; private set; }
        public TipoFuncionario TipoFuncionario { get; private set; }

        public Funcionario(string documento, string nome, decimal salarioBase, TipoFuncionario tipoFuncionario)
        {
            Documento = documento;
            Nome = nome;
            SalarioBase = salarioBase;
            TipoFuncionario = tipoFuncionario;
        }

        public decimal CalcularSalario()
        {
            var salarioBruto = SalarioBase;

            if (TipoFuncionario.Equals(TipoFuncionario.GerenteExecutivo))
            {
                salarioBruto += 100.00m;
                //outros calculos
            }
            else if (TipoFuncionario.Equals(TipoFuncionario.Supervisor))
                salarioBruto += 50.00m;

            var salarioLiquido = salarioBruto - (salarioBruto * (_percentualINSS / 100));

            return salarioLiquido;
        }

        public decimal ValorBolsa()
        {
            if (TipoFuncionario.Equals(TipoFuncionario.Estagiario))
                return 200.00m;

            return 0.00m;
        }

        public override string ToString()
        {
            return $"Funcionário: {Nome} Remuneração: { CalcularSalario() }";
        }
    }
}
