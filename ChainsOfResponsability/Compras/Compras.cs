using System.Collections.Generic;

namespace ChainsOfResponsability.Compras
{
    public class Compras
    {
        public double Valor { get; set; }

        public List<Produtos> produtos { get; set; }

        public Compras(double valor)
        {
            this.Valor = valor;

            this.produtos = new List<Produtos>();
        }
    }
}
