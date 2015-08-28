namespace ChainsOfResponsability.Compras
{
    public class Produtos
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Produtos(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
    }
}
