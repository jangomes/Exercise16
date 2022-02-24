using System;

namespace Exercise16
{
    class Program
    {
        /* Create a method named Sum() that accepts any number of integer parameters and displays 
            their sum. Write a Main() method that demonstrates the Sum() method works correctly
            when passed one, three, or five integers, or an array of ten integers*/

        static void Main(string[] args)
        {
            int[] myArray1 = { 2 };
            int[] myArray2 = { 2, 1, 1 };
            int[] myArray3 = { 2, 6, 7, 8, 9, 10, 3, 4, 2, 1 };
            sum(myArray1);
            sum2(myArray2);
            sum3(myArray3);

        }

        public static void sum(int[] myArray1)
        {

            int answer = 0;
            for (int i = 0; i < myArray1.Length; i++)
            {
                answer += myArray1[i];
            }
            Console.WriteLine("The sum is {0}", answer);
        }


         public static void sum2(int[] myArray2)
            {

                int answer = 0;
                for (int i = 0; i < myArray2.Length; i++)
                {
                    answer += myArray2[i];
                }
                Console.WriteLine("The sum is {0}", answer); }

         public static void sum3(int[] myArray3)
            {

                int answer = 0;
                for (int i = 0; i < myArray3.Length; i++)
                {
                    answer += myArray3[i];
                }
                Console.WriteLine("The sum is {0}", answer); }

    }
}
