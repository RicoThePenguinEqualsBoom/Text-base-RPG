using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class RNG
    {
        private static readonly RandomNumberGenerator _rng = RandomNumberGenerator.Create();

        public static int NumberBetween(int minValue, int maxValue)
        {
            byte[] randomNumber = new byte[1];

            _rng.GetBytes(randomNumber);

            double asciiRandomValue = Convert.ToDouble(randomNumber[0]);

            double multiplier = Math.Max(0, (asciiRandomValue / 255.0) - 0.00000000001);

            int range = maxValue - minValue + 1;
            double randomInRange = Math.Floor(multiplier * range);

            return (int)(minValue + randomInRange);
        }
    }
}
