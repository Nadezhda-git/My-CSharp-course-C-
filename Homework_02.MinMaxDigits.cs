using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class MaxMinDigit
    {
       /* static */ void Main(string[] args)
        {
            // 1 - while do 
            // 2 - do while
            // 3 - for
            int version = 3;

            /*------------1 WHILE DO ----------*/
            if (version == 1)
            {
                char isGoOn = 'Y';
                int number = 0;
                int maxVal = 0;
                int minVal = 0;
                int countNumber;
                int index = 1;
                Console.WriteLine("While do. Enter count : ");
                int.TryParse(Console.ReadLine(), out countNumber);

                while (isGoOn == 'Y' || index < countNumber + 1)
                {
                    Console.WriteLine("Enter number {0}): ", index);
                    if (int.TryParse(Console.ReadLine(), out number))
                    {
                        if (index == 1)
                        {
                            maxVal = number;
                            minVal = number;
                        }
                        if (maxVal < number)
                        {
                            maxVal = number;
                        }
                        if (minVal > number)
                        {
                            minVal = number;
                        }
                        index++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong format of number!");
                    }

                    if (index == countNumber + 1)
                    {
                        Console.WriteLine("minVal = " + minVal);
                        Console.WriteLine("maxVal = " + maxVal);
                        Console.WriteLine("Would you like to enter more numbers (Y/N)?");
                        char.TryParse(Console.ReadLine(), out isGoOn);
                        switch (isGoOn)
                        {
                            case 'Y':
                                countNumber++;
                                break;
                            case 'N':
                                Console.WriteLine("\n ----Thank you for choosing our airlines----") ;
                                break;
                            default:
                                Console.WriteLine(" You entered the wrong key!! Good by! ");
                                isGoOn = 'N';
                                break;
                        }
                    }
                }
                Console.WriteLine("Final minVal = " + minVal);
                Console.WriteLine("Final maxVal = " + maxVal);
                Console.ReadKey();
            }
            /*------------2 DO WHILE ----------*/
            if (version == 2)
            {
                char isGoOn = 'Y';
                int number = 0;
                int maxVal = 0;
                int minVal = 0;
                int countNumber;
                int index = 1;
                Console.WriteLine("Do while. Enter count: ");
                int.TryParse(Console.ReadLine(), out countNumber);

                do{
                    Console.WriteLine("Enter number {0}): ", index);
                    if (int.TryParse(Console.ReadLine(), out number))
                    {
                        if (index == 1)
                        {
                            maxVal = number;
                            minVal = number;
                        }
                        if (maxVal < number)
                        {
                            maxVal = number;
                        }
                        if (minVal > number)
                        {
                            minVal = number;
                        }
                        index++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong format of number!");
                    }

                    if (index == countNumber + 1)
                    {
                        Console.WriteLine("minVal = " + minVal);
                        Console.WriteLine("maxVal = " + maxVal);
                        Console.WriteLine("Would you like to enter more numbers (Y/N)?");
                        char.TryParse(Console.ReadLine(), out isGoOn);
                        switch (isGoOn)
                        {
                            case 'Y':
                                countNumber++;
                                break;
                            case 'N':
                                Console.WriteLine("\n *** Thank you for choosing our airlines *** ");
                                break;
                            default:
                                Console.WriteLine(" You entered the wrong key!! Good by! ");
                                isGoOn = 'N';
                                break;
                        }
                    }
                }
                while (isGoOn == 'Y' || index < countNumber + 1);
                Console.WriteLine("Final minVal = " + minVal);
                Console.WriteLine("Final maxVal = " + maxVal);
                Console.ReadKey();

            }
            /*------------3 FOR ----------*/
            if (version == 3)
            {
                char isGoOn = 'Y';
                int number = 0;
                int maxVal = 0;
                int minVal = 0;
                int countNumber;
                int index = 1;
                Console.WriteLine("For loop. Enter count of numbers: ");
                int.TryParse(Console.ReadLine(), out countNumber);

                //while (isGoOn == 'Y' || index < countNumber + 1) ;
                for (; index < countNumber + 1; index++)
                {
                    Console.WriteLine("Enter number {0}): ", index);
                    if (int.TryParse(Console.ReadLine(), out number))
                    {
                        if (index == 1)
                        {
                            maxVal = number;
                            minVal = number;
                        }
                        if (maxVal < number)
                        {
                            maxVal = number;
                        }
                        if (minVal > number)
                        {
                            minVal = number;
                        }
                        //index++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong format of number!");
                        index--;
                    }

                    if (index == countNumber)
                    {
                        Console.WriteLine("minVal = " + minVal);
                        Console.WriteLine("maxVal = " + maxVal);
                        Console.WriteLine("Would you like to enter one more number (Y/N)?");
                        char.TryParse(Console.ReadLine(), out isGoOn);
                        switch (isGoOn)
                        {
                            case 'Y':
                                countNumber++;
                                break;
                            case 'N':
                                Console.WriteLine("\n *** Thank you for choosing our airlines ***");
                                break;
                            default:
                                Console.WriteLine(" You entered the wrong key!! BUM!! ");
                                isGoOn = 'N';
                                break;
                        }
                    }
                }
               
                Console.WriteLine("Final minVal = " + minVal);
                Console.WriteLine("Final maxVal = " + maxVal);
                Console.ReadKey();

            }

        }
    }


}