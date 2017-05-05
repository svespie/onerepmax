﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OneRepMax.Tests
{
    [TestClass]
    public class InputValidationTests
    {
        private readonly OneRepMaxCalculator calc = new OneRepMaxCalculator(OneRepMaxFormula.Epley);

        [TestMethod]
        public void ShouldNotThrowAnExceptionWithWeightGreaterThan1()
        {
            try
            {
                calc.ValidateWeight(135);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void ShouldNotThrowAnExceptionWithRepsEqual1()
        {
            try
            {
                calc.ValidateReps(1);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void ShouldNotThrowAnExceptionWithRepsEqual10()
        {
            try
            {
                calc.ValidateReps(10);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldThrowAnExceptionWhenWeightIsLessThan1()
        {
            calc.ValidateWeight(0.999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldThrowAnExceptionWhenRepsIsLessThan1()
        {
            calc.ValidateReps(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldThrowAnExceptionWhenRepsIsGreaterThan10()
        {
            calc.ValidateReps(11);
        }
    }
}