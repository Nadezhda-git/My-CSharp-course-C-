using System;

namespace ConsoleApp3
{    
    class Polindrom
    {
        /*static*/ void Main(string[] args)
        {   //"AA,,KKJJKK,,AA";
            Console.WriteLine("Enter the sentence:");
            string sentence = Console.ReadLine();

            //Console.WriteLine(sentence);
            bool isPolindrom = true;
            int HALF = 2;
            int ONE = 1;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (char.IsPunctuation((char)sentence[i]) == true)
                {
                    sentence = sentence.Remove(i, ONE);
                    i--;
                }
            }

            for (int j = 0; j < sentence.Length / HALF; j++)
            {
                if (sentence[j].Equals(sentence[sentence.Length - j - ONE]) == false)
                {
                    isPolindrom = false;
                }
            }
            if (isPolindrom == true)
            {
                Console.WriteLine("This is palindrome!");
            }
            else
            {
                Console.WriteLine("This is not palindrome!");
            }
            Console.WriteLine(sentence);
            Console.ReadKey();
        }
    }
}
