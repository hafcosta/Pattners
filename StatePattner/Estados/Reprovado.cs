using System;

namespace StatePattner.Estados
{
    public class Reprovado : IEstado
    {
        public void AplicarDesconto(Orcamento o)
        {
            throw new Exception("Não é possivel aplicar desconto a orçamentos reprovados");
        }

        public void Aprovar(Orcamento o)
        {
            throw new Exception("Não é possivel aprovar orçamentos reprovados");
        }

        public void Finalizar(Orcamento o)
        {
            o.EstadoAtual = new Finalizado();
        }

        public void Reprovar(Orcamento o)
        {
            throw new Exception("Não é possivel reprovar orçamentos reprovados");
        }
    }
}
