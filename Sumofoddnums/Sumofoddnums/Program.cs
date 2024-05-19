using System.Globalization;

namespace Sumofoddnums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(SumOfOddNumbers(1,2,3, 4,5,6,7));
            

          
            Sumofoddnumbers1(1, 2, 3, 4, 5, 6, 7,8,9,10,11,12,13);
        }

        static int SumOfOddNumbers(params int[] numbers)
        {

           int sum = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] %2==0)
                {
                    sum += numbers[i];

                }
               
            }

            return sum;


        }

        static void Sumofoddnumbers1(params int[] nums)
        {
            

            int sum1= 0;

            for (int i = 0; i < nums.Length; i++)
            {   
                if (nums[i] % 2 == 0)
                {
                    sum1 += nums[i];
                    
                }                               
                
            }
            Console.WriteLine(sum1);


        }

    }

}
        

        
          

    

