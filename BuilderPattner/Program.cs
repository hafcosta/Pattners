using BuilderPattner.NotaFiscal;
using System;

namespace BuilderPattner
{
    class Program
    {
        /// <summary>
        /// O padrão Builder: Utiliza-se este pattner quando é necessário montar objetos muito grandes e complexos
        /// no caso de uma nota fiscal, que possui diversos itens, vindos de diversos lugares, podemos facilitar a montagem
        /// desta nota criando uma classe responsavel por montar a nota ( builder ) , assim, o utilizador da nota economiza um enorme
        /// tempo na montagem e nao precisa conhecer internamente como funciona a criação do objeto.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            NotaFiscal.NotaFiscal nf = new NotaFiscalBuilder().builderRazaoSocial("Microsoft")
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
