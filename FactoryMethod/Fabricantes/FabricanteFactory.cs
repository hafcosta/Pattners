using System;

namespace FactoryMethod.Fabricantes
{
    public class FabricanteFactory
    {
        public IFabricante Recuperar(string fabricante)
        {
            switch (fabricante)
            {
                case "Fiat":
                    return new Fiat();

                case "Ford":
                    return new Ford();

                default:
                    throw new Exception("Fabricante inexistente");
            }
        }
    }
}
