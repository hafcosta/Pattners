using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattner.Acoes
{
    public interface IAcoes
    {
        void ExecutarAcao(NotaFiscal.NotaFiscal nf);
    }
}
