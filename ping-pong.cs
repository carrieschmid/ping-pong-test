using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("Enter A Number here");
     string yourNumber = Console.ReadLine();
     int intYourNumber = int.Parse(yourNumber);
     for (int index = 1; index<=intYourNumber; index++ )
     {
       if (index % 3 == 0 && index % 5 == 0)
       {
         Console.WriteLine("Ping-Pong");
       }
       else if (index % 3 == 0)
       {
         Console.WriteLine("Ping");
       }
       else if (index % 5 == 0)
       {
         Console.WriteLine("Pong");
       }
       else
       {
         Console.WriteLine(index);
       }
    }
  }
}
