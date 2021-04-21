using System;

class FindAndReplace
{
  static void Main()
  {
    String phraseOne = "Hello world!";
    Console.WriteLine("OldString : " + phraseOne);
    Console.WriteLine("NewString: " + phraseOne.Replace("world", "universe"));
    Console.WriteLine("\nOldString: " + phraseOne);

    String phraseTwo = "I am walking my cat to the cathedral.";
    Console.WriteLine("OldString : " + phraseTwo);
    Console.WriteLine("NewString: " + phraseTwo.Replace("cat", "dog"));
    Console.WriteLine("\nOldString: " + phraseTwo);

  }
}