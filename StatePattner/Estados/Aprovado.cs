using System;

namespace StatePattner.Estados
{
    public class Aprovado : IEstado
    {
        public void AplicarDesconto(Orcamento o)
        {
            o.Valor -= o.Valor * 0.02;
        }

        public void Aprovar(Orcamento o)
        {
            throw new Exception("Orçamento já aprovado.");
        }

        public void Finalizar(Orcamento o)
        {
            o.EstadoAtual = new Finalizado();
        }

        public void Reprovar(Orcamento o)
        {
            throw new Exception("Orçamento já aprovado.");
        }
    }
}
