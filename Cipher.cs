/*
 * The Alphabet Cipher, published by Lewis Carroll in 1868, is a cipher for passing secret messages. The cipher involves alphabet substitution using a shared keyword. Using the alphabet cipher 
 * to tranmit messages follows this procedure:
 * 
 * ABCDEFGHIJKLMNOPQRSTUVWXYZ
A abcdefghijklmnopqrstuvwxyz
B bcdefghijklmnopqrstuvwxyza
C cdefghijklmnopqrstuvwxyzab
D defghijklmnopqrstuvwxyzabc
E efghijklmnopqrstuvwxyzabcd
F fghijklmnopqrstuvwxyzabcde
G ghijklmnopqrstuvwxyzabcdef
H hijklmnopqrstuvwxyzabcdefg
I ijklmnopqrstuvwxyzabcdefgh
J jklmnopqrstuvwxyzabcdefghi
K klmnopqrstuvwxyzabcdefghij
L lmnopqrstuvwxyzabcdefghijk
M mnopqrstuvwxyzabcdefghijkl
N nopqrstuvwxyzabcdefghijklm
O opqrstuvwxyzabcdefghijklmn
P pqrstuvwxyzabcdefghijklmno
Q qrstuvwxyzabcdefghijklmnop
R rstuvwxyzabcdefghijklmnopq
S stuvwxyzabcdefghijklmnopqr
T tuvwxyzabcdefghijklmnopqrs
U uvwxyzabcdefghijklmnopqrst
V vwxyzabcdefghijklmnopqrstu
W wxyzabcdefghijklmnopqrstuv
X xyzabcdefghijklmnopqrstuvw
Y yzabcdefghijklmnopqrstuvwx
Z zabcdefghijklmnopqrstuvwxy
You must make a substitution chart like this, where each row  ofthe alphabet is rotated by one as each letter goes down the chart. All test cases will utilize this same substitution chart.
 * 
 * 
 * Both people exchanging messages must agree on the secret keyword. To be effective, this keyword should not be written down anywhere, but memorized.

To encode the message, first write it down.

thepackagehasbeendelivered
Then, write the keyword, (for example, snitch), repeated as many times as necessary.

snitchsnitchsnitchsnitchsn
thepackagehasbeendelivered
Now you can look up the column S in the table and follow it down until it meets the T row. The value at the intersection is the letter L. All the letters would be thus encoded.

snitchsnitchsnitchsnitchsn
thepackagehasbeendelivered
lumicjcnoxjhkomxpkwyqogywq
The encoded message is now lumicjcnoxjhkomxpkwyqogywq

To decode, the other person would use the secret keyword and the table to look up the letters in reverse.

Input Description
 * */

using System;
using System.Text;

namespace AlphabetCipher
{
    class Cipher
    {
        public const int MAX = 122;
        public const int MIN = 97;
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i+=2)
            {
                encode(new StringBuilder(args[i].ToLower()),new StringBuilder(args[i+1].ToLower()));
                decode(new StringBuilder(args[i].ToLower()), new StringBuilder(args[i + 1].ToLower()));
            }
        }
        static void encode(StringBuilder keyword, StringBuilder message)
        {
            StringBuilder encodedMessage = new StringBuilder();
            int i = 0;
            for (i = 0; i < message.Length; i++)
            {
                encodedMessage.Append(message[i] - 97 + keyword[i % keyword.Length] > MAX ? (char)(message[i] - 97 + 
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
                actualMessage.Append(message[i] + 97 - keyword[i % keyword.Length] < MIN ? (char)(message[i] + 97 + 26 - keyword[i % keyword.Length]) : (char)(message[i] + 97 - keyword[i % keyword.Length]));
            }
            Console.WriteLine(actualMessage.ToString());
        }
    }
}
