namespace TemplateMethod.Imposto
{
    public class ICMS : TemplateImposto
    {
        protected override double AplicarTaxacaoMaxima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        protected override double AplicarTaxacaoMinima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }

        protected override bool DeveAplicarTaxacaoMaxima(Orcamento orcamento)
        {
            foreach (Itens i in orcamento.itens)
            {
                if (i.Valor > 500) return true;
            }

            return false;
        }
    }
}
