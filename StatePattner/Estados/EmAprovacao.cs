using System;

namespace StatePattner.Estados
{
    public class EmAprovacao : IEstado
    {
        public void AplicarDesconto(Orcamento o)
        {
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
