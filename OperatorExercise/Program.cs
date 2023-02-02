namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)

                Operators.AreaOfACircle();

            Console.WriteLine($"Hello, World! {a} / {b} is {quotient} with {remainder} left over");
        }
    }
}
