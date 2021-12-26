class Program
{
    static void Main(string[] args)
    {
        Director director = new Director();
        Car car = director.ConstructCar("1.34BHP", "A25A", "Toyota Star");
        System.Console.WriteLine(car); 
    }
}

class Director
{
    public Car ConstructCar(string enginePower, string carcaseType, string salonType)
    {
        Builder builder = new CarBuilder();
        builder.SetEnginePower(enginePower);
        builder.SetCarcase(carcaseType);
        builder.SetSalon(salonType);
        return builder.GetCar();
    }
}

class CarBuilder : Builder
{
    private Car car;

    public CarBuilder()
    {
        this.car = new Car();
    }

    public void SetEnginePower(string enginePower)
    {
        car.enginePower = enginePower;
    }

    public void SetCarcase(string carcaseType)
    {
        car.carcase = carcaseType;
    }

    public void SetSalon(string salonType)
    {
        car.salon = salonType;
    }

    public Car GetCar()
    {
        return this.car;
    }
}

class Car
{
    public string enginePower;
    public string carcase;
    public string salon;

    public override string ToString()
    {
        return $"Car -- engine power: {this.enginePower}, carcase: {this.carcase}, salon: {this.salon}";
    }
}

interface Builder
{
    void SetEnginePower(string enginePower);
    void SetCarcase(string carcaseType);
    void SetSalon(string salonType);
    Car GetCar();
}
