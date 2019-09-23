using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("Enter A Number here");
     string yourNumber = Console.ReadLine();
     int intYourNumber = int.Parse(yourNumber);
     for (int index = 0; index<=intYourNumber; index++ )
     {
       if (intYourNumber % 3 == 0 && intYourNumber % 5 == 0)
       {
         Console.WriteLine("Ping-Pong");
       }
       else if (intYourNumber % 3 == 0)
       {
         Console.WriteLine("Ping");
       }
       else if (intYourNumber % 5 == 0)
       {
         Console.WriteLine("Pong");
       }
       else
       {
         Console.WriteLine(intYourNumber);
       }
    }
  }
}
