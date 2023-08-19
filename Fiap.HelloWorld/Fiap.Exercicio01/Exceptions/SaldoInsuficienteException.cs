using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio01.Exceptions
{
    internal class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException(string mensagem) : base(mensagem) { }

        public SaldoInsuficienteException(decimal saldo) : base($"Saldo insuficiente, valor disponível: {saldo}") { }
    }
}
