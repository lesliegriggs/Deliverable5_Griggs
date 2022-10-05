// Author: Leslie Griggs
// Date: 10/4/2022
// Description: Deliverable 5 Methods

namespace Methods_1
{
    class Program
    {
        static int[] random_array(int array_length)
        {
            Random random = new Random();
            int[] Array = new int[array_length];
            for (int i = 0; i < array_length; i++)
            {
                Array[i] = random.Next(10,50);
            }
            return Array;
        }
       
        static int sum(int[] Array)
        {
            int sum = Array.Sum();
            return sum;
        }
        static void Main(string[] args)
        {
          
            try
            {
                Console.Write("Please enter an integer between 5 and 15: ");
                int answer = int.Parse(Console.ReadLine());

                if (answer >= 5 & answer <= 15)
                {
                    int[]Array = random_array(answer);
                    Console.Write("The elements of the arrays are: ");

                    foreach (int i in Array)
                    {
                        Console.Write(i + " ");
                    }

                    Console.WriteLine("The sum is: " + sum(Array));

                }

                else
                {
                    Console.WriteLine("Input must be an integer data type between 5 and 15. Please try again.");
                }
                
            }

            catch
            {
                Console.WriteLine("Input must be an integer data type between 5 and 15. Please try again.");
            }
           
           

            


        }
    }
}