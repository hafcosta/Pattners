using System.Collections.Generic;

namespace BuilderPattner.NotaFiscal
{
    public class NotaFiscalBuilder
    {
        private double ValorNota { get; set; }
        private double ImpostoNota { get; set; }
        private string RazaoSocial { get; set; }
        private string CNPJ { get; set; }
        private List<ItemNotaFiscal> ItensNota = new List<ItemNotaFiscal>();

        public NotaFiscalBuilder builderRazaoSocial(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder builderCNPJ(string cnpj)
        {
            this.CNPJ = cnpj;
            return this;
        }

        public NotaFiscalBuilder builderImpostoNota(double impostoNota)
        {
            this.ImpostoNota = impostoNota;
            return this;
        }

        public NotaFiscalBuilder builderItemNota(ItemNotaFiscal item)
        {
            ItensNota.Add(item);
            this.ValorNota += item.ValorItem;
            this.ImpostoNota += item.ValorItem * 0.05;
            return this;
        }

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, CNPJ, ImpostoNota, ValorNota, ItensNota);
        }
       
    }
}
