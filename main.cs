using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter hours: ");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter miles: ");
    int y = Convert.ToInt32(Console.ReadLine());
    int z = 200;
    double total = (z + (x*150) + (y*2));
    //variables are made which store the values needed to estimate total cost

    Console.WriteLine("$" + total);
    //Equation is made which uses variables and prints estimate total cost
  }
}