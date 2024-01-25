using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] intArray = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(intArray);
            //NumberPrinter<int[]>(intArray);

            //TODO: Print the first number of the array
            Console.WriteLine(intArray[0]);
            //TODO: Print the last number of the array            
            Console.WriteLine(intArray[intArray.Length - 1]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(intArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(intArray);
            NumberPrinter(intArray);
            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(intArray);
            NumberPrinter(intArray);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(intArray);
            NumberPrinter(intArray);
            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(intArray);
            NumberPrinter(intArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> intList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.Write("Initial Capacity:\n");
            Console.WriteLine(intList.Capacity);
            Console.WriteLine("---------------------");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(intList);
            //NumberPrinter(intList);

            //TODO: Print the new capacity
            Console.WriteLine("---------------------");
            Console.WriteLine("New Capacity:");
            Console.WriteLine(intList.Capacity);
            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            var userNumber = Console.ReadLine();
            NumberChecker(intList, userNumber);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(intList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(intList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            intList.Sort();
            NumberPrinter(intList);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] newArray = intList.ToArray();
            NumberPrinter(newArray);
            Console.WriteLine("------------------");
            //TODO: Clear the list
            newArray = new int[0];
            NumberPrinter(newArray);
            Console.WriteLine("------------------");
            #endregion
        }
        private static void ListToArray(List<int> numList)
        {

        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.RemoveAt(i);
                }
            }
            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, string searchNumber)
        {
            int isNum = 0;
            if (int.TryParse(searchNumber, out isNum))
            {
                if (numberList.Contains(isNum))
                {
                    Console.WriteLine($"{isNum} is in the List!");
                    return;
                }
                else
                {
                    Console.WriteLine($"{isNum} is not in the list.");
                    return;
                }
            }
            Console.WriteLine($"{searchNumber} is not a number.");
            return;

        }

        private static void Populater(List<int> numberList)
        {
            int count = 0;
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(51));
                count++;
            }
            //Console.WriteLine(count);
            numberList.Remove(0);
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(51);
            }
        }

        private static void ReverseArray(int[] array)
        {
            int[] newArray = new int[array.Length];
            int startIndex = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                newArray[startIndex] = array[i];
                startIndex++;
            }
            startIndex = 0;
            for (int i = 0; i < newArray.Length; i++)
            {
                array[i] = newArray[i];
                startIndex++;
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
