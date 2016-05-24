﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using DailyProgrammer.Tests;
using DailyProgrammer;

namespace Dailyprogrammer.Tests
{
    [TestClass]
    public class e266_Tests : ITest
    {
        private IChallenge<int[]> challenge;

        [TestInitialize()]
        public void Initialize()
        {
            challenge = new e266_Node_Degrees();
        }

        [TestCategory("e266"), TestMethod]
        public void Example1()
        {
            string[] lines = new string[] { "3", "1 2", "1 3" };

            int[] expected = { 2, 1, 1 };
            int[] actual = challenge.GetResult(lines);
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestCategory("e266"), TestMethod]
        public void Example2()
        {
            string[] lines = new string[] { "16",
                "1 2", "1 3", "2 3", "1 4", "3 4", "1 5", "2 5", "1 6", "2 6", "3 6", "3 7",
                "5 7", "6 7", "3 8", "4 8", "6 8", "7 8", "2 9", "5 9", "6 9", "2 10", "9 10",
                "6 11", "7 11", "8 11", "9 11", "10 11", "1 12", "6 12", "7 12", "8 12", "11 12",
                "6 13", "7 13", "9 13", "10 13", "11 13", "5 14", "8 14", "12 14", "13 14", "1 15",
                "2 15", "5 15", "9 15", "10 15", "11 15", "12 15", "13 15", "1 16", "2 16", "5 16",
                "6 16", "11 16", "12 16", "13 16", "14 16", "15 16"
            };


            int[] expected = { 8, 8, 6, 3, 7, 10, 7, 7, 7, 5, 9, 8, 8, 5, 9, 9 };
            int[] actual = challenge.GetResult(lines);
            CollectionAssert.AreEqual(expected, actual);
        }


    }
}
