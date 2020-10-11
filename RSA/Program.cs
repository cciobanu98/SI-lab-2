using System;
using System.Numerics;

namespace RSA
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyGenerator = new RSAKeyGenerator(128);
            var e = keyGenerator.E; // e and mod it's public key
            var d = keyGenerator.D; //d and mod it's private key
            var mod = keyGenerator.Mod;

            Console.Write("Text: ");
            var msg = Console.ReadLine();

            var enc = RSA.Encrypt(BigInteger.Parse(msg), e, mod);
            Console.WriteLine($"Encrypted message: {enc}");
            var dec = RSA.Decrypt(enc, d, mod);
            Console.WriteLine($"Decypred meessage: {dec}");
        }
    }
}
