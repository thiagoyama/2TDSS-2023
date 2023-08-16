using Fiap.HelloWorld.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Repositories
{
    internal class PessoaRepository : IPessoaRepository
    {
        //Gravar em memória as pessoas
        private static IList<Pessoa> _lista = new List<Pessoa>();

        public void Cadastrar(Pessoa pessoa)
        {
            //Nome da pessoa estiver vazio, lançar uma exception
            if (String.IsNullOrEmpty(pessoa.Nome))
            {
                throw new ArgumentException("Nome é obrigatório");
            }
            _lista.Add(pessoa);
        }

        public int Contar()
        {            
            return _lista.Count;
        }

        public IList<Pessoa> Listar()
        {
            return _lista;
        }
    }
}
