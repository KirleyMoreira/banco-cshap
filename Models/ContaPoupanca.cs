


namespace BancoCSharp.Models
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(Titular titular) : base(titular)
        {
        }

        public ContaPoupanca(Titular titular, DateTime dataAbertura) : base(titular, dataAbertura)
        {
        }

        public ContaPoupanca(Titular titular, double SaldoAbertura) : base(titular, SaldoAbertura)
        {
        }

        public override void ImprimirExtrato()
        {
            System.Console.WriteLine("Iprimir extrato conta poupança");
        }
    }
}