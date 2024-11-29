using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Problem 1
            //Console.Write("Enter a string: ");
            //String Input  = Console.ReadLine();

            //try
            //{
            //    int num1 = int.Parse(Input);
            //    Console.WriteLine($"int.Parse: {num1}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"int.Parse failed: {ex.Message}");
            //}
            //try
            //{
            //    int num2 = Convert.ToInt32(Input);
            //    Console.WriteLine($"Convert.ToInt32: {num2}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Convert.ToInt32 failed: {ex.Message}");
            //}

            ///* Question: What is the difference between int.Parse and Convert.ToInt32 
            //   when handling null inputs? 
            //   Answer: int.Parse throws an ArgumentNullException when the input is null, 
            //   while Convert.ToInt32 returns 0.
            //*/ 
            #endregion

            #region Problem 2
            //Console.Write("Enter a number: ");
            //string input = Console.ReadLine();

            //if (int.TryParse(input, out int number))
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number.");
            //}

            ///* Question: Why is TryParse recommended over Parse in user-facing applications?
            //   Answer: TryParse is recommended because it does not throw exceptions on invalid input, 
            //   making it more user-friendly and efficient for handling user input.
            //*/ 
            #endregion


            #region Problem 3
            //object obj; 

            //obj = 18; 
            //Console.WriteLine(obj.GetHashCode()); 

            //obj = "Nour"; 
            //Console.WriteLine(obj.GetHashCode()); 

            //obj = 123.456; 
            //Console.WriteLine(obj.GetHashCode());

            ///* Question: Explain the real purpose of the GetHashCode() method.
            //   Answer: The real purpose of the GetHashCode() method is to generate 
            //   a numeric value that represents the hash code of an object
            // */ 
            #endregion


            #region Problem 4
            //Sample obj1 = new Sample { Value = 10 };
            //Sample obj2 = obj1; // Both references point to the same object

            //obj1.Value = 6;
            //Console.WriteLine($"obj1.Value: {obj1.Value}");
            //Console.WriteLine($"obj2.Value: {obj2.Value}");

            ///* Question: What is the significance of reference equality in .NET?
            //   Answer: Reference equality means that two references point to the same object in memory.
            //   Changes made through one reference are reflected in the other.
            // */ 
            #endregion


            #region Problem 5
            //string S = "Hello";
            //Console.WriteLine($"Before: {S.GetHashCode()}");

            //S += " Hi Willy";
            //Console.WriteLine($"After: {S.GetHashCode()}");

            ///* Question: Why string is immutable in C# ?
            //   Answer: Strings are immutable to ensure security, performance, thread safety, and allow reusability in memory. 
            //   Once created, their value cannot be changed.
            // */ 
            #endregion

            #region Problem 6
            //StringBuilder sb = new StringBuilder("Hi Willy");
            //Console.WriteLine($"Before: {sb.GetHashCode()}");

            //sb.Append(" Have a nice day :) ");
            //Console.WriteLine($"After: {sb.GetHashCode()}");

            ///* Question: How does StringBuilder address the inefficiencies of string concatenation? 
            //   Answer: StringBuilder is mutable and allows modifications without creating new instances,
            //   making it more efficient for frequent changes.
            //*/ 
            #endregion


            /* Question: Why is StringBuilder faster for large-scale string modifications?
               Answer: StringBuilder minimizes memory allocation and copying, 
               which improves performance for large-scale modifications.
            */


            #region Problem 7
            //Console.WriteLine("Enter two numbers:");
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());

            //// Concatenation (+ operator)
            //Console.WriteLine("Sum is " + (num1 + num2));

            //// Composite Formatting  (string.Format)
            //Console.WriteLine(string.Format("Sum is {0}", num1 + num2));

            //// String Interpolation  ($)
            //Console.WriteLine($"Sum is {num1 + num2}");

            ///* Question: Which string formatting method is most used and why?
            //   Answer: String interpolation is most used because it is concise, readable,
            //   and allows embedding expressions directly within string literals,
            //   It is widely used in modern C# applications..
            //*/ 
            #endregion

            #region Problem 8
            //StringBuilder sb = new StringBuilder("Hello ");

            //// Append text
            //sb.Append("World");
            //Console.WriteLine(sb.ToString());

            //// Replace substring
            //sb.Replace("World", "C#");
            //Console.WriteLine(sb.ToString());

            //// Insert string
            //sb.Insert(0, "Coding! ");
            //Console.WriteLine(sb.ToString());

            //// Remove portion of text
            //sb.Remove(0, 7);
            //Console.WriteLine(sb.ToString());

            ///* Question: Explain how StringBuilder is designed to handle frequent modifications compared to strings. 
            //   Answer: It uses a mutable buffer, avoiding the overhead of creating new strings.
            // */ 
            #endregion
        }
        class Sample
        {
            public int Value;
        }
    }
}
