using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptingMessage
{
    class Encrypting
    {


       public static string Encrypt(string text)
        {
            char[] answer = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                answer[i] = (char) (97 + ((text[i] + 3 - 97) % 26));                
            }

            string stringAnswer = "";
            foreach (var item in answer)
            {
                stringAnswer += item;
            }
            return stringAnswer;
        }

        public static string Decrypt(string text)
        {
            char[] charArr = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'b' || text[i] == 'c')
                {
                    charArr[i] = (char) (text[i] + 23);
                }
                else if (text[i] == 'W')
                {
                    charArr[i] = ' ';
                }
                else
                {
                charArr[i] = (char) (97 + ((text[i] - 3 - 97) % 26));
                }
            }
            string answer = "";
            foreach (var item in charArr)
            {
                answer += item;
            }
            return answer;
        }
    }
}
