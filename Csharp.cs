using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      // Type your required sqare of value and press enter
      Console.WriteLine("Enter Y");

      // Create a string variable and get user input from the keyboard and store it in the variable
      int Y  =Convert.ToInt32 (Console.ReadLine());

      // Print the value of the variable (userName), which will display the input value
       Console.WriteLine(Math.Sqrt(Y));
    }
  }
}
