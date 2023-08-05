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
        private string? _nome;
        private int _idade;

        //Propriedades Getters/Setters
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }
    }
}

//Tarefa: criar a classe com herança e o atributo
//Funcionario
//Cargo
