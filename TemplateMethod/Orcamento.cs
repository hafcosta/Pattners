using System.Collections.Generic;

namespace TemplateMethod
{
    public class Orcamento
    {
        public List<Itens> itens { get; set; }
        public double Valor { get; set; }

        public Orcamento()
        {
            itens = new List<Itens>();
        }
    }
}
