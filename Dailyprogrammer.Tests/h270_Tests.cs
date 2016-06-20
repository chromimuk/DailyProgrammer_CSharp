﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using DailyProgrammer.Tests;
using System;
using DailyProgrammer;

namespace Dailyprogrammer.Tests
{
    [TestClass]
    public class h270_Tests : ITest
    {
        private IChallenge<int> challenge;

        [TestInitialize]
        public void Initialize()
        {
            challenge = new h270_Alien_Invasion();
        }

        [TestMethod, TestCategory("h270")]
        public void Example1()
        {
            string[] lines =
            {
                "5",
                "X--X-",
                "-----",
                "-----",
                "-----",
                "---X-"
            };

            int expected = 9;
            int actual = challenge.GetResult(lines);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod, TestCategory("h270")]
        public void Example2()
        {
            string[] lines =
            {
                "50",
                "--X---------X----------------------X---XXX--------",
                "-X----------X-------------------XX------XX--XX--X-",
                "---------X---X--X-------XX----------------------X-",
                "----------------------X----X---XX---X-------X----X",
                "------------------X----------X--------X----------X",
                "----XX---X----------------X---X-X-----------------",
                "---X----------------------------------X-------X---",
                "-X-------X--XX----------X----X--X--X----------X---",
                "---------X---------------X----------------------X-",
                "-------------X------------------------X-----------",
                "-X---------------------------XX----------X--------",
                "--X--------------------X-X--------------------X---",
                "X---X-----------X-------------X------------X------",
                "---X-----------------------X-------------------X--",
                "-------X--------------X--X-----X------------------",
                "--------X------X------X----------XXX----X--X---X-X",
                "------------------X-------X----X--X---------------",
                "----X----X----------------------------------X-----",
                "-----------X-----X--------X--------X--------------",
                "--X------X-------------X--------------------X-----",
                "------X----X----------------------X---------XX----",
                "----XX----------X-----------------X---------X-X---",
                "-----X------X------X----X-------XXX-X-------------",
                "---X-X--------------------------------------------",
                "-----------------X----------------X---------------",
                "----X-------------X----------------------X--X-----",
                "------X---------XX--X---------X--------X----------",
                "XX--------X-----------------X-------------X---X---",
                "-----------X-X--------X---X--------X---X--------X-",
                "-------------------X-------XXX---X----------------",
                "-------X-----X-------------------------------X----",
                "----X------X------X--X---------------X------------",
                "--------X--------X--------------X-----------------",
                "--------X------------------X-------X--------X---X-",
                "X--X--X---X------X----------X--X--X---------------",
                "-----------X--X-------------X-----------------X---",
                "--------------X-------X-----X-----------------X---",
                "-----------------X----------------------X-X--X----",
                "----------------X----------------------------X----",
                "---------------X----------X-----------X-----------",
                "---X-X-----------------XX----X-----XX------------X",
                "--X-X-------------------X-------------------X--X--",
                "--X------X----------------------------------------",
                "----X-------------------------X---X--------X-----X",
                "X--XX----X-------------X---X----------------------",
                "---------X---------------------------------------X",
                "X-------X---------X--X-----XX--------------X------",
                "------XX---------X--X---------X-------------------",
                "--------X----------X---X--X-----X------X-----X----",
                "----------------------------------------------X---"
            };

            int expected = 49;
            int actual = challenge.GetResult(lines);
            Assert.AreEqual(expected, actual);
        }



