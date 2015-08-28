using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattner
{
    class Program
    {
        /// <summary>
        ///Strategy - Usa-se quando precisamos efetuar a mesma operação mas de formas
        /// diferentes.
        /// Neste caso, precisamos calcular os impostos sobre o orçamento porem cada imposto tem
        /// sua forma de calculo, entao o padrao strategy se aplica adequadamente. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Imposto.Imposto icms = new Imposto.ICMS();
            Imposto.ISS iss = new Imposto.ISS();

            Orcamento c = new Orcamento();

            c.Valor = 500.00;

            double valorCalculado = CalculadoraImposto.AplicarImposto(c, icms);

            Console.WriteLine(valorCalculado);

            valorCalculado = CalculadoraImposto.AplicarImposto(c, iss);

            Console.WriteLine(valorCalculado);

            Console.Read();

        }
    }
}
