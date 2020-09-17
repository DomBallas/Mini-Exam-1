using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Enter User's name");
   Console.ReadLine();
   Console.WriteLine("Enter height in inches");
   double height = Convert.ToDouble
    (Console.ReadLine());
   Console.WriteLine("Enter weight in pounds");
   double weight = Convert.ToDouble
    (Console.ReadLine());
    double bmi = (703*weight)/(height*height);
    Console.WriteLine("Your bmi is " +   bmi);
     if (bmi>=0 && bmi<=18.5) Console.WriteLine("You are underweight");
    if (bmi>=18.5 && bmi<=24.9) Console.WriteLine("You are a healthy weight");
     if (bmi>=25 && bmi<=29.9) Console.WriteLine("You are Overweight");
     if (bmi>=30) Console.WriteLine("You are Overweight");






    


    


  }
}