using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarysearch1try
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Binary Searcher*****\n\n");

            Console.Write("Please enter the size of the array: ");
            int arraysize = int.Parse(Console.ReadLine());
            int[] array = new int[arraysize];
            int counter = 0, index = 0, smaller = 0;

            Console.WriteLine($"\nYour array will have {arraysize} elements.");

            for (index = 0; index < array.Length; index++)
            {
                Console.Write($"\nPlease enter element {index}: ");
                array[index] = int.Parse(Console.ReadLine());

            }

            index = 0;
            for (counter = 0; counter <= (array.Length - 1) * array.Length; counter++)
            {
                if (array[index] > array[(index + 1)])
                {
                    smaller = array[(index + 1)];
                    array[(index + 1)] = array[index];
                    array[index] = smaller;

                }


                index++;


                if (index >= array.Length - 1)
                {
                    index = 0;

                }


            }

            
            for (index = 0; index < array.Length; index++)
            {
                Console.Write($"{array[index]}; ");
            }

            Console.Write("\nPlease enter element you wish to find in the array: ");
            int key = int.Parse(Console.ReadLine());

            if (key >= array[array.Length/2])
            {
                if (key == array[array.Length / 2])
                    Console.WriteLine($"\n{key} is in position {array.Length/2} in the array.");
                if (key >= array[(array.Length / 4)*2])
                {
                    if (key == array[(array.Length / 4)*3])
                        Console.WriteLine($"\n{key} is in position {(array.Length / 4) * 3} in the array.");

                }
                
                Console.ReadLine();
            }

            
        }
    }
}


