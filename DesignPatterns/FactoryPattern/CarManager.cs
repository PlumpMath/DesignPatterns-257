namespace DesignPatterns.FactoryPattern
{
    public class CarManager
    {
        public IAuto GetCar(string carName)
        {
            switch (carName)
            {
                case "audi":
                    return new AudiCar();
                case "toyota":
                    return new ToyotaCar();
                default:
                    return null; 

            }
        }
    }
}
