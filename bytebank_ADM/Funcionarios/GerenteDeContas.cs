using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public override double getBonificacao()
        {
            // base.getBonificacao(); // Acesso na classe base
            return Salario * 0.25;
        }
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {
            Console.WriteLine("Criando um gerente de contas");
        }
        public override double AumentarSalario()
        {
            return Salario *= 0.05;
        }
    }
}
