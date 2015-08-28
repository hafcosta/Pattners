namespace StrategyPattner.Imposto
{
    public class ISS : Imposto
    {
        public double CalcularImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }
    }
}