        [TestMethod, TestCategory("h270")]
        public void Example3()
        {
            string[] lines =
            {
                "100",
                "--------------X------X-----------X-X---X--X--X----X--------X--------------------X-------------------",
                "-------------------X-X--------------------------------X-----------------X---------X-----X-----------",
                "------------X------X------------------------X----X--------XXX---------------X---------------------XX",
                "-----------------------------X-------------------------------X-----------X-----X------------X--X----",
                "---------------------------X-------------XX------------XX---X-X--X----------X---X---X------X--------",
                "----------------X--X---------------X--------X-X--X---------------X--------------------X-------------",
                "--XX------X-X--------X-----------XX-X-----X-------XX--------X-X----------------------------------X--",
                "---------X-------X-------------------X---------XX---------------X----------X-X-X-----------X-------X",
                "-X---------------X-X--------X--X---X-----------------------------------------X-X---X-----X-X----XXXX",
                "------X----------------------------------X--X----X--X--X--------------X------X---------X------X-X---",
                "-X---X--------X---------------XX----------------X-----------X--X-X--------------X--X-----X----------",
                "X-X----X-----------------X-X---------------------X----------X-------------------X-----------X-------",
                "-X-----X---XX------X--X---------X--XX----X----X--------------XXX--X-------------X-------X--X----X---",
                "-----X-------------X-X---------------X---------------------X---------XX-----------------------------",
                "X--------------------------------------X-XX---------------X----------------------------------------X",
                "-X------------X-------X--X-----------X-------X------X----------X-------------------X------X-X----X--",
                "X-----X--X-X------------------X--------X---------------X--------X-----------------------------------",
                "-------------X--------X------------------------X-XX---------------X-XX------------X-----------------",
                "---X--------------------X--X--X---------X-------X-------------X----X------------X--X---X------------",
                "--------------------X-----------X--------------------X------------------------------------------X---",
                "-------------X----X----X-------X--------X-X-----X-XX-------------------X-XX----X---------X---X----X-",
                "---------------XX--------------X----------------------X---X-------------X-----------X---------X-----",
                "---X------------------------X-------------------------X--X-X---------------X----X-------------------",
                "-----------------X-----------------X---------X---------X--------------X-------X----------X----------",
                "-------------X--------X--------X--------------------------------X--X-----X----X---------------------",
                "----X----X--X--------X-----X----------------------------X----------X-----------X-X-------X----------",
                "-XX---X----------------X---------X-X-----X-----------------X---X---------X--------------X-XX---X----",
                "-------------X-----XX-------X----X-------X------------X-------X-X----X-----X-X-------------------XX-",
                "-----X------------X-----X---------------X----------X----------X--XX-------X-X-----X-----X-----------",
                "--------X----X----X------X--------------X-------X----------X---X---X---X--------------X--X----------",
                "---------X-----------------------XX--X-----------X-----------XX--------------X--------------X-------",
                "X-----------------------------------X------X-----------------------------------------------XX-----X-",
                "-------X---------X-----X-------------X-----X-----------X----X-------------------X-----X------X------",
                "X--------------------------------------------------------------------------------X-----X------------",
                "-------X------------------------X-----X-X--X------X----------XX--X-------------X-------------------X",
                "--------------X-X---------X------------X-----------X-------------X----------X-------X---------------",
                "X-X-X-------------X-----------------------X---X---X--X--------XX---X-----------X---------X----------",
                "-----------X--------------XXX----XX------------------------------------X--X--X-X-------X-X---------X",
                "-------------------------X-----------------X----------------------XX--X--X------X-------------X-----",
                "--X-X---X-X----------------X---X-------X------XX-----------------X---X--X-------------X-X---X------X",
                "------X-----X--------X---X----X------------------------X---X----X-------------------X---------------",
                "---------------X-----------X-----X---------X-------------X---------X----X----------X---X--X-X--X----",
                "---------------------X--------X--X-X--------------------------X----------X----------------------X---",
                "X---X---X--X----------X------------X----------X-X------X-------------------X------X------------X----",
                "----X---X---X-X--X-------------------X---------X---X---X------X----------------X------X-------------",
                "-X-------X-------X----------------------X----------------X--------X-----X----------------------XX--X",
                "---------XX-X---X--X-----------X--X--------------X-------------X--------------X----X----------------",
                "-----------------------X------------X------------------------X------X-----------X-----XX-----X----X-",
                "---------------------X---X----XX---------X---------------------------------X--X---X-----------X---X-",
                "-----X----X-----X-X-------------X-X-----------X--X-------XX--------------X----X-X----XXX---X--------",
                "-----------------X-X-------------X-----X-------X-XX-------------X----------------X-X----------X-----",
                "------------X-X----------X---------------------------------X------X--------X---X---X----------------",
                "--X------------------------X---------X---------------X------X-------X-----XX--------X----X-------X--",
                "---XXX--------------------------X------X-----X-----------X-------------------X--------XX----------X-",
                "---------X----X-------X-X-X---------------X-X----X--------------X-----X----------X----------------X-",
                "--------X--X-X---------X------------------X---------X---------------------X----------------X--------",
                "-----------------X------------------X----------X---X---XX-----X---X--------------------------------X",
                "---------------------X-X----------XX--XX-----X-------X--X-----X---------X-X---------X---X-----------",
                "-----X-------------X-X--------X----------X-----------------X-X-----X----------X----X----------X---X-",
                "-------------------X-------X--X---X--X--X----------X-----------------------X--------X--X-------X---X",
                "----X------X------XX------X---------------------------X--X----------------X---------------X------X--",
                "--X---X------X----------X------------X-X-X-----------X-X---------------X----X------------X----------",
                "-------X--X-----XX----------X-----------------------------------X---------------------------------X-",
                "-----X-----------XX-------X-----------------X----X---------XX------X-----X---X------XX---X--X-------",
                "---------X----------------X----X-X-----------X------X--------X-X--------------------------X----X----",
                "X----------------------X-----------------X-------X---X--------------X-X-X-XX------X----------X--X-X-",
                "X-----X------X-----------------------------X---------------------X----------X-XX------X-X-X-------X-",
                "------------X---X--X------X-X---------X-----X---------X-------------------------X-------------X-----",
                "---------------------X---X---------X------------------------------------------X-------X-X-----------",
                "-----------------X--------XX----------X---X----------------X-----------------------X----------------",
                "-XX-------X-----X--------------------X-------X---X-------------X-------X--X---X-------X-------X-----",
                "-----------X--------XX----X---X------X------X---X--------------------------------------X----X------X",
                "--------------X------X--XX-------XX-------------X---------X---X---------X------X-------X------------",
                "----XX----------------------------------------X-------X---------X-------------------X--------------X",
                "----------------X---X--------X----X--X-------------X---XX---X---------------X----X--X---------------",
                "---------------X------------------X------X--X---------X--------------X---X-----------X--------X-----",
                "----------X-------X------------X-X------X----X---------------------X--X----------X----------------X-",
                "---------X------X-----------------------------------------------------X---X------X------------------",
                "-----X-----------------X------------------------------X-------X-----X--X-----X-----X----------------",
                "----X---------------------X---------------X------X------------------------------------------X----X--",
                "-------X--X-------X-----------------X-----------XX---X-----------XX------X--------------------XX----",
                "-----X------------------X--------X----X----X-------------------XX-------------------------X-------X-",
                "-----XX---------------------------------------X------------X------X------XXX------X---------X------X",
                "X-------X------X----------X--X------X-X----------XX-----X------XX-------------------X-----X---------",
                "--X---X----------X-X---X------XX---------------X-----X--X--------X---------------------X----X-------",
                "-X-X----------XX---X-X------------------------------XXX---X--X---X---X--X---X-----X-----X------X----",
                "-------X---------------X--X-------------------X-----------X--------X----------------------X--X------",
                "-------------------X-------------------------X-------X-X-----------------X------------X-X-----------",
                "-----X-X------X----------------------------X-------------X-----------XX-----------------------------",
                "----X----X-------------------------X----XX---------------X--X--X-----X-----X----------------------X-",
                "-------------------X--------X-----------X---------X------X-----X-X----------------------------------",
                "--X------------X-----------XXX-------X--------X-------------X------------X----X---------------------",
                "-----------X--------X---------------------------------------------------X-------------X-------------",
                "-X----XX--------------------------X--X--------X----X-------X-------X----X-------XX---X------------X-",
                "-------X------------------------------X--X------X--X-------X--X------------X---------X--------------",
                "-XX--------X----X-X---X--------------------------X---X-X------------------------------XX------------",
                "----------X-----XX------------------X-X--------X-X-X---X--XX------------X-X-X--X--------------------",
                "X-------X-------XX---X-X--XX--------X---X-------------------------------X--------------------X------",
                "-X-----------------------------------X-----X--------------------------------X-------XX--------------",
                "--X------------------------X-XX----------------X-------X-------X--------------X-----X-X------X---X--"
            };

            int expected = 81;
            int actual = challenge.GetResult(lines);
            Assert.AreEqual(expected, actual);
        }


    }
}
