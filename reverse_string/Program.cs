﻿//Create a program that asks the user for a string of input and simply returns it in reverse order.
//For instance, they enter “Hello” and it returns “olleH”.

//Added Difficulty: Check if the given string is a palindrome.
//(a palindrome is a word, number, phrase, or other sequence of characters which reads the same
//backward as forward, such as madam or racecar.)

//rocket Tips: If you have problems understanding loops in general you could take a look at Module 3 regarding the debugger

namespace reverse_string

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask user to enter a string
            Console.WriteLine("Enter at least 1 character that you would like to see reversed:\n");

            //variable to store what user has inputted and trim white spaces
            string sentence = Console.ReadLine().Trim().ToLower();

            if (sentence == string.Empty) //if user does not enter any characters
            {
                Console.WriteLine("Please enter at least 1 character!");
                //immediately exit the program
                return;
            }

            //store the reverse of what user has inputted as an empty string
            string reverseSentence = string.Empty;

            //use incrementing method to reverse a string
            for (int position = 0; position < sentence.Length; position++)
            {
                reverseSentence += sentence[sentence.Length - 1 - position];
            }

            //print the sentence in reverse, using .Trim() to remove whitespaces
            Console.WriteLine($"\nThe reverse of {sentence} is {reverseSentence}.");

            //to verify if it's a palindrome, see if sentence is equal to reverseSentence
            //if equal, it's palindrome else it's not a palindrome

            if (sentence == reverseSentence)
            {
                Console.WriteLine($"\n{sentence} is a palindrome!");
            }
            else
            {
                Console.WriteLine($"\n{sentence} is NOT a palindrome!");
            }
        }
    }
}