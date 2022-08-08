using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BimCalculator();

        }
        public static void BimCalculator()
        {
            //BIM Calculator
            // Formula: weight in kg divided to body size in m (size * size)

            /*
             * Classification
             * 
             *  Underweight:	less than 18,5
                Normal weight (healthy weight) :	18,5 - 24,9
                Overweight:	25 - 29,9
                Very overweight:	30 - 34,9
                Grade II obesity: 	35 - 39,9
                Grade III obesity:	40 or more            
             * 
             */

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Body Mass Index - calculator ");
            Console.WriteLine("__________________________");
            Console.ResetColor();
            Console.WriteLine(); // line break

            double weight = 0;
            double bodySize = 0;
            double bmi = 0;

            Console.Write("Enter your weight in kilogram: ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your size in meter: ");
            bodySize = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(); // line break
            Console.WriteLine("Classification: ");

            // Calculating the BMI
            bmi = weight / (bodySize * bodySize);

            if (bmi <= 18.5)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Underweight and your BMI is: {bmi}");
                Console.ResetColor();
            }
            else if (bmi == 18.5 || bmi <= 24.9)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Normal weight and your BMI is: {bmi}");
                Console.ResetColor();
            }
            else if (bmi == 25 || bmi <= 29.5)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Overweight and your BMI is: {bmi}");
                Console.ResetColor();

            }
            else if (bmi == 30 || bmi <= 34.9)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Very overweight and your BMI is: {bmi}");
                Console.ResetColor();
            }
            else if (bmi == 35 || bmi <= 39.9)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Grade II obesity and your BMI is: {bmi}");
                Console.ResetColor();
            }
            else if (bmi == 40 || bmi > 40)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Grade III obesity and your BMI is: {bmi}");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Unvalig value");
            }


        }

    }
}

