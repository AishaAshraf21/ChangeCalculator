using System;
using NUnit.Framework;
using BusinessLogic;

namespace BusinessLogicUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateGreaterThan100()
        {
            double money, amtValue;
            amtValue = 113;
            money = amtValue;
            int noteCount = 1;
            NumberOfCurrencyValues test = new NumberOfCurrencyValues();
            //Math.Floor(noteCount = businessLogic.ComputeNotes(ref money, amtValue));
            Assert.GreaterOrEqual(noteCount, Math.Floor(test.ComputeNotes(ref money, amtValue)));
        }

        [Test]
        public void CalculateGreaterThan50()
        {
            double money, amtValue;
            amtValue = 49;
            money = amtValue;
            int noteCount = 1;
            NumberOfCurrencyValues test = new NumberOfCurrencyValues();
            //Math.Floor(noteCount = businessLogic.ComputeNotes(ref money, amtValue));
            Assert.GreaterOrEqual(noteCount, Math.Floor(test.ComputeNotes(ref money, amtValue)));
        }
    }
}