using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGrade(95.8);


            double x = 2.2;
            double y = 1.2;
            double sum = 0;

            double[] numbers = new double[] { 2.2, 1.1, 2.3 };
            // numbers[0] = 2;
            // numbers[1] = 4;
            // numbers[2] = 2.2;
            double arraySum = 0;

            sum = x + y;

            // arraySum = numbers[0] +  numbers[1] +  numbers[2];  
            for (int i=0;i < numbers.Length; i++ ){
                arraySum = numbers[i] + arraySum;
            }

            // List initialization
            var grades = new List<double>() { 100.1, 80.3 };
            grades.Add(80);
            grades.Add(90);
            var listSum = 0.0;

            foreach(var grade in grades)
            {
                listSum += grade;
            }   

            var listAverage = listSum / grades.Count;


    
            Console.WriteLine($"Sum = {sum}");

            Console.WriteLine($"Array Sum = {arraySum}");

            Console.WriteLine($"Sum of items in List = {listSum}");

            Console.WriteLine($"Average of items in List = {listAverage}");


            Console.WriteLine($"Average of items in List = {listAverage}");
        }
    }
}
