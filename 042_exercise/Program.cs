using System;

namespace _042_exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exercise1();
            //Exercise2();
            //Exercise3();
            Exercise4();
        }
        public static void Exercise1()
        {
            Console.WriteLine("Hello, could you please give me a number between 1 and 10?:\n");
            var numberFromUser = Console.ReadLine();

            var number = Convert.ToInt32(numberFromUser);

            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid number.");
            }
        }
        public static void Exercise2()
        {
            Console.WriteLine("Hello, could you please give me the first number?:\n");
            var firstNumber = Console.ReadLine();
            Console.WriteLine("Hello, could you please give me the second number?:\n");
            var secondNumber = Console.ReadLine();

            Console.WriteLine(System.Math.Max(Convert.ToInt32(firstNumber), Convert.ToInt32(secondNumber)));

        }

        public static void Exercise3()
        {
            Console.WriteLine("Hello, could you please give me the width of the picture?:\n");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, could you please give me the height of the picture?:\n");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;

            Console.WriteLine("The image orientation according your data is " + orientation);
            


        }

        public static void Exercise4()
        {
            Console.WriteLine("Speed limit?: ");
            var speedLimitFromUserInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Speed of the car?: ");
            var speedOfCarFromUserInput = Convert.ToInt32(Console.ReadLine());

            var KmPerDemeritPoint = 5;


            if (speedOfCarFromUserInput < speedLimitFromUserInput)
            {
                Console.WriteLine("OK");
            }
            else
            {

                double errorPoints = (speedOfCarFromUserInput - speedLimitFromUserInput) / KmPerDemeritPoint;
                if (errorPoints > 12)
                {
                    Console.WriteLine("License suspended!");
                }
                else
                {
                    Console.WriteLine("Demerit points:" + errorPoints);
                }

                
            }
        }
        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }
    }
    


}
