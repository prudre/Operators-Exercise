namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Exercise 1
            int a = 17;

            int b = 4;

            int sum = a + b;

            int subtraction = a - b;

            int multiply = a * b;

            int quotient = a / b;

            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            Console.WriteLine("What is the radius of your circle?");

            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine(AreaOfCircle(radius));
        }

        //Exercise 2


        public static double AreaOfCircle(double radius)
        {

        var area = Math.PI * Math.Pow(radius, 2);

        return area;

        }

    }
}
