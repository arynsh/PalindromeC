using System;
using System.Collections.Generic;



public class Palindromes
{
    public static void Method(string userInput)
    {
        List <string> UserInputSplit = new List <string>(){};
        List <string> UserInputSplit2 = new List <string>(){};
        int userInputLengthHalf = userInput.Length/2;

    
            int j = userInput.Length-1;
            for(int i = 0; i < userInputLengthHalf; i++)
            {
              UserInputSplit.Add(userInput[i].ToString());
            //   Console.WriteLine("I: "+userInput[i].ToString());
            //   Console.WriteLine("J: " + userInput[j].ToString());
                              if (userInput[i].ToString() == userInput[j].ToString())
                {
                    Console.WriteLine("True");
                } 
                else
                {
                    Console.WriteLine("False");
                }
              j--;

            
            }
       
    }

}

public class Program
{
  public static void Main()
  {
      Console.WriteLine("Please enter a word to check if it's a palindrome:");
      string userInput = Console.ReadLine();
      Palindromes.Method(userInput);
  }
}