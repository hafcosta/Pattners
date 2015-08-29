using System;
using TemplateMethod.Imposto;

namespace TemplateMethod
{
    class Program
    {
        /// <summary>
        /// Template Method - Usamos esse padrao quando temos regras de negocio ( algoritimos )
        /// iguais e classes diferentes. A ideia é criar um template (uma classe ) que contenha a logica do algotitimo
        /// e as classes que precisam , utilizam este template ao inves de implementa-los diretamente.
        /// Neste caso, a forma de calculo de imposto IIS e ICMS é a mesma, portando um template foi criado e os
        /// dois impostos utilizam.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Orcamento o = new Orcamento();
            o.Valor = 2500;

            o.itens.Add(new Itens());
            o.itens.Add(new Itens());
            o.itens.Add(new Itens());
            o.itens.Add(new Itens());
            o.itens.Add(new Itens());
            o.itens.Add(new Itens());

            TemplateImposto icms = new ICMS();
            TemplateImposto iss = new ISS();

            double valorICMS = icms.CalcularImposto(o);
            double valorISS = iss.CalcularImposto(o);

            Console.WriteLine(valorICMS);
            Console.WriteLine(valorISS);

            Console.Read();

        }
    }
}
