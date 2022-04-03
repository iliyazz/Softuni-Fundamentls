using System;

namespace P10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokemonPowerN = int.Parse(Console.ReadLine());
            int distanceBetweenPokeTargetM = int.Parse(Console.ReadLine());
            int xhaustionFactorY = int.Parse(Console.ReadLine());
            int countTarget = 0;
            int pokemonPowerNOriginal = pokemonPowerN;
            while (pokemonPowerN >= distanceBetweenPokeTargetM)
            {
                pokemonPowerN -= distanceBetweenPokeTargetM;
                countTarget++;
                if (pokemonPowerNOriginal == pokemonPowerN * 2 && xhaustionFactorY != 0)
                {
                    pokemonPowerN /= xhaustionFactorY;
                }
            }
            Console.WriteLine(pokemonPowerN);
            Console.WriteLine(countTarget);
        }
    }
}
