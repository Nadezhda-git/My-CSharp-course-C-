using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dynamic presentation of char table. 
            Byte b = 100;
            b = (Byte)(b + 200); // b now contains 44 (or 2C in Hex)
            Console.WriteLine("Enter count of columns : "); //count columns in console row
            int count_col = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter count of rows : ");   //count rows in one column
            int count_row = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter charachter code from: ");
            int c_from = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter charachter code from: ");
            int c_to = Int32.Parse(Console.ReadLine());

            int x = 1;
            int y = 1;
            int part = 1;
            int line = 1;
            int cur_y = Console.CursorTop;
            for (int c = c_from; c <= c_to; c++)
            {
                Console.SetCursorPosition(part, y + line + cur_y);
                Console.Write("{0}(0x{1:x})", (char)c, c);
                y++; //спускаемся вниз
                if (y % count_row == 1 || count_row == 1)//End of column blocks 
                {
                    x++; 
                    part = Console.CursorLeft + 1;
                    y = y - count_row; //новый столбик
                    if (x % count_col == 1 || count_col == 1) //New row of column blocks
                    {
                        part = 1;
                        x = 1;
                        y = count_row * line + 1; //get down 
                        line++;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
