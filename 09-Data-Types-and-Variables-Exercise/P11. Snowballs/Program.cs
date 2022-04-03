using System;
using System.Numerics;

namespace P11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowBall = int.Parse(Console.ReadLine());
            int snowBallSnow = 0;
            int highestSnowBallSnow = 0;
            int snowBallTime = 0;
            int highestSnowBallTime = 0;
            int snowBallQuality = 0;
            int highestSnowBallQuality = 0;
            BigInteger snowBallValue = 0;
            BigInteger highestSnowBallValue = 0;
            for (int i = 1; i <= numberOfSnowBall; i++)
            {
                snowBallSnow = int.Parse(Console.ReadLine());
                snowBallTime = int.Parse(Console.ReadLine());
                snowBallQuality = int.Parse(Console.ReadLine());
                snowBallValue = BigInteger.Pow(snowBallSnow / snowBallTime,snowBallQuality);
                if (highestSnowBallValue < snowBallValue)
                {
                    highestSnowBallValue = snowBallValue;
                    highestSnowBallSnow = snowBallSnow;
                    highestSnowBallQuality = snowBallQuality;
                    highestSnowBallTime = snowBallTime;
                }
            }
            Console.WriteLine($"{highestSnowBallSnow} : {highestSnowBallTime} = {highestSnowBallValue} ({highestSnowBallQuality})");
        }
    }
}
