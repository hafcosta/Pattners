using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattner.NotaFiscal;

namespace ObserverPattner.Acoes
{
    public class EnvioEmail : IAcoes
    {
        private void EnviarPorEmail(NotaFiscal.NotaFiscal nf)
        {
            Console.WriteLine("Enviando nota por e-mail...");
        }

        public void ExecutarAcao(NotaFiscal.NotaFiscal nf)
        {
            this.EnviarPorEmail(nf);
        }
    }
}
