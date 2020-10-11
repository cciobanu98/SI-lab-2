using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace RSA
{
    public class RSAKeyGenerator
    {
        private BigInteger p, q; // prime random numbers;
        private BigInteger mod; // mod
        private BigInteger fi; //Euler function
        private BigInteger e = 65537; // constant value; //pulic exponent
        private BigInteger d; //private exponent
        public RSAKeyGenerator(int size)
        {
            GetPAndQ(size);
            mod = p * q;
            fi = BigInetgerHelpers.EulerFunction(p, q);
            GenerateD();

        }

        private void GetPAndQ(int size)
        {
            p = BigInetgerHelpers.Random(size);
            q = BigInetgerHelpers.Random(size);
            p = p.GetNearestPrime();
            q = q.GetNearestPrime();
        }

        private void GenerateD()
        {
            d = e.ModInverse(fi);
        }

        public BigInteger Mod => mod;
        public BigInteger E => e;
        public BigInteger D => d;

    }
}
