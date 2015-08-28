namespace Decorator.Imposto
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }

        public Imposto()
        {
            this.OutroImposto = null;
        }

        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        public abstract double CalcularImposto(Orcamento orcamento);

        protected double CalcularImpostoAgregado(Orcamento orc)
        {
            if (OutroImposto == null)
            {
                return 0;
            }

            return OutroImposto.CalcularImposto(orc);
        }
    }
}
