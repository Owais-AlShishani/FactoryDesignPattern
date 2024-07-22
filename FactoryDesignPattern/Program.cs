namespace FactoryDesignPattern
{
    public abstract class Car
    {
        public abstract void Assemble();
    }
    public class BMW : Car
    {
        public override void Assemble()
        {
            Console.WriteLine("Assembling BMW Car.");
        }
    }
    public class Lada : Car
    {
        public override void Assemble()
        {
            Console.WriteLine("Assembling Lada Car.");
        }
    }

    public class Toyota : Car
    {
        public override void Assemble()
        {
            Console.WriteLine("Assembling Toyota Car.");
        }
    }

    public class CarFactory
    {
        public Car CreateFactory(string carType)
        {
            return carType.ToLower() switch
            {
                "bmw" => new BMW(),
                "lada" => new Lada(),
                "toyota" => new Toyota(),
                _ => throw new ArgumentException
                                        ($"Invalid car type: {carType}"),
            };
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CarFactory carFactory = new();

            carFactory.CreateFactory("BMW").Assemble();
            carFactory.CreateFactory("Lada").Assemble();
            carFactory.CreateFactory("Toyota").Assemble();
        }
    }
}