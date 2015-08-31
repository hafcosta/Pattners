using System.Collections.Generic;

namespace BuilderPattner.NotaFiscal
{
    public class ItemNotaFiscal
    {
        public double ValorItem { get; set; }
     
        public ItemNotaFiscal(double valorItem)
        {
            this.ValorItem = valorItem;
           
        }
    }
}
