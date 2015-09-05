using FactoryMethod.Carros;
using FactoryMethod.Fabricantes;
using System;

namespace FactoryMethod
{
    class Program
    {
        /// <summary>
        /// Factory Method - Utiliza-se este padrão, quando precisamos criar
        /// um objeto diferente de acordo com a decisão do usuario.
        /// Neste caso, se o Usuario informar "Gol", a classe Gol é criada, se informar
        /// Vectra, a classe Vectra é criada e assim por diante.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        { 
            RecuperarCarrosPorFabricantes();

            Console.Read();
        }

        static void RecuperarCarrosPorFabricantes()
        {
            IFabricante fiat = new FabricanteFactory().Recuperar("Fiat");

            fiat.RecuperarCarro("Gol").Acelerar();

        }
        static void RecuperarCarros()
        {
            ICarro vectra = new CarroFactory().RetornarCarro("Vectra");

            vectra.Acelerar();

            ICarro gol = new CarroFactory().RetornarCarro("Gol");

            gol.Acelerar();

            ICarro golf = new CarroFactory().RetornarCarro("Golf");

            golf.Acelerar();

            ICarro omega = new CarroFactory().RetornarCarro("Omega");

            omega.Acelerar();

        }
    }
}
