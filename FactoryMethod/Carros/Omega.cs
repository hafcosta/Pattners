using System;

namespace FactoryMethod.Carros
{
    public class Omega : ICarro
    {
        public void Acelerar()
        {
            Console.WriteLine("Omega Acelerando...");
        }
    }
}
