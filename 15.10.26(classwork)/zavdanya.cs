using System;
using System.Collections.Generic;
using System.Text;

namespace _15._10._26_classwork_
{
    internal class zavdanya
    {
        static void Main(string[] args)
        {
            /*int result = Multy(1, 5);
            Console.WriteLine(result);

            int Multy(int x, int y)
            {
                int result = 1;

                for (int i = x; i <= y; i++)
                {
                    result = result * i;
                }

                return result;
            }*/ //1


            /*int number = 5;

            bool result = Fibonacci(number);
            Console.WriteLine(result);

            bool Fibonacci(int number)
            {
                int a = 0;
                int b = 1;

                for(int i = 0;i < 20;i++)
                {
                    if (a == number)
                    {
                        return true;
                    }

                    int c = a + b;
                    a = b;
                    b = c;
                }
                return false;
            }*///222

            int[] numbers = { 2, 6, 7, 4, 1 };


            Console.WriteLine("1 - increased");
            Console.WriteLine("2 - deprecising");
            int choice = Convert.ToInt32(Console.ReadLine());

            Sort(numbers, choice);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            static void Sort(int[] numbers,int choice)
            {
                for(int i = 0;i < numbers.Length - 1;i++)
                {
                    for(int j = 0; j < numbers.Length - 1;j++)
                    {
                        if (choice == 1 && numbers[j] > numbers[j + 1])
                        {
                            int temp = numbers[j];
                            numbers[j] = numbers[j + 1];
                            numbers[j + 1] = temp;
                        }

                        if (choice == 2 && numbers[j] < numbers[j + 1])
                        {
                            int temp = numbers[j];
                            numbers[j] = numbers[j + 1];
                            numbers[j + 1] = temp;
                        }
                    }
                }
            }
            

        }
    }
}
