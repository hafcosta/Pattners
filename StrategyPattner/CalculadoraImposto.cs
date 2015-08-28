namespace StrategyPattner
{
    public class CalculadoraImposto
    {
        public static double AplicarImposto(Orcamento orcamento, Imposto.Imposto imp)
        {
            return imp.CalcularImposto(orcamento);
        }
    }
}
