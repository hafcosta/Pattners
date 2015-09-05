using System;

namespace FactoryMethod.Carros
{
    public class Gol : ICarro
    {
        public void Acelerar()
        {
            Console.WriteLine("Gol Acelerando...");
        }
    }
}
