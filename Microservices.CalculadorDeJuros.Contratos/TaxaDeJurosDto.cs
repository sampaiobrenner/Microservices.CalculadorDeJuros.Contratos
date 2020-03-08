using Microservices.CalculadorDeJuros.Contratos.Base;

namespace Microservices.CalculadorDeJuros.Contratos
{
    public class TaxaDeJurosDto : ErrorBase
    {
        public decimal Valor { get; set; }
    }
}