using System;

namespace StatePattner.Estados
{
    public class Finalizado : IEstado
    {
        public void AplicarDesconto(Orcamento o)
        {
            throw new Exception("Não é possivel aplicar desconto a orcamentos já finalizados.");
        }

        public void Aprovar(Orcamento o)
        {
            throw new Exception("Não é possivel aprovar orcamentos já finalizados.");
        }

        public void Finalizar(Orcamento o)
        {
            throw new Exception("Não é possivel finalizar orcamentos já finalizados.");
        }

        public void Reprovar(Orcamento o)
        {
            throw new Exception("Não é possivel reprovar orcamentos já finalizados.");
        }
    }
}
