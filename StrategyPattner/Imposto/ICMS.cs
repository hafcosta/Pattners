using System;

namespace StrategyPattner.Imposto
{
    public class ICMS : Imposto
    {
        public double CalcularImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.5;
        }
    }
}
