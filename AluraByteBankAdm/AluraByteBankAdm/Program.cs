// See https://aka.ms/new-console-template for more information
using AluraByteBankAdm.Core;
using AluraByteBankAdm.Funcionarios;

Console.WriteLine("Este é o aplicativo de ByteBank Administração");

GerenciadorDeBonificacao gerenciadorDeBonificacao = new GerenciadorDeBonificacao();

Diretor matheus = new Diretor(
    "Matheus", "472444555-35", 7000.0
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



