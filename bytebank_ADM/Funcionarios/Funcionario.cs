using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        //private int _tipo;
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }
        public double getBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
