using System;

namespace StatePattner
{
    class Program
    {
        /// <summary>
        /// State - Este padrão é usado quando temos um cenario onde nosso objeto
        /// varia de estado de acordo com alguma ação, ou seja, de acordo com o estado do objeto, uma ou outra ação é tomada.
        /// Neste caso, de acordo com o estado do onjeto, podemos ou não aplicar descontos.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Orcamento o = new Orcamento(500);

            Console.WriteLine(o.Valor);

            o.AplicarDesconto();

            Console.WriteLine(o.Valor);

            o.Aprovar();

            o.AplicarDesconto();

            Console.WriteLine(o.Valor);

            Console.Read();

        }
    }
}
