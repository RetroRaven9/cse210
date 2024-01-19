using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> listWithNumbers = new List<int>();

        int numberInList;

        Console.WriteLine("Enter a list of Number, type 0 when finished.");
        

        do
        {
            
            Console.Write("Enter a number");
            string input = Console.ReadLine();

            if(int.TryParse(input, out numberInList))
            {
                if (numberInList != 0)
                {
                    listWithNumbers.Add(numberInList);
                }   
            }
            else
            {
                Console.WriteLine("Invalid input");
            }


        }while (numberInList != 0);

        


        List<int> sortedlist = listWithNumbers.OrderBy(x => x).ToList();
        Console.WriteLine("Sorted list is:");
        foreach (int number in sortedlist)
        {
            Console.WriteLine(number);
        }


    }
    
}
