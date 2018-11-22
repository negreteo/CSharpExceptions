using System;

namespace ExceptionsLibrary {
  public class DemoCode {

    public int GrandParentMethod (int position) {
      int output = 0;

      Console.WriteLine ("Open database connection");

      try {
        output = ParentMethod (position);

        // If you do not have access to the user interface
        // if (position < 0) {
        //   throw new IndexOutOfRangeException ("The value must be >= 0");
        // }

      } catch (Exception ex) {
        // Do not use throw ex or throw new exception so you can get the full stack information, use throw instead
        //throw; 

        // Custom error message
        throw new ArgumentException ("You passed in bad data", ex);
      } finally {
        Console.WriteLine ("Close database connection");
      }

      return output;
    }

    public int ParentMethod (int position) {
      return GetNumber (position);
    }

    public int GetNumber (int position) {
      int output = 0;

      int[] numbers = new int[] { 1, 4, 7, 2 };
      output = numbers[position];

      return output;
    }

  }
}
