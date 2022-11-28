
namespace _1._The_Imitation_Game
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] inputParameters = command.Split('|');
                string commandType = inputParameters[0];

                if (commandType == "Move")
                {
                    int numberOfLetters = int.Parse(inputParameters[1]);
                    string substr = message.Substring(0, numberOfLetters);
                    message = message.Remove(0, numberOfLetters);
                    message += substr;
                }
                else if (commandType == "Insert")
                {
                    int index = int.Parse(inputParameters[1]);
                    string value = inputParameters[2];
                    message = message.Insert(index, value);
                }
                else if (commandType == "ChangeAll")
                {
                    string substr = inputParameters[1];
                    string replacement = inputParameters[2];
                    message = message.Replace(substr, replacement);
                }

            }

            Console.WriteLine($"The decrypted message is: {message}");

        }
    }
}
