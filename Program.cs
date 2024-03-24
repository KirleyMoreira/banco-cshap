using BancoCSharp.Models;

Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
Console.WriteLine("$$$$$$$$  BANCO CSHARP  $$$$$$$$");
Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
Console.WriteLine();

var titular01 = new Titular(" Liz Damaceno ", "55566644402", "81986347894");
var titular02 = new Titular(" Luna Moreira", "12345678912", "81987372454");

var conta01 = new ContaCorrente(titular01, 500.0);
var conta02 = new ContaPoupanca(titular02);

try
{
    conta01.Transferir(conta02, 100.0);
}
catch(System.Exception ex)
{
    System.Console.WriteLine(ex.Message);
}
 
Console.WriteLine(conta01.Saldo);
Console.WriteLine(conta02.Saldo);

System.Console.WriteLine("Extrato conta02");
conta02.ImprimirExtrato();