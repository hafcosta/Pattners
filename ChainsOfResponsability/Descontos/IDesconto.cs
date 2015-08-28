using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainsOfResponsability.Descontos
{
    public interface IDesconto
    {
        IDesconto Proximo { get; set; }

        double CalcularDesconto(Compras.Compras compras);
    }
}
