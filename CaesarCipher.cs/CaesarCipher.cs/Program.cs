using System;
namespace CaesarCipher.cs
{
    public class Program
    {
        static void Main(string[] args)
        {
            EncriptDecript encrypt = new EncriptDecript();
            Console.WriteLine("ENTER WITH YOURE PASSCODE: ");
            encrypt.Commonword = Console.ReadLine();

            Console.WriteLine("ENTER WITH THE PASS POSITIONS: ");
            encrypt.Pass = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("YOURE ENCRYPT WORD IS: " + encrypt.EncriptWord());
            Console.WriteLine("YOURE DECRYPT WORD IS: " + encrypt.DecriyptWord());

            Console.ReadKey();

        }
    }
}
