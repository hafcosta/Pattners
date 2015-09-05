using System;

namespace FactoryMethod.Carros
{
    public class Vectra : ICarro
    {
        public void Acelerar()
        {
            Console.WriteLine("Vectra Acelerando...");
        }
    }
}
