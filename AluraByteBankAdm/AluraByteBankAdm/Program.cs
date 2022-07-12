// See https://aka.ms/new-console-template for more information
using AluraByteBankAdm.Core;
using AluraByteBankAdm.Funcionarios;

Console.WriteLine("Este é o aplicativo de ByteBank Administração");

GerenciadorDeBonificacao gerenciadorDeBonificacao = new GerenciadorDeBonificacao();

Diretor matheus = new Diretor(
    "Matheus", "472444555-35", 7000.0
    );
Funcionario gabi = new Funcionario(
    "Gabriela", "23412364334-35", 5000.0
    );

gerenciadorDeBonificacao.registrar(matheus);



