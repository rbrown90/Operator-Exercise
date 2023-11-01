namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var sum = a + b;
            var quotient = a / b;
            var remainder = a % b;
            var product = a * b;
            var difference = a - b;

            Console.WriteLine($"{a} / {b} is  {quotient} remainder {remainder}");
            Console.WriteLine($"The Sum is {sum}.");
            Console.WriteLine($"The Product is {product}.");
            Console.WriteLine($"The Difference is {difference}.");

            Console.WriteLine("What is the radius of your circle");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));
        }

            public static double AreaOfCircle(double radius)
            {
                var area = Math.PI * Math.Pow(radius, 2);

                return area;
            }
        }
    }