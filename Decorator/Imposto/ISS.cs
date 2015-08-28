using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Imposto
{
    public class ISS : Imposto
    {
        public ISS() { }
        public ISS(Imposto outroImposto) : base(outroImposto) { }

        public override double CalcularImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalcularImpostoAgregado(orcamento);
        }
    }
}
