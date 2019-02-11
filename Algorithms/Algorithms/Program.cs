using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            CloneArrayToOtherArray();
            Console.ReadKey();
        }

        //Array practice:

        //Write a program in C# Sharp to store elements in an array and print it.
        static void StoreElementsInArray()
        {
            int[] data = new int[10];
            for (int i = 0; i <= data.Length; i++)
            {
                Console.Write("element - {0} : ", i);
                data[i] = Convert.ToInt32(Console.ReadLine());
            
}

            foreach (var item in data)
            {
                Console.Write(item + " ");
            }

        }

        //Write a program in C# Sharp to read n number of values in an array and display it in reverse order.
        static void DisplayArrayNumbersInReverseOrder()
        {
            int[] data = new int[100];
            Console.WriteLine("If you want to stop writing integers to array write - exit and click enter");
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Your integer in a array is {0}", i);
                string userInput = Console.ReadLine();
                if (userInput == "exit")
                {
                    break;
                }
                else
                {
                    data[i] = Convert.ToInt32(userInput);
                }
            }
            
            for (int i = data.Length - 1; i > 0; i--)
            {               
                if (data[i] > 0)
                {
                    Console.Write(data[i] + " ");
                }              
            }            
        }

        //Write a program in C# Sharp to copy the elements one array into another array.
        static void CloneArrayToOtherArray()
        {
            int[] data = new int[5] { 1, 2, 3, 4, 5 };
            int[] dataClone = new int[5];

            dataClone = (int[]) data.Clone();

            foreach (var item in dataClone)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in data)
            {
                Console.Write(item + " ");
            }

        }

    }
}
