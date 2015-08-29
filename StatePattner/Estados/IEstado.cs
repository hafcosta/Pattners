namespace StatePattner.Estados
{
    public interface IEstado
    {
        void Aprovar(Orcamento o);
        void Reprovar(Orcamento o);
        void Finalizar(Orcamento o);
        void AplicarDesconto(Orcamento o);
    }
}
