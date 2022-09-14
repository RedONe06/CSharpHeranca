using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitarios;

Console.WriteLine("Boas vindas ao ByteBank ADM!");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
Funcionario pedro = new Funcionario();
pedro.Nome = "João";
pedro.Cpf = "12345";
pedro.Salario = 2000;
gerenciador.Registrar(pedro);

Console.WriteLine("Nome: " + pedro.Nome);
Console.WriteLine("CPF: " + pedro.Cpf);
Console.WriteLine("Salário: " + pedro.Salario);

Diretor paula = new Diretor();
paula.Nome = "Paula";
paula.Cpf = "12345";
paula.Salario = 2000;

Console.WriteLine("Bonificação: " + pedro.getBonificacao());
Console.WriteLine("Bonificação: " + paula.getBonificacao());

gerenciador.Registrar(pedro);
gerenciador.Registrar(paula);

Console.ReadKey();