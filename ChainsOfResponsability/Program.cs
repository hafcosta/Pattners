using ChainsOfResponsability.Compras;
using ChainsOfResponsability.Descontos;
using System;
using System.Collections.Generic;

namespace ChainsOfResponsability
{
    class Program
    {
        /// <summary>
        /// Chais of Responsability - Usa-se esse padrao quando temos um cenario onde
        /// precisamos "achar" a regra adequada a ser executada dentro do cenario.
        /// Neste caso, temos formas diferentes de aplicar desconto em uma compra, de acordo
        /// com os dados da compra ( valor e quantidade de itens nesse caso ), deve ser aplicado um ou outro
        /// desconto, atraves de uma corrente de regras de desconto, localizamos o desconto de acordo com a compra.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Compras.Compras c = new Compras.Compras(750);
            Produtos p = new Produtos("monitor", 700);
            List<Produtos> listaProdutos = new List<Produtos>();
            listaProdutos.Add(p);
            listaProdutos.Add(p);
            listaProdutos.Add(p);
            listaProdutos.Add(p);
            listaProdutos.Add(p);
            listaProdutos.Add(p);

            c.produtos = listaProdutos;

            double valor = CalculadoraDesconto.AplicarDesconto(c);

            Console.WriteLine(valor);
            Console.Read();
            
        }
    }
}
