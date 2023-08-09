using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Models
{
    //Classe abstrata: não pode ser instanciada e pode conter métodos
    //sem implementação (métodos abstratos)
    internal abstract class Pessoa
    {
        public string Nome { get; set; }
        public char Genero { get; set; }

        //Construtor com Nome
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        //Métodos
        public void Falar(string fala)
        {
            Console.WriteLine($"Pessoa falando: {fala}");
        }

        public abstract void Sonhar();

    }
}
