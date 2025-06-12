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
            // Get a random byte
            byte[] randomNumber = new byte[1];

            _rng.GetBytes(randomNumber);

            double asciiRandomValue = Convert.ToDouble(randomNumber[0]);

            // Normalize the random byte to a value between 0 and 1, avoiding one to avoid rounding issues
            double multiplier = Math.Max(0, (asciiRandomValue / 255.0) - 0.00000000001);

            // Get the difference of the values (+ 1 for rounding)
            int range = maxValue - minValue + 1;
            // Using the difference and the normalized byte, get a random value that isn't larger than the maxValue
            double randomInRange = Math.Floor(multiplier * range);

            // Return the minValue + the random value in range
            return (int)(minValue + randomInRange);
        }
    }
}
