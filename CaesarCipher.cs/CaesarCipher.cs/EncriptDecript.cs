using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class EncriptDecript
    {

        private static string _dictionary = "A|B|C|D|E|F|G|H|I|J|K|L|M|N|O|P|Q|R|S|T|U|V|W|Y|X|Z|0|1|2|3|4|5|6|7|8|9";
        public string commonword { get; set; }
        public string newword { get; set; }
        public int pass { get; set; }
        

        public string EncriptWord()
        {
            //Initiliaze the common variables
            //new add
            _dictionary = _dictionary.ToUpper();
            string[] words = _dictionary.Split('|');
            string[] arraycommonword = new string[commonword.Length];
            string encriptword = "";
            int index = 0;

            //Set a array with the commondword positions
            for (int cont = 0; cont < commonword.Length; cont++)
            {
                arraycommonword[cont] = commonword.Substring(cont, 1);
            }

            //Set a new encript word checking for a respective index.
            for (int cont = 0; cont < commonword.Length; cont++)
            {
                index = Array.IndexOf(words, arraycommonword[cont]);
                //Verify the pass number checking with the maximum positions avaliable.
                if (index + pass >= 0 && index + pass < 36)
                    encriptword += words[index + pass];
                else
                    encriptword += words[(index + pass) - 36];

            }
            newword = encriptword;
            return encriptword;

        }

        public string DecriyptWord()
        {
            //Initiliaze the common variables
            string[] words = _dictionary.Split('|');
            string[] arraycommonword = new string[newword.Length];
            string decryptword = "";
            int index = 0;

            //Set a array with the commondword positions
            for (int cont = 0; cont < newword.Length; cont++)
            {
                arraycommonword[cont] = newword.Substring(cont, 1);
            }

            //Set a new encript word checking for a respective index.
            for (int cont = 0; cont < newword.Length; cont++)
            {
                index = Array.IndexOf(words, arraycommonword[cont]);
                //Verify the pass number checking with the maximum positions avaliable.
                if (index - pass >= 0 && index - pass < 36)
                    decryptword += words[index - pass];
                else
                    decryptword += words[(index - pass) + 36];

            }
            return decryptword;

        }
    }

}

