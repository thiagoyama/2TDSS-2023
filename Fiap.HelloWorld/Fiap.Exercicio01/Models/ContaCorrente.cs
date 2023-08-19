using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Models
{
    //sealed: a classe não pode ser herdada
    internal sealed class ContaCorrente : Conta
    {
        public TipoConta Tipo { get; set; } 

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        //Se a conta for comum e o saldo fica negativo depois do saque deve lançar uma exceção e não permitir a retirada.
        public override void Retirar(decimal valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor não pode ser negativo");
            }
            if (Tipo == TipoConta.Comum && Saldo < valor)
            {
                throw new ArgumentException("Saldo insuficiente");
            }
            Saldo -= valor;
        }
    }

    enum TipoConta
    {
        Comum, Especial, Premium 
    }
}
