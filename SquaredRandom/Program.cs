using System;
using System.Collections.Generic;

namespace SquaredRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var randNums = new List<int>();

            for (int count = 1; count <= 20; count++)
                 randNums.Add(rand.Next(1, 51));

            var squaredNums = new List<int>();
            foreach (var num in randNums)
            {
                var newNum = num * num;
                squaredNums.Add(newNum);
            }
        }
    }
}
