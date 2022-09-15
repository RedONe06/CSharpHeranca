using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Designer : Funcionario
    {
        public override double getBonificacao()
        {
            // base.getBonificacao(); // Acesso na classe base
            return Salario * 0.17;
        }
        public Designer(string cpf) : base(cpf, 3000)
        {
            Console.WriteLine("Criando um designer");
        }
        public override double AumentarSalario()
        {
            return Salario *= 0.11;
        }
    }
}
