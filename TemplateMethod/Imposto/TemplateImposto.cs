namespace TemplateMethod.Imposto
{
    public abstract class TemplateImposto : Imposto
    {
        public double CalcularImposto(Orcamento orcamento)
        {
            if (DeveAplicarTaxacaoMaxima(orcamento))
            {
                return AplicarTaxacaoMaxima(orcamento);
            }

            return AplicarTaxacaoMinima(orcamento);
            
        }

        protected abstract bool DeveAplicarTaxacaoMaxima(Orcamento orcamento);
        protected abstract double AplicarTaxacaoMaxima(Orcamento orcamento);
        protected abstract double AplicarTaxacaoMinima(Orcamento orcamento);
    }
}
