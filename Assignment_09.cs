using System;

namespace Vivek_Assignment_FAI
{
    class Assignment_09
    {
        static string ReverseByWords(string sentence)
        {
            // Split the sentence into words
            string[] words = sentence.Split(' ');

            // Reverse the order of words
            Array.Reverse(words);

            // Join the words back into a sentence
            string reversedSentence = string.Join(" ", words);

            return reversedSentence;
        }

        static void Main(string[] args)
        {
            // Test the function with different input sentences
            string sentence1 = "my name is vinod and i live in bangalore";
            string reversed1 = ReverseByWords(sentence1);
            Console.WriteLine("{0} => {1}", sentence1, reversed1);

            string sentence2 = "this is a test sentence";
            string reversed2 = ReverseByWords(sentence2);
            Console.WriteLine("{0} => {1}", sentence2, reversed2);

            string sentence3 = "quick brown fox jumps over the lazy dog";
            string reversed3 = ReverseByWords(sentence3);
            Console.WriteLine("{0} => {1}", sentence3, reversed3);
        }
    }
}
