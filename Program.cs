namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag = true)
            {
                int number1, number2;
                int choice;
                Console.WriteLine("Enter the numbers");
                number1 = int.Parse(Console.ReadLine());
                number2 = int.Parse(Console.ReadLine());
                Console.WriteLine("The result is: " + sum(number1, number2));
                Console.WriteLine("Do you want to continue :\n if yes press 1 if no press 2");
                choice = int.Parse(Console.ReadLine());
               

            }
        }
        static int sum(int x, int y)
        {
            return x + y;
        }
    }
}

