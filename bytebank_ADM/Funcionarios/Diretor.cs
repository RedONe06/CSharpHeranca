using bytebank_ADM.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public override double getBonificacao()
        {
            // base.getBonificacao(); // Acesso na classe base
            return Salario * 0.5;
        }
        public Diretor(string cpf) : base(cpf, 5000)
        {
            Console.WriteLine("Criando um diretor");
        }
        public override double AumentarSalario()
        {
            return Salario *= 1.15;
        }

        public bool Autenticar(string senha)
        {
            throw new NotImplementedException();
        }
    }
}
