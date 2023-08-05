// See https://aka.ms/new-console-template for more information
using Fiap.HelloWorld.UI.Models;

Console.WriteLine("Hello, World!");

//Instanciar um Cliente
Cliente cliente = new Cliente();

//Setar o nome
cliente.Nome = "Nelson Ronqui";

//Exibir o nome
Console.WriteLine(cliente.Nome);