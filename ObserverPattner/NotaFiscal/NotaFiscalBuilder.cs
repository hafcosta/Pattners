using ObserverPattner.Acoes;
using System.Collections.Generic;

namespace ObserverPattner.NotaFiscal
{
    public class NotaFiscalBuilder
    {
        private double ValorNota { get; set; }
        private double ImpostoNota { get; set; }
        private string RazaoSocial { get; set; }
        private string CNPJ { get; set; }
        private List<ItemNotaFiscal> ItensNota = new List<ItemNotaFiscal>();
        private IList<IAcoes> ListaAcoes;

        public NotaFiscalBuilder()
        {
            ListaAcoes = new List<IAcoes>();
        }

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

        public void AdicionarAcao(IAcoes acao)
        {
            this.ListaAcoes.Add(acao);
        }

        public NotaFiscal Constroi()
        {
           NotaFiscal nf = new NotaFiscal(RazaoSocial, CNPJ, ImpostoNota, ValorNota, ItensNota);

            foreach (IAcoes acoes in ListaAcoes)
            {
                acoes.ExecutarAcao(nf);
            }

            return nf;
        }
    }
}
