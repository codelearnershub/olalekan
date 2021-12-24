using System;


namespace CodeChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter the element of array {i+1}: ");
               number [i]= int.Parse(Console.ReadLine());
            }
            MiniMaxSum(number);
        }
        public static void MiniMaxSum(int [] myArray)
        {
            Array.Sort(myArray);
            long minSum = 0;
            long maxSum = 0;
            for (int i = 0; i <= myArray.Length - 2; i++)
            {
                minSum += myArray[i];

            }
            for (int k = 1; k <= myArray.Length - 1; k++)
            {
                maxSum += myArray[k];

            }
            Console.WriteLine($" {minSum}      {maxSum}  ");
        }   
    }
}
