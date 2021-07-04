using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    double[] celsius = new double[7];
    double[] fahrenheit = new double[7];
    double totalaverage = 0;
   
    for (int i = 0; i < celsius.Length; i++) {
      Console.WriteLine("Enter temperature in Celsius");
      celsius[i] = Convert.ToDouble(Console.ReadLine());
      fahrenheit[i] = celsius[i] * 1.8 + 32;
      totalaverage = totalaverage + fahrenheit[i];
    }

    Console.WriteLine("Temperature in Fahrenheit");
    Array.Reverse(fahrenheit);
    for (int i = 0; i < celsius.Length; i++) {
      Console.WriteLine(fahrenheit[i]);
    }
    double averagetemp = totalaverage/7;
    Console.WriteLine("The average weekly temperature is " + averagetemp + " degrees Fahrenheit");
  }
}