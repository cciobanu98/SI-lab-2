using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace RSA
{
    public static class RSA
    {
        public static BigInteger Encrypt(BigInteger number, BigInteger e, BigInteger mod)
        {
            var enc = BigInteger.ModPow(number, e, mod);
            return enc;
        }

        public static BigInteger Decrypt(BigInteger number, BigInteger d, BigInteger mod)
        {
            var dec = BigInteger.ModPow(number, d, mod);
            return dec;
        }
    }
}
