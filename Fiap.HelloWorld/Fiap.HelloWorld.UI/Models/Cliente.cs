using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Models
{
    internal class Cliente : Pessoa
    {
        //Atributos, fields
        //private string? _nome;
        private int _idade;

        //Propriedades Getters/Setters
        public string Telefone { get; set; }

        //Construtor com Nome
        public Cliente(string nome) : base(nome) { }

        //CTRL + K + C (Comenta as linhas selecionadas)
        //CTRL + K + U (Descomenta as linhas selecionadas)
        //public string Nome
        //{
        //    get { return _nome; }
        //    set { _nome = value; }
        //}

        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        public override void Sonhar()
        {
            Console.WriteLine("Cliente sonhando com promoções");
        }

        //Sobrescrever o Falar da Pessoa
        public override void Falar(string fala)
        {
            Console.WriteLine($"Cliente Falando: {fala}");
        }

    }
}