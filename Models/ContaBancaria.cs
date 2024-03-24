namespace BancoCSharp.Models
{

    public abstract class  ContaBancaria
    {
        public ContaBancaria(Titular titular, DateTime dataAbertura) 
        {
            this.Titular = titular;
            this.DataAbertura = dataAbertura;
   
        }
        public Titular Titular {get;set;}
        public double Saldo {get; private set;}
        public DateTime DataAbertura {get; private set;}
        private readonly double VALOR_MINIMO = 10.0;

   
        public ContaBancaria(Titular titular, double SaldoAbertura)
        {
            Titular = titular;
            Saldo = SaldoAbertura;
            DataAbertura = DateTime.Now; 
        }


         public ContaBancaria(Titular titular)
        {
            Titular = titular;
            Saldo = 0;
            DataAbertura = DateTime.Now; 
        }
    

    public void Depositar(double valor)
    {
        if(valor > VALOR_MINIMO)
        {
            throw new Exception( " O valor mínimo para deposito é de R$ : " + VALOR_MINIMO);
        }

        Saldo += valor;
    }

    public double Sacar(double valor)
    {
        if (valor < VALOR_MINIMO)
        {
            throw new Exception ( " O valor mínimo de saque é de R$ :  " + VALOR_MINIMO);
        }else if (valor > Saldo)
        {
            throw new Exception(" Saldo insulficiente para saque, seu saldo é de R$: " + Saldo);
        }

        Saldo -= valor;
        return valor;
    } 
    public void Transferir(ContaBancaria contaDestino, double valor)
    {
        if (valor < VALOR_MINIMO)
        {
            throw new Exception (" O seu saldo é insulficiente para efetuar transfências, seu saldo é de R$: " + Saldo);
        }else if (valor > Saldo)
        {
            throw new Exception(" O valor mínimo para efetuar transferências é de :  " + VALOR_MINIMO);
        }
        contaDestino.Depositar(valor);
    }

    public virtual void ImprimirExtrato()
    {
        System.Console.WriteLine("AAAAAAAAAAAAA");
    }
   
    }
}