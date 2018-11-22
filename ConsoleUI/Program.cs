using System;
using ExceptionsLibrary;

namespace ConsoleUI {
  class Program {
    static void Main (string[] args) {
      DemoCode demo = new DemoCode ();

      try {
        int result = demo.GrandParentMethod (4);
        Console.WriteLine ($"The value at the given position is {result}");
      } catch (ArgumentException ex) {
        Console.WriteLine ("You gave us bad information");
      } catch (Exception ex) {
        Console.WriteLine (ex.Message);
        Console.WriteLine (ex.StackTrace);

        // Get full stack error message, if you are using custom error message in backend
        // You do not need this when using only throw
        var inner = ex.InnerException;

        while (inner != null) {
          Console.WriteLine (inner.StackTrace);
          inner = inner.InnerException;
        }
      }

    }

  }
}
