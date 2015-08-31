using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattner.NotaFiscal
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public double ImpostoNota { get; set; }
        public double ValorNota { get; set; }
        public List<ItemNotaFiscal> ItensNota { get; set; }

        public NotaFiscal(string razaoSocial, string cnpj, double impostoNota, double valorNota, List<ItemNotaFiscal> itensNota)
        {
            this.RazaoSocial = razaoSocial;
            this.CNPJ = cnpj;
            this.ImpostoNota = impostoNota;
            this.ValorNota = valorNota;
            this.ItensNota = itensNota;
        }

        public NotaFiscal Print()
        {
            Console.WriteLine(" Empresa: " + RazaoSocial
                + " \n CNPJ: " + CNPJ
                + " \n Valor Nota: " + ValorNota.ToString()
                + " \n Imposto Nota: " + ImpostoNota.ToString());

            Console.WriteLine(" ");

            foreach (ItemNotaFiscal i in ItensNota)
            {
                Console.WriteLine("Valor de cada Item: " + i.ValorItem);
            }

            return this;
        }
    }
}
