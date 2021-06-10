using System;
using System.Collections.Generic;

namespace firstLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>();
            double sum = 0;
            Console.WriteLine("How many grades you want to add? ");
            string howManyGrades = Console.ReadLine();
            int gradesQuantity = Convert.ToInt32(howManyGrades);


            for (int i = 0; i < gradesQuantity; i++)
            {
            
                Console.WriteLine("\nEnter grade number: " + (i+1));
                string currentGrade = Console.ReadLine();
                double convCurrentGrade = Convert.ToDouble(currentGrade);
                if (convCurrentGrade <=5.5)
                {
                    sum += convCurrentGrade;
                    grades.Add(convCurrentGrade);
                }

                else
                {
                    Console.WriteLine("Wrong input!");
                    i--;
                }
            }

            double average = sum /grades.Count;
            Console.WriteLine($"Average: {average}");


            if (average < 2.0)
            {
                Console.WriteLine("You cannot pass");

            }

            else if(average >= 3.0 && average <= 3.49)
            {
                Console.WriteLine("You earned 3.0 grade");
            }
            else if(average >= 3.5 && average <= 3.99)
            {
                Console.WriteLine("You earned 3.5 grade");
            }
            else if(average >= 3.99 && average <= 4.49)
            {
                Console.WriteLine("You earned 4.0 grade");
            }
            else if(average >= 4.5 && average <= 4.99)
            {
                Console.WriteLine("You earned 4.5 grade");
            }
            else
            {
                Console.WriteLine("Congratulations, you got 5.0");
            }

            Console.WriteLine("Press Enter to quit");
            Console.ReadLine();




        }
    }
}