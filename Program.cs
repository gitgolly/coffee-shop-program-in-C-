using System;
using System.Threading;

namespace lisp_stuff
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Sharp's Coffee Shop!");
      Console.WriteLine("Would you like to see our menu? (yes/no)");

      var menu = new string[]
      {
        "Boba",
        "Coffee",
        "Tea",
        "Bread",
        "Candy"
      };
      
      var wantsToSeeMenu = Console.ReadLine();
      
      if(wantsToSeeMenu == "yes" || wantsToSeeMenu == "Yes")
      {
        foreach(var item in menu)
        {
          Console.WriteLine(item);
        }
        Console.WriteLine("What item would you like?");

        var order = Console.ReadLine();

        Console.WriteLine("You want {0}, right?", string.Format(order));

        var orderComfirmation = Console.ReadLine();

        if(orderComfirmation == "yes")
        {
          Console.WriteLine("Alright! Your order will be ready soon. . . .");
          Thread.Sleep(3000);
          Console.WriteLine("Order is ready! Enjoy!");
          Console.WriteLine("Thank you for coming to Sharp's Coffee Shop!");
        }
        else if(wantsToSeeMenu == "")
        {
          Console.WriteLine("Goodbye! Have a good day!");
        } 
      }
    }
  }
}