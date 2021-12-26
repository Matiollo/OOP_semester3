class Program
{
    static void Main(string[] args)
    {
        Engine engine = new Hyundai1080Engine();
        Carcase carcase = new SteelCarcase();
        Salon salon = new BlackSalon();
        Car car = Director.ConstructCar(engine, carcase, salon);
        System.Console.WriteLine(car);
    }
}

static class Director
{
    public static Car ConstructCar(Engine engine, Carcase carcase, Salon salon)
    {
        CarBuilder builder = new CarBuilder();
        builder.SetEngine(engine);
        builder.SetCarcase(carcase);
        builder.SetSalon(salon);
        return builder.GetCar();
    }
}

class CarBuilder
{
    private Car car;

    public CarBuilder()
    {
        this.car = new Car();
    }

    public void SetEngine(Engine engine)
    {
        car.engine = engine;
    }

    public void SetCarcase(Carcase carcase)
    {
        car.carcase = carcase;
    }

    public void SetSalon(Salon salon)
    {
        car.salon = salon;
    }

    public Car GetCar()
    {
        return this.car;
    }
}

class Car
{
    public Engine engine;
    public Carcase carcase;
    public Salon salon;

    public override string ToString()
    {
        return $"Car -- engine: {this.engine}, carcase: {this.carcase}, salon: {this.salon}";
    }
}

abstract class Engine
{
    public int power;
    public string name;

    public override string ToString()
    {
        return this.name + '/' + this.power;
    }
}

class Hyundai1080Engine: Engine
{
    public Hyundai1080Engine()
    {
        this.power = 1080;
        this.name = "Hyundai 1080 engine";
    }
}

class Toyota500Engine: Engine
{
    public Toyota500Engine()
    {
        this.power = 500;
        this.name = "Toyota 500 engine";
    }
}

abstract class Carcase
{
    public string name;

    public override string ToString()
    {
        return this.name;
    }
}

class SteelCarcase : Carcase
{
    public SteelCarcase()
    {
        this.name = "Steel";
    }
}

class BronzeCarcase : Carcase
{
    public BronzeCarcase()
    {
        this.name = "Bronze";
    }
}

abstract class Salon
{
    public string design;

    public override string ToString()
    {
        return this.design;
    }
}

class FurSalon : Salon
{
    public FurSalon()
    {
        this.design = "Fur";
    }
}

class BlackSalon : Salon
{
    public BlackSalon()
    {
        this.design = "Black";
    }
}
