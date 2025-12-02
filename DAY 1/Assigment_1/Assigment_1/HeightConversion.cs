using System;
namespace Assigment_1
{
	public class HeightConversion



    {
        static void HeightCoversion()
        {
            Console.Write("Enter height in inches: ");
            double heightInInches = Convert.ToDouble(Console.ReadLine());

            double heightInCM = heightInInches * 2.54;

            Console.WriteLine("Height in CM: " + heightInCM);

            if (heightInCM < 150)
            {
                Console.WriteLine("Category: Short");
            }
            else if (heightInCM >= 150 && heightInCM <= 180)
            {
                Console.WriteLine("Category: Average");
            }
            else
            {
                Console.WriteLine("Category: Tall");
            }

            Console.ReadLine();
        }
    }
}


