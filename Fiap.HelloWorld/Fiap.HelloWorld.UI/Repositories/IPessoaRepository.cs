using Fiap.HelloWorld.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Repositories
{
    internal interface IPessoaRepository
    {
        //cadastrar
        void Cadastrar(Pessoa pessoa);

        //listar
        IList<Pessoa> Listar();

        //contar a quantidade de pessoas cadastrars
        int Contar();
    }
}
