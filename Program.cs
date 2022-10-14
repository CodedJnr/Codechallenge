using System;

namespace Bismillah
{
    class Program
    {
        static void Main(string[] args)
        {
            //Number1
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter secont number(Numbers must be non-negative): ");
            int num2 = int.Parse(Console.ReadLine());
            
            int count = 0;
            int count2 = 0;
            if(num1 < num2)
            {
                do
                {
                    num2-=num1;
                    count++;
                    if(num1>(num2-num1)) 
                    {
                        num2 = (num2-num1);
                    }
                    count2++;
                } while (num1 != num2);
            }
            else if(num1 > num2)
            {
                do
                {
                    num1-=num2;
                    count++;
                    if(num2>(num1-num2)) 
                    {
                        num1 = (num1-num2);
                    }
                    count2++;
                     
                } while (num1 != num2);
            }
            Console.WriteLine($"The operation can be performed {count+count2} times");

            //Question 2
            Console.Write("How many words are in your input: ");
            int Length = int.Parse(Console.ReadLine());
            string [] myArray = new string [Length];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Input text:");
                string word = Console.ReadLine();
                myArray[i] = word;
                if(word.Length == 1 || word.Length == 2)
                {
                    Console.WriteLine(word.ToLower());
                }
                else
                {
                    string text = word.ToLower();
                    char first = word[1];
                    Console.WriteLine(word[1].ToUpper())
                }
            }

        }
    }
}
