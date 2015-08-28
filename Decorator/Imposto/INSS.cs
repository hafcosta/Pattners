namespace Decorator.Imposto
{
    public class INSS : Imposto
    {
        public INSS()
        { }

        public INSS(Imposto outroImposto) : base(outroImposto) { }

        public override double CalcularImposto(Orcamento orc)
        {
            return orc.Valor * 0.1 + CalcularImpostoAgregado(orc);
        }
    }
}
