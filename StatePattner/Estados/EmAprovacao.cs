using System;

namespace StatePattner.Estados
{
    public class EmAprovacao : IEstado
    {
        public void AplicarDesconto(Orcamento o)
        {
            if(o.contadorDesconto > 1)
            {
                throw new Exception("O orçamento ja teve o valor descontado");
            }

            o.Valor -= o.Valor * 0.05;
        }

        public void Aprovar(Orcamento o)
        {
            o.EstadoAtual = new Aprovado();
        }

        public void Finalizar(Orcamento o)
        {
            throw new Exception("Não é possivel finalizar um orçamento Em Aprovação.");
        }

        public void Reprovar(Orcamento o)
        {
            o.EstadoAtual = new Reprovado();
        }
    }
}
