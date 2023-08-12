using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Models
{
    internal class Funcionario : Pessoa
    {
        private string _cargo;

        public TipoContrato TipoContrato { get; set; } 

        //Criar o construtor com nome
        public Funcionario(string nome) : base(nome)
        {
        }

        //Criar o construtor com nome e cargo
        public Funcionario(string nome, string cargo) : base(nome)
        {
            _cargo = cargo;
        }

        public string Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

        public override void Sonhar()
        {
            Console.WriteLine("Funcionario sonhando no aumento");
        }
    }//class

    internal enum TipoContrato
    {
        Clt, Pj, Estatutario
    }

}//namespace
