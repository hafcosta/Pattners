using System;

namespace ObserverPattner.Acoes
{
    public class Persistencia :IAcoes
    {
        public void ExecutarAcao(NotaFiscal.NotaFiscal nf)
        {
            this.PersirtindoNoBanco(nf);
        }

        private void PersirtindoNoBanco(NotaFiscal.NotaFiscal nf)
        {
            Console.WriteLine("Salvando nota fiscal na base de dados");
        }
    }
}
