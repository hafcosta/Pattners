namespace FactoryMethod.Fabricantes
{
    public interface IFabricante
    {
        Carros.ICarro RecuperarCarro(string modelo);
    }
}
