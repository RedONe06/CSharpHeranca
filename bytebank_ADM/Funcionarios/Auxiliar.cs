using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {
            Console.WriteLine("Criando um auxiliar");
        }

        public override double getBonificacao()
        {
            // base.getBonificacao(); // Acesso na classe base
            return Salario + 0.2;
        }

        public override double AumentarSalario()
        {
            return Salario *= 0.1;
        }
    }
}
