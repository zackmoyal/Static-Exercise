namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(32);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(100);

            Console.WriteLine("After temperature conversion:");
            Console.WriteLine();

            Console.WriteLine("Fahrenheit -> Celsius");
            Console.WriteLine($"The temperature of 32 degrees Fahrenheit is {celsius} degrees Celsius.");
            Console.WriteLine();

            Console.WriteLine("Celsius -> Fahrenheit");
            Console.WriteLine($"The temperature of 100 degrees Celsius is {fahrenheit} degrees Fahrenheit.");
        }
    }
}
