using System;

namespace FactoryMethod.Carros
{
    public class CarroFactory
    {
        public ICarro RetornarCarro(string modelo)
        {
            switch (modelo)
            {
                case "Vectra":
                    return new Vectra();
                    
                case "Gol":
                    return new Gol();
                    
                case "Golf":
                    return new Golf();
                    
                case "Omega":
                    return new Omega();
                   
                default:
                    throw new Exception("Carro Inexistente");
            }
        }

    }
}
