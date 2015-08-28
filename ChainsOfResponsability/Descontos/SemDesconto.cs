namespace ChainsOfResponsability.Descontos
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double CalcularDesconto(Compras.Compras compras)
        {
            return 0;
        }
    }
}
