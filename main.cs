using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Enter a number: ");
    var num1 = Console.ReadLine(); 
    int x1 = Convert.ToInt32(num1);
    Console.WriteLine("Enter another number: ");
    var num2 = Console.ReadLine();
    int x2 = Convert.ToInt32(num2);
    Console.WriteLine("Sum = "+(x1+x2));
    var sum = (x1+x2);
    Console.WriteLine("Diff = "+(x1-x2));
    var diff = (x1-x2);
    Console.WriteLine("Product = "+(x1*x2));
    var product = (x1*x2);
    Console.WriteLine("Quotient = "+(x1/x2));
    var quotient = (x1/x2);
    Console.WriteLine("Remainder = "+(x1%x2));
    var remainder = (x1%x2);
    Console.WriteLine(sum);
    Console.WriteLine(diff);
    Console.WriteLine(product);
    Console.WriteLine(quotient);
    Console.WriteLine(remainder);

  }
}