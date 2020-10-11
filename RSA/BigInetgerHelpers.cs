using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace RSA
{
    public static class BigInetgerHelpers
    {
        public static BigInteger EulerFunction(BigInteger p, BigInteger q)
        {
            BigInteger m = p - 1;
            BigInteger n = q - 1;
            return m * n;
        }

        public static BigInteger Random(int n)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] randomNumber = new byte[n];
            rng.GetBytes(randomNumber);
            var number = new BigInteger(randomNumber);
            number = BigInteger.Abs(number);
            return number;
        }
    }
}
