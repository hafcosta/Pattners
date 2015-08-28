namespace ChainsOfResponsability.Descontos
{
    public class DescontoCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }
        
        public double CalcularDesconto(Compras.Compras compras)
        {
            if (compras.produtos.Count > 5)
            {
                return compras.Valor * 0.05;
            }

            return Proximo.CalcularDesconto(compras);
        }
    }
}
