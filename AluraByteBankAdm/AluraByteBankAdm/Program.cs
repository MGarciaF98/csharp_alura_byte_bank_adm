// See https://aka.ms/new-console-template for more information
using AluraByteBankAdm.Core;
using AluraByteBankAdm.Funcionarios;
using AluraByteBankAdm.ParceriaComercial;
using AluraByteBankAdm.SistemaInterno;

///initSistema();
usarSistema();

Console.ReadKey();

void initSistema()
{

    Console.WriteLine("Este é o aplicativo de ByteBank Administração");

    GerenciadorDeBonificacao gerenciadorDeBonificacao = new GerenciadorDeBonificacao();

    Diretor matheus = new Diretor(
        "Matheus", "472444555-35", 7000.0, "didi","12345"
        );

    Console.WriteLine("Total de funcionários: " + Funcionario.TotalFuncionario);

    Designer gabi = new Designer(
        "Gabriela", "23412364334-35"
        );


    Auxiliar bruno = new Auxiliar(
        "Gabriela", "23412364334-35"
        );

    Console.WriteLine("Total de funcionários: " + Funcionario.TotalFuncionario);

    gerenciadorDeBonificacao.registrar(matheus);
    gerenciadorDeBonificacao.registrar(gabi);
    gerenciadorDeBonificacao.registrar(bruno);

    Console.WriteLine("Salário Matheus: " + matheus.Salario);
    Console.WriteLine("Salário Gabi: " + gabi.Salario);

    Console.WriteLine("Aumentando salários");

    matheus.aumentarSalario();
    gabi.aumentarSalario();

    Console.WriteLine("Salário Matheus: " + matheus.Salario);
    Console.WriteLine("Salário Gabi: " + gabi.Salario);

    gerenciadorDeBonificacao.registrar(matheus);
    gerenciadorDeBonificacao.registrar(gabi);
}

void usarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();

    Diretor roberta = new Diretor("Roberta","222.333.444.55", 4000.00, "roberta123", "12345");


    GerenteDeContas ursula = new GerenteDeContas("Ursula", "999.775.444-11", 3999.99,"ursula123", "1234");

    ParceiroComercial pedro = new ParceiroComercial("pedro123", "1234");


    sistemaInterno.Logar(roberta, "roberta123", "12345");
    sistemaInterno.Logar(ursula, "ursula123", "1234");
    sistemaInterno.Logar(pedro, "pedro123", "1234");

}


