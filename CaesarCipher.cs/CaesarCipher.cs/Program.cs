using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //TESTE COMMIT
            EncriptDecript encrypt = new EncriptDecript();
            Console.WriteLine("ENTER WITH YOURE PASSCODE: ");
            encrypt.commonword = Console.ReadLine();

            Console.WriteLine("ENTER WITH THE PASS POSITIONS: ");
            encrypt.pass = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("YOURE ENCRYPT WORD IS: " + encrypt.EncriptWord());
            Console.WriteLine("YOURE DECRYPT WORD IS: " + encrypt.DecriyptWord());
        }
    }
}
