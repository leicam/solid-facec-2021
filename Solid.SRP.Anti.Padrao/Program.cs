using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SRP.Anti.Padrao
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario1 = new Funcionario("00000000000", "Genérico", 1000.00m, TipoFuncionario.Generico);
            var funcionario2 = new Funcionario("11111111111", "Gerente Executivo", 1200.00m, TipoFuncionario.GerenteExecutivo);

            Console.WriteLine(funcionario1.ToString());
            Console.WriteLine(funcionario2.ToString());

            Console.ReadLine();
        }
    }
}
