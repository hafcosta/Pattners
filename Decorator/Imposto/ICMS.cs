namespace Decorator.Imposto
{
    public class ICMS : Imposto
    {
        public ICMS() { }
        public ICMS(Imposto outroImposto) : base(outroImposto) { }

        public override double CalcularImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.15 + CalcularImpostoAgregado(orcamento);
        }
    }
}
