using StatePattner.Estados;

namespace StatePattner
{
    public class Orcamento
    {
        internal IEstado EstadoAtual { get; set; }
        internal int contadorDesconto { get; set; } = 0;

        public double Valor { get; set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            EstadoAtual = new EmAprovacao();
        }

        public void AplicarDesconto()
        {
            contadorDesconto++;
            EstadoAtual.AplicarDesconto(this);
        }

        public void Aprovar()
        {
            EstadoAtual.Aprovar(this);
        }

        public void Reprovar()
        {
            EstadoAtual.Reprovar(this);
        }

        public void Finalizar()
        {
            EstadoAtual.Finalizar(this);
        }
    }
}
