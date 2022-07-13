using System;

namespace ImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Decode")
                {
                    break;
                }

                string[] tokens = command.Split('|');
                string action = tokens[0];

                switch (action)
                {
                    case "Move":
                        message = Move(message, tokens);

                        break;
                    case "Insert":
                        message = Insert(message, tokens);

                        break;
                    case "ChangeAll":
                        message = ChangeAll(message, tokens);

                        break;
                }
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }

        static string Move(string message, string[] tokens)
        {
            int length = int.Parse(tokens[1]);
            string stringToMove = message.Substring(0, length);

            message = message.Remove(0, length);
            message += stringToMove;
            return message;
        }

        static string Insert(string message, string[] tokens)
        {
            int index = int.Parse(tokens[1]);
            string value = tokens[2];

            message = message.Insert(index, value);
            return message;
        }

        static string ChangeAll(string message, string[] tokens)
        {
            string substring = tokens[1];
            string replacement = tokens[2];

            message = message.Replace(substring, replacement);
            return message;
        }
    }
}
