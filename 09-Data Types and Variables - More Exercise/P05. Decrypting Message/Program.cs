using System;
using System.Text;

namespace P05._Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int keyNumber = int.Parse(Console.ReadLine());
            int numberOfLine = int.Parse(Console.ReadLine());
            StringBuilder outputMessage = new StringBuilder();
            for (int i = 1; i <= numberOfLine; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                currentChar = (char)((int)currentChar +keyNumber);
                outputMessage.Append(currentChar);
            }
            foreach (var item in outputMessage.ToString())
            {
                Console.Write(item);
            }
        }
    }
}
