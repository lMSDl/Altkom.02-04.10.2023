namespace WPC.DesignPatterns.Creational.AbstractFactory
{
    public interface ICar
    {
        string Name();
    }

    public interface ISedan : ICar
    {

    }

    public interface ISuv : ICar
    {

    }

    public interface ICarFactory
    {
        ISedan ManufactureSedan(string segment);
        ISuv ManufactureSuv(string segment);
    }
}