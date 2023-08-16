// See https://aka.ms/new-console-template for more information
using Fiap.HelloWorld.UI.Models;
using Fiap.HelloWorld.UI.Repositories;

Console.WriteLine("Hello, World!");

//Instanciar um Cliente
Cliente cliente = new Cliente("Gustavo Carlos");

//Setar o nome
cliente.Nome = "Nelson Ronqui";

//Exibir o nome
Console.WriteLine(cliente.Nome);

//Setar o telefone
cliente.Telefone = "11 9854-5456";

//Exibir o telefone
Console.WriteLine(cliente.Telefone);

//Instanciar uma Pessoa com o nome e genero
Funcionario pessoa = new Funcionario("Juan")
{    
    Genero = 'M',
    TipoContrato = TipoContrato.Clt
};

cliente.Falar("Quero desconto!");

//Adicionar um tipo de contrato para o funcionario
pessoa.TipoContrato = TipoContrato.Pj;

//Exibir o tipo de contrato
Console.WriteLine(pessoa.TipoContrato);

//Instanciar um repository
var repository = new PessoaRepository();

//Cadastrar duas pessoas
repository.Cadastrar(cliente);
repository.Cadastrar(pessoa);

//Cadastrar uma pessoa sem nome
var aluno = new Cliente("");

try
{
    //Tratar a possível exception
    repository.Cadastrar(aluno);
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}

//Exibir a quantidade de pessoas
Console.WriteLine($"Pessoas cadastradas: {repository.Contar()}");

//Exibir o nome de todas as pessoas cadastradas
var lista = repository.Listar();
foreach (var item in lista)
{
    Console.WriteLine(item.Nome);
}

