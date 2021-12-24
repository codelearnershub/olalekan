using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of an array: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the target number: ");
            int target = int.Parse(Console.ReadLine());
            int[] nums = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter the number in the array:");
                nums[i] = int.Parse(Console.ReadLine());
            }
            
            
            
                for ( int j = 0; j < nums.Length; j++)
                {
                    if(nums[j] + nums[j] == target)
                    {
                        Console.Write($" {nums[j]},");

                    }
                }
            
           

        }
    }
}

