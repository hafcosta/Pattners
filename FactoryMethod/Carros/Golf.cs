using System;

namespace FactoryMethod.Carros
{
    public class Golf : ICarro
    {
        public void Acelerar()
        {
            Console.WriteLine("Golf Acelerando...");
        }
    }
}
