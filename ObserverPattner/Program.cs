using ObserverPattner.NotaFiscal;
using System;

namespace ObserverPattner
{
    class Program
    {
        /// <summary>
        /// Padrao Observer - Utiliza-se em cenarios onde precisa-se executar N ações após determinado evento
        /// de maneira desacoplada do codigo principal. Nesse caso, após a geração da nota fiscal, deve-se gerar
        /// varios eventos pertinentes ao negocio, neste caso, o observer se aplica.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            NotaFiscalBuilder builder = new NotaFiscalBuilder();
            builder.AdicionarAcao(new Acoes.EnvioEmail());
            builder.AdicionarAcao(new Acoes.Impressoes());
            builder.AdicionarAcao(new Acoes.Persistencia());


            NotaFiscal.NotaFiscal nf = builder.builderRazaoSocial("Microsoft")
               .builderCNPJ("000.000.000./0001-03")
               .builderItemNota(new ItemNotaFiscal(350))
               .builderItemNota(new ItemNotaFiscal(450))
               .builderItemNota(new ItemNotaFiscal(120))
               .builderItemNota(new ItemNotaFiscal(890))
               .Constroi().Print();

            Console.Read();
        }
    }
}
