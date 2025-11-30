namespace CiCdDemo
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("CI/CD Demo running...");
        }
    }
}
