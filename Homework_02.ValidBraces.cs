using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    class ValidBraces
    {
        static void Main(string[] args)
        {   
            const int ONE = 1;
            const int TWO = 2;
            const int ZERO = 0;
            //string expression = "{{{{}}[]";
            //Console.WriteLine("Expression: " + expression);
            char isGoOn = 'Y';

            while (isGoOn == 'Y')
            { 
            Console.WriteLine("Enter the expression consist of { } [ ]:");
            string expression = Console.ReadLine();

            if (expression.Length % TWO != ZERO)
            {
                Console.WriteLine("The count of characters can't be odd!");
                Console.ReadKey();
            }

            expression = '*' + expression;

            int indexOpenedBrace = ZERO;
            int codeOpenedBrace = ZERO;
            int i = 1;
            bool is_couple = false;

            for (; i < expression.Length; i++)
            {
                if ((expression[i].Equals('{') || expression[i].Equals('['))
                    && (is_couple == false))
                {
                    indexOpenedBrace = i;
                    codeOpenedBrace = (int)expression[i];
                    is_couple = true;
                }

                if (((int)expression[i] == codeOpenedBrace + TWO) &&
                     (i > indexOpenedBrace) && //index of found closed brace > opened   
                     (is_couple == true) &&
                     ((i - indexOpenedBrace - ONE) % TWO == ZERO || i == (indexOpenedBrace + ONE)) //between couple of braces
                   )
                {
                    expression = expression.Remove(i, ONE);
                    expression = expression.Remove(indexOpenedBrace, ONE);
                    i = ZERO;
                    is_couple = false; //The couple was deleted
                }

                if (is_couple == true && i == expression.Length - ONE)//didn't find closed brace and end of string. Start from this opened brace
                {
                    i = indexOpenedBrace;
                    is_couple = false;
                }

            }

            if (expression.Length > ONE)
            {
                expression = expression.Remove(ZERO, ONE);
                Console.WriteLine("Irregular braces : " + expression);
            }
            else
            {
                Console.WriteLine("Expression is valid!");
            }

            Console.WriteLine("Would you like to enter more expressions (Y/N)?");
            char.TryParse(Console.ReadLine(), out isGoOn);

               switch (isGoOn)
                {
                    case 'Y':
                        break;
                    case 'N':
                        Console.WriteLine("\n ----Thank you for choosing our airlines----");
                        break;
                    default:
                        Console.WriteLine(" You entered the wrong key!! Good by! ");
                        isGoOn = 'N';
                        break;
                }

            }
            Console.ReadKey();
        }
    }
}
