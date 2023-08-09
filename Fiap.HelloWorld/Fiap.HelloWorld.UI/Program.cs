// See https://aka.ms/new-console-template for more information
using Fiap.HelloWorld.UI.Models;

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
Pessoa pessoa = new Funcionario("Juan")
{    
    Genero = 'M'
};


