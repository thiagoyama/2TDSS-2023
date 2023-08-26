using Fiap.Banco.Models;
using Fiap.Exercicio01.Exceptions;

//Instanciar uma Conta Corrente com todos os valores
var cc = new ContaCorrente()
{
    Agencia = 123,
    Numero = 234,
    Tipo = TipoConta.Comum,
    DataAbertura = DateTime.Now
};
//Depositar na Conta Corrente
cc.Depositar(10);
//Retirar da Conta Corrente
cc.Retirar(5);
//Exibir o Saldo da Conta
Console.WriteLine(cc.Saldo);

//Instanciar uma Conta Poupanca com todos os valores
var cp = new ContaPoupanca(0.05m)
{
    Agencia = 123,
    Numero = 546,
    Taxa = 1,
    DataAbertura = new DateTime(2020, 5, 15)
};
//Depositar na Conta Poupanca
cp.Depositar(100);

//Ler o valor para a retirada
Console.WriteLine("Digite o valor para o saque");
var valor = Convert.ToDecimal(Console.ReadLine());

try
{
    //Retirar da Conta Poupanca
    cp.Retirar(valor);
}
catch (SaldoInsuficienteException e)
{
    Console.WriteLine(e.Message);
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}

//Exibe o Saldo
Console.WriteLine(cp.Saldo);