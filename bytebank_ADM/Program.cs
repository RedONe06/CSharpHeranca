using bytebank_ADM.Funcionarios;
using bytebank_ADM.Sistema;
using bytebank_ADM.Utilitarios;

Console.WriteLine("Boas vindas ao ByteBank ADM!");
UsarSistema();
CalcularBonificacao();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
    
    Designer pedro = new Designer("833.222.048-39");
    pedro.Nome = "Pedro";

    Desenvolvedor samya = new Desenvolvedor("235423");
    samya.Nome = "Samya";

    Diretor paula = new Diretor("159.753.398-04");
    paula.Nome = "Paula";

    Auxiliar igor = new Auxiliar("981-198.778-53");

    GerenteDeContas camila = new GerenteDeContas("326.985.628-89");
    camila.Nome = "Camila";

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);
    gerenciador.Registrar(samya);

    Console.WriteLine("Total de Bonificação: " + gerenciador.getBonificacao()); 
}

void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();

    Diretor roberta = new Diretor("159.753.398-04");
    roberta.Nome = "Roberta";
    roberta.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("326.985.628-89");
    ursula.Nome = "Ursula";
    ursula.Senha = "321";

    //Funcionario pedro = new Designer("12414");
    //pedro.Nome = "Pedro";
    //pedro.Senha = "123";

    //sistemaInterno.Logar(pedro, "123");
    sistemaInterno.Logar(roberta, "123");
    sistemaInterno.Logar(ursula, "321");
}
Console.ReadKey();