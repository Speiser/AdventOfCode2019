﻿using System;
using AdventOfCode2020.Solutions.Shared;
using NUnit.Framework;

namespace AdventOfCode2020.Solutions
{
    public class Day08 : ISolution
    {
        public void Solve()
        {
            var input = Input.Text(nameof(Day08));
            Console.WriteLine(this.Puzzle1());
            Console.WriteLine(this.Puzzle2());
        }

        private int Puzzle1()
        {
            return -1;
        }

        private int Puzzle2()
        {
            return -1;
        }

        private class Tests
        {
            [Test]
            public void Puzzle1()
            {
                var actual = new Day08().Puzzle1();
                Assert.AreEqual(-1, actual);
            }

            [Test]
            public void Puzzle2()
            {
                var actual = new Day08().Puzzle2();
                Assert.AreEqual(-1, actual);
            }
        }
    }
}