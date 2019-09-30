namespace Main
{

public class Program
{
  public bool Main(int YourNumber)
  {
   
     for (int index = 1; index<=YourNumber; index++)
     {
       if (index % 3 == 0 && index % 5 == 0)
       {
         return true;
       }
      //  else if (index % 3 == 0)
      //  {
      //    return true;
      //  }
      //  else if (index % 5 == 0)
      //  {
      //    return true;
      //  }
        // else
        // {
        //  return false;
        // }
     }
     return false;
  }
}
}