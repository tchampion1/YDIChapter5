using System;
using static System.Console;

namespace ValidID
{
    internal class ValidID
    {
        static void Main(string[] args)
        {
            int idNum;
            string input;
            const int LOW = 1000;
            const int HIGH = 9999;

            Write("Enter an ID number:");
            input = Console.ReadLine();
            idNum = Convert.ToInt32(input);

            while (idNum < LOW || idNum > HIGH)
            {
                WriteLine($"{idNum} is an invalid ID number");
                Write("ID numbers must be");
                WriteLine($"between {LOW} and {HIGH} inclusive");
                Write("Enter an ID number: ");
                input = ReadLine();
                idNum = Convert.ToInt32(input);
                
            }
            WriteLine($"ID number {idNum} is valid");
            ReadLine();
        }
    }
}
