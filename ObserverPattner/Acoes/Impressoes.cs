using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattner.NotaFiscal;

namespace ObserverPattner.Acoes
{
    public class Impressoes :IAcoes
    {
        private void ImprimirNotaFiscal(NotaFiscal.NotaFiscal nf)
        {
            Console.WriteLine("Imprimindo nota fiscal...");
        }

        public void ExecutarAcao(NotaFiscal.NotaFiscal nf)
        {
            this.ImprimirNotaFiscal(nf);
        }
    }
}
