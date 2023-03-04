using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_Conversion
{
    internal class Conversion
    {
        static void Main()
        {
            Console.Write("Enter length (in centimeters): ");
            string input = Console.ReadLine();
            int lengthCm = Convert.ToInt32(input);
            if (lengthCm > 0)
            {
                double lengthIn = Math.Round(lengthCm / 2.54);

                int yards = (int)(lengthIn / 36);
                int feet = (int)((lengthIn % 36) / 12);
                int inches = (int)(lengthIn % 12);

                Console.WriteLine("{0} yards, {1} feet, {2} inches",yards,feet,inches);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }
    }

}
