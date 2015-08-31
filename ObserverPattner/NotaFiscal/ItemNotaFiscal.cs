using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattner.NotaFiscal
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
