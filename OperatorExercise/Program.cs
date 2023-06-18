using System.ComponentModel.Design;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string yn = "yes";
            bool cont = true;
            while (cont) {
                Console.WriteLine("Hello, welcome to the basic function calculator, please enter the operation number to begin");
                Console.WriteLine("Type 'a' for addition, 's' for subtraction, 'm' for multiplication, and 'd' for division");
                Console.WriteLine("Or type 'c' to calculate the area of a circle");
                string choice = Console.ReadLine();
                if (choice == "a")
                {
                    Console.WriteLine("please type the first number to be added");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("please type the second number to be added");
                    num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine($"the sum of those numbers is {Sum(num1, num2)}");
                }
                else if (choice == "s")
                {
                    Console.WriteLine("please type the first number");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("please type the number to subtract from the first");
                    num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine($"the difference of those numbers is {Difference(num1, num2)}");
                }
                else if (choice == "m")
                {
                    Console.WriteLine("please type the first number to be multiplied");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("please type the second number to be multiplied");
                    num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine($"the product of those numbers is {Product(num1, num2)}");
                }
                else if (choice == "d")
                {
                    Console.WriteLine("please type the first number");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("please type the number to divide the first by");
                    num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine($"the quotient of those numbers is {Quotient(num1, num2)} with a remainder of " +
                        $"{Mod(num1, num2)}");
                }
                else if (choice == "c")
                {
                    Console.WriteLine("Please enter a radius");
                    var radius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"A circle with a radius of {radius} will have an area of {Area(radius)}");
                }
                else
                {
                    Console.WriteLine("Sorry,that's not a valid response");
                }
                Console.WriteLine("Would you like to calculate something else? Please answer 'yes' or 'no'");
                yn = Console.ReadLine();

                if(yn == "yes")
                {
                    cont = true;
                }
                else if (yn == "no")
                {
                    cont = false;
                }
                else
                {
                    Console.WriteLine("that's not a valid repsonse, but I'll assume you mean no lol");
                    cont = false;
                }

            }
        }
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Difference(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Product(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Quotient(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int Mod(int num1, int num2)
        {
            return num1 % num2;
        }
        public static double Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
