namespace Determinator;
using System;

internal static class Determinator
{
    internal static int GetSimpleHashCode(string input, int maxValue)
    {
        var hashCode = Math.Abs(GetDeterministicHashCode(input));
        return hashCode % maxValue;
    }

    private static int GetDeterministicHashCode(string input)
    {
        unchecked
        {
            int hash1 = (5381 << 16) + 5381;
            int hash2 = hash1;

            for (int i = 0; i < input.Length; i += 2)
            {
                hash1 = ((hash1 << 5) + hash1) ^ input[i];
                if (i == input.Length - 1)
                    break;
                hash2 = ((hash2 << 5) + hash2) ^ input[i + 1];
            }

            return hash1 + (hash2 * 1566083941);
        }
    }
}
