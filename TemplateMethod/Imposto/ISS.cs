namespace TemplateMethod.Imposto
{
    public class ISS : TemplateImposto
    {
        protected override double AplicarTaxacaoMaxima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.15;
        }

        protected override double AplicarTaxacaoMinima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        protected override bool DeveAplicarTaxacaoMaxima(Orcamento orcamento)
        {
            if (orcamento.Valor > 2000) return true;

            return false;
        }
    }
}
