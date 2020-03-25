using System;

namespace CaesarCipher
{
    public class EncriptDecript
    {

        private static string _dictionary = "A|B|C|D|E|F|G|H|I|J|K|L|M|N|O|P|Q|R|S|T|U|V|W|Y|X|Z|0|1|2|3|4|5|6|7|8|9";
        public string Commonword { get; set; }
        public string Newword { get; set; }
        public int Pass { get; set; }

        public string EncriptWord()
        {
            //Initiliaze the common variables
            _dictionary = _dictionary.ToUpper();
            string[] words = _dictionary.Split('|');
            string[] arraycommonword = new string[Commonword.Length];
            string encriptword = "";
            int index = 0;

            //Set a array with the commondword positions
            for (int cont = 0; cont < Commonword.Length; cont++)
            {
                arraycommonword[cont] = Commonword.Substring(cont, 1);
            }

            //Set a new encript word checking for a respective index.
            for (int cont = 0; cont < Commonword.Length; cont++)
            {
                index = Array.IndexOf(words, arraycommonword[cont]);
                //Verify the pass number checking with the maximum positions avaliable.
                if (index + Pass >= 0 && index + Pass < 36)
                    encriptword += words[index + Pass];
                else
                    encriptword += words[(index + Pass) - 36];

            }
            Newword = encriptword;
            return encriptword;

        }

        public string DecriyptWord()
        {
            //Initiliaze the common variables
            string[] words = _dictionary.Split('|');
            string[] arraycommonword = new string[Newword.Length];
            string decryptword = "";
            int index = 0;

            //Set a array with the commondword positions
            for (int cont = 0; cont < Newword.Length; cont++)
            {
                arraycommonword[cont] = Newword.Substring(cont, 1);
            }

            //Set a new encript word checking for a respective index.
            for (int cont = 0; cont < Newword.Length; cont++)
            {
                index = Array.IndexOf(words, arraycommonword[cont]);
                //Verify the pass number checking with the maximum positions avaliable.
                if (index - Pass >= 0 && index - Pass < 36)
                    decryptword += words[index - Pass];
                else
                    decryptword += words[(index - Pass) + 36];

            }
            return decryptword;
        }
    }

}

