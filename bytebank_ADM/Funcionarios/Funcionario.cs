using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        //private int _tipo;
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int totalDeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            Salario = salario;
            Cpf = cpf;
            Console.WriteLine("Criando um funcionário");
            totalDeFuncionarios++;
        }
        
        public abstract double AumentarSalario();
        public abstract double getBonificacao();
        
    }
}
