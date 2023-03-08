using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string userInputySbool;
            int numberLines;
            string nameCharacters;
            string characters = "";
            char spaceCharacter = ' ';

            Console.Write(" Введите имя ");
            userName= Console.ReadLine();
            Console.Write(" Введите символ ");
            userInputySbool= Console.ReadLine();
 
            numberLines = userName.Length;
            nameCharacters = userInputySbool + spaceCharacter + userName + spaceCharacter + userInputySbool;

            for (int i = 0; i < numberLines; i++)
            {
                characters += userInputySbool + spaceCharacter;
            }

            Console.WriteLine(characters);
            Console.WriteLine(nameCharacters);
            Console.WriteLine(characters);
        }
    }
}
