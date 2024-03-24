
namespace BancoCSharp.Models
{
    public class ContaInvestimento : ContaBancaria
    {
        
        public ContaInvestimento(Titular titular) : base(titular)
        {
        }

        public ContaInvestimento(Titular titular, DateTime dataAbertura) : base(titular, dataAbertura)
        {
        }

        public ContaInvestimento(Titular titular, double SaldoAbertura) : base(titular, SaldoAbertura)
        {
        }
    }
}