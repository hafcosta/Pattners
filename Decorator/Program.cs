using System;

namespace Decorator
{
    class Program
    {
        /// <summary>
        /// Decorator - Usamos este padrao quando precisamos agregar o comportamento
        /// de um objeto em outro objeto. Neste caso, a aplicação calcula impostos sobre o orcaçemto
        /// porem, pode-se querer agregar um imposto sobre outro imposto, no caso o ICMS tem seu valor agregado
        /// ao valor do ISS, entao, aplica-se o decorator para fazer o calculo de tudo que estiver agregado.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Orcamento c = new Orcamento();
            c.Valor = 1000;

            Imposto.Imposto icms = new Imposto.ICMS(new Imposto.ISS());

            double valor = icms.CalcularImposto(c);

            Console.WriteLine(valor);

            Console.Read();
        }
    }
}
