using System;
using System.Linq;


    class Program
    {
        static void Main(string[] args)
        {
            int countTwoSameArrays = 0;
            int number = 0;
            int magicNumber = 0;
            bool numberIsFound = false;

            for (int i = 1; i < 999999; i++)
            {
                number = i;
                countTwoSameArrays = 1;
                for (int j = 2; j <= 6; j++)
                {
                    magicNumber = number * j;
                    if (CheckArrayElements(ConvertIntegerToArray(magicNumber)) && CheckArrayElements(ConvertIntegerToArray(number)))
                    {
                        if (CheckIfTwoArraysAreTheSame(ConvertIntegerToArray(magicNumber), ConvertIntegerToArray(number)))
                        {
                            numberIsFound = true;
                            countTwoSameArrays++;
                        }

                    }
                }

                if (numberIsFound == true && countTwoSameArrays == 6)
                {
                    Console.WriteLine("Congrats the number is " + number);
                    Console.ReadKey();
                    return;
                }

            }

        }

        static int[] ConvertIntegerToArray(int number)
        {
            string magicNumberToString = Convert.ToString(number);

            int[] intArray = new int[6];

            if (magicNumberToString.Length == 6)
            {
                for (int i = 0; i < magicNumberToString.Length; i++)
                {
                    char symbal = magicNumberToString[i];
                    int symbalToInt = Convert.ToInt32(symbal - '0');
                    intArray[i] = symbalToInt;

                }
            }
            return intArray;
        }

        static bool CheckArrayElements(int[] number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                for (int j = i + 1; j < number.Length; j++)
                {
                    if (number[i] == number[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static bool CheckIfTwoArraysAreTheSame(int[] array1, int[] array2)
        {
            Array.Sort(array1);
            Array.Sort(array2);
            if (array1.SequenceEqual(array2))
            {
                return true;
            }


            return false;
        }

    }

