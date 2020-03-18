using System;
using System.Collections.Generic;
using System.Linq;

namespace SquaredRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var randNums = new List<int>();

            for (int count = 0; count < 20; count++)
                 randNums.Add(rand.Next(1, 51));

            var squaredNums = new List<int>();
            //foreach (var num in randNums)
            //{
            //    var newNum = num * num;
            //    squaredNums.Add(newNum);
            //}

            squaredNums = randNums.Select(x => x * x).ToList();

            var squaredNumNoOdds = new List<int>();
            //foreach (var num in squaredNums)
            //{
            //    if (num % 2 == 0)
            //        squaredNumNoOdds.Add(num);
            //}
            squaredNumNoOdds = squaredNums.Select(x => x % 2).ToList();

        }
    }
}
