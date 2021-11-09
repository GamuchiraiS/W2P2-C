using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {   
            //variable for how many numbers to be entered
            int NumbersEntered;
            int Num; //captures every number entered by user
            int[] Values; //array

            Console.WriteLine("How many numbers must be entered:");
            NumbersEntered = Convert.ToInt32(Console.ReadLine());

            //List to store values given by user
            List <int> ValuesList = new List <int> () ;

            //Creating a range based on the numbers that need to be entered
            foreach (int i in Enumerable.Range(1, NumbersEntered)){
                Console.WriteLine("Enter value " + i);
                //Takes user input and converts into int
                Num = Convert.ToInt32(Console.ReadLine());
                //Adds user input into <List>
                ValuesList.Add(Num);

            }
            //Converts list into array
            Values = ValuesList.ToArray();

            //Keeps track off the amount of even and odd nums
            int OddNumbersCounter = 0;
            int EvenNumbersCounter = 0;

            //Checking which numbers are odd or even
            //by using remainder
            foreach (int n in Values)
            {
                if (n % 2 == 0)
                {
                    EvenNumbersCounter++;
                }
                else
                {
                    OddNumbersCounter++;
                }
            }
            Console.WriteLine("The number of odd numbers in the series: " + OddNumbersCounter);
            Console.WriteLine("The number of even numbers in the series: " + EvenNumbersCounter);
            Console.ReadLine();


        }
    }
}
