using FactoryMethod.Carros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Fabricantes
{
    public class Fiat : IFabricante
    {
        public ICarro RecuperarCarro(string modelo)
        {
            return new CarroFactory().RetornarCarro(modelo);
        }
    }
}
