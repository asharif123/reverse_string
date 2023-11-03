using System.Net.Sockets;

//Create a program that asks the user for a string of input and simply returns it in reverse order.
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
            Console.WriteLine("Please enter a string:\n");
            
            //variable to store what user has inputted
            string sentence = Console.ReadLine();

            //variable to get the length of the sentence
            int sentenceLength = sentence.Length;

            //store the reverse of what user has inputted
            string reverseSentence = "";

            if (sentenceLength == 0) //if user does not enter any characters
            {
                Console.WriteLine("Please enter a sentence having at least 1 character!");
            }
            else if (sentenceLength == 1) //if user only enters 1 character, print that out
            {
                Console.WriteLine(sentence);
                Console.WriteLine("\nThe reverse of {0} is {1}.", sentence, sentence);
            }
            else //if user enters 2 or more characters, store characters in reverse in reverse sentence
            {
                for (int i = sentenceLength-1; i >= 0; i--)
                {
                    reverseSentence += sentence[i];
                }
                //print the sentence in reverse
                Console.WriteLine("\nThe reverse of {0} is {1}.", sentence, reverseSentence);

                //to verify if it's a palindrome, see if sentence is equal to reverseSentence
                //if equal, it's palindrome else it's not a palindrome

                if (sentence == reverseSentence)
                {
                    Console.WriteLine("\n{0} is a palindrome!", sentence);
                }
                else {
                    Console.WriteLine("\n{0} is NOT a palindrome!", sentence);
                }

            }







        }
    }
}