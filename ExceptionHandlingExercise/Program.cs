using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 intList and 3 letters - name it arr
            // Create a list called intList that will hold integers
            // Create an string variable with an empty string initializer - name it str
            char[] charArray = new char[9] { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };
            List<int> intList = new List<int>();
            string str = "";
            int tmpInt = 0;


            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------
            foreach (var character in charArray)
            {
                try
                {
                    //str = character.ToString();
                    //Console.WriteLine($"Char: {character}");
                    int parsedNumber = int.Parse(character.ToString());
                    intList.Add(parsedNumber);
                }//end try
                catch (Exception ex)
                {
                    //Console.WriteLine($"Bad things happened, unabled to read char: {character}");
                    Console.WriteLine($"1st CATCH Unable to Parse '{character}'"); //character will be the name of each item in your collection
                    //Console.WriteLine(ex.Message);
                }//end catch

            }//foreach

            //foreach (var alphaNumericChr in intList)
            //{
            //    Console.WriteLine($"2nd FOREACH in FIRST TRY/CATCH Nbrs: {alphaNumericChr}");

            //}


            //TODO [PART 2] START HERE:
            // Make a foreach loop to iterate through your character array
            
            // Now create a try catch
            // Inside your try block
            // set your string variable to each array element in your char[] to .ToString()
            // Now, using int.Parse, parse your string variable and store in an int variable
            // Then add each int to your list

            // catch your Exception:
            // in the scope of your catch you can use the following, 

            //2nd part
            //foreach (var chrInArrary in charArray)
            //{
            //try
            //    {
            //       str = chrInArrary.ToString();
            //       Console.WriteLine($"2nd TRY BLOCK str: {str}");
            //       tmpInt = int.Parse(str);
            //       intList.Add(tmpInt);
            //    }
            //catch
            //    {
            //        Console.WriteLine($"2nd CATCH POO Happened ");
            //    }
            //}
            //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection

            foreach (var num in intList)
            {
                Console.WriteLine($"VERY LAST FOREACH Nbrs: {num}");
            }
        }
    }
}
