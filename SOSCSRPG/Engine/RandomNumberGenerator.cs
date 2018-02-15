using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class RandomNumberGenerator
    {

        // Non-deterministic method of generating random numbers
        private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();

        public static int NumberBetween(int min, int max)
        {
            byte[] random = new byte[1];

            _generator.GetBytes(random);

            double asciiValueOfRandomCharacter = Convert.ToDouble(random[0]);

            double multiplier = Math.Max(0, (asciiValueOfRandomCharacter / 255d) - 0.00000000001d);

            int range = max - min + 1;

            double randomValueInRange = Math.Floor(multiplier * range);

            return (int)(min + randomValueInRange);
        }
    }
}
