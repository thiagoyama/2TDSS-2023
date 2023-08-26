using Fiap.Exercicio01.Exceptions;
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

        //Se a conta for comum e o saldo fica negativo depois do saque deve lançar uma exceção e não permitir a retirada.
        public override void Retirar(decimal valor)
        {
            if (Tipo == TipoConta.Comum && Saldo < valor)
            {
                throw new SaldoInsuficienteException(Saldo);
            }
            //Chamar o Retirar do pai (Conta)
            base.Retirar(valor);
        }
    }

    enum TipoConta
    {
        Comum, Especial, Premium 
    }
}
