namespace ChainsOfResponsability.Descontos
{
    public class DescontoMaisQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double CalcularDesconto(Compras.Compras compras)
        {
            if (compras.Valor > 500.00)
            {
                return compras.Valor * 0.1;
            }

            return Proximo.CalcularDesconto(compras);
        }
    }
}
