using System;

namespace ConsoleApp2
{
    class Program
    {    //First Method
        static int[] Populate(int[] toPopulate)
        {
            Random rand = new Random();
            for (int i = 0; i < toPopulate.Length - 1; i++)
            {
                toPopulate [i] = rand.Next();
            }
            return toPopulate;   
        }    //Second Method
        static int[] Sort(int[] toSort)
        {
            int temp=0;

            for (int i = 0; i < toSort.Length; i++)
            {
                for (int j = 0; j < toSort.Length-1; j++)
                {
                    if (toSort[j] > toSort[j + 1])
                    {
                        temp = toSort[j + 1];
                        toSort[j + 1] = toSort[j];
                        toSort[j] = temp;
                    }
                }
            }
            return toSort;
        }    //Third Method
        static int MaxValue(int n, int m, int[] array)
        {
            int max = 0;
            for (int i = n - 1; i < m-1; i++)
            {
                if (array[i] >= array[i + 1])
                {
                    max = array[i];
                }
                else
                {
                    max = array[i + 1];
                }
            }
            return max;
        }    
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a positive number:");
            int userInput = Int32.Parse(Console.ReadLine());  //Converting to integer
            Console.WriteLine();
            int[] myArray;
            myArray = new int[userInput];
            int[] tempArray = new int[userInput];

            myArray = Populate(tempArray);
            myArray = Sort(myArray);   //aplying the first two methods

            Console.WriteLine("Enter the beginning of the threshhold:");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the end of the threshhold:");
            int m = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            int max = 0;
            max = MaxValue(n, m,myArray);    //aplying the third method

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.WriteLine("The highest number in the threshhold is {0}",max); //Displaying the results
            Console.ReadLine();  //Prevending the console from vanishing
        }
    }
}
