using FactoryMethod.Carros;

namespace FactoryMethod.Fabricantes
{
    public class Ford : IFabricante
    {
        public ICarro RecuperarCarro(string modelo)
        {
            return new CarroFactory().RetornarCarro(modelo);
        }
    }
}
