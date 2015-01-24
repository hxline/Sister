using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientChat
{
    class Encrypted
    {
        private string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ?1234567890`~![@#}$<%^&*)_(+=-,.>/]{";
        private int key = 5;
        private string final;
        private int indexOfChar;

        public string encrypt(string plaintext)
        {
            //int key = 5;
            final = null;
            indexOfChar = 0;

            char encryptedChar;

            //Convert/encrypt each and every character of the text
            foreach (char c in plaintext.ToUpper())
            {
                //Get the index of the character from alphabets variable
                indexOfChar = alphabets.IndexOf(c);

                if (c == ' ')//if encounters an white space
                {
                    final = final + c;
                    //MessageBox.Show("a");
                }
                else if (c == '\n')// if encounters a new line
                {
                    final = final + c;
                    //MessageBox.Show("b");
                }
                else if ((indexOfChar + key) > 61)//if the character is at the end of the string "alphabets"
                {
                    //encrypt the character
                    encryptedChar = alphabets[(indexOfChar + key) - 62];

                    //add the encrypted character to a string every time to get an encrypted string 
                    final = final + encryptedChar;
                }
                else
                {
                    //encrypt the character
                    //add the encrypted character to a string every time to get an encrypted string 
                    encryptedChar = alphabets[indexOfChar + key];
                    final = final + encryptedChar;
                    int sex = indexOfChar + key;
                    //MessageBox.Show(encryptedChar + " " + Text + " " + indexOfChar + " " + sex);
                }
            }
            //textBoxDeskrip.Text.ToCharArray = indexOfChar;
            //Display encrypted text
            //richTextBox1.Clear();
            return final;
        }

        public string decrypt(string chipertext)
        {
            final = null;
            indexOfChar = 0;

            char decryptedChar;

            //Convert/decrypt each and every character of the text
            foreach (char c in chipertext.ToUpper())
            {
                //Get the index of the character from alphabets variable
                indexOfChar = alphabets.IndexOf(c);

                if (c == ' ')//if encounters a white space
                {
                    final = final + c;
                }
                else if (c == '\n')// if encounters a new line
                {
                    final = final + c;
                }
                else if ((indexOfChar - key) < 0)//if the character is at the start of the string "alphabets"
                {
                    //decrypt the character
                    //add the decrypted character to a string every time to get a decrypted string 
                    decryptedChar = alphabets[(indexOfChar - key) + 62];
                    final = final + decryptedChar;
                }
                else
                {
                    //decrypt the character
                    //add the decrypted character to a string every time to get a decrypted string 
                    decryptedChar = alphabets[indexOfChar - key];
                    final = final + decryptedChar;
                }
            }

            //Display decrypted text

            return final;
        }
    }
}
