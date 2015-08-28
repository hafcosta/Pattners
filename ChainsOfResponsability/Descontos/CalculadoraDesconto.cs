namespace ChainsOfResponsability.Descontos
{
    public class CalculadoraDesconto
    {
        public static double AplicarDesconto(Compras.Compras compras)
        {
            IDesconto d1 = new DescontoCincoItens();
            IDesconto d2 = new DescontoMaisQuinhentosReais();
            IDesconto ultimo = new SemDesconto();

            d1.Proximo = d2;

            d2.Proximo = ultimo;

            return d1.CalcularDesconto(compras);
        }
    }
}
