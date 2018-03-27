using System;
using System.Text;

namespace AlphabetCipher
{
    class Cipher
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i+=2)
            {
                //encode(new StringBuilder(args[i].ToLower()),new StringBuilder(args[i+1].ToLower()));
                decode(new StringBuilder(args[i].ToLower()), new StringBuilder(args[i + 1].ToLower()));
            }
        }
        static void encode(StringBuilder keyword, StringBuilder message)
        {
            StringBuilder encodedMessage = new StringBuilder();
            int i = 0;
            for (i = 0; i < message.Length; i++)
            {
                encodedMessage.Append(message[i] - 97 + keyword[i % keyword.Length] > 122 ? (char)(message[i] - 97 + 
                    keyword[i % keyword.Length] - 26) : (char)(message[i] - 97 + keyword[i % keyword.Length]));

            }
            Console.WriteLine(encodedMessage.ToString());
        }

        static void decode(StringBuilder keyword, StringBuilder message)
        {
            StringBuilder actualMessage = new StringBuilder();
            int i = 0;
            for (i = 0; i < message.Length; i++)
            {
                actualMessage.Append(message[i] + 97 - keyword[i % keyword.Length] < 97 ? (char)(message[i] + 97 + 26 - keyword[i % keyword.Length]) : (char)(message[i] + 97 - keyword[i % keyword.Length]));
            }
            Console.WriteLine(actualMessage.ToString());
        }
    }
}
