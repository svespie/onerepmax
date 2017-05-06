﻿namespace OneRepMax.Calculator
{
    public interface IOneRepMaxCalculator
    {
        /// <summary>
        /// Calculates an estimated 1RM based on weight and repetitions.
        /// </summary>
        /// <param name="weight">Double value representing the weight used for testing. The weight must be greater than 0. There is no defined limit at this time.</param>
        /// <param name="reps">Integer value representing the number of reps obtained in testing. Allowable range is from 1 to 10 reps.</param>
        /// <returns>
        /// Double representing an estimated 1RM based on the input parameters. An argument out of range exception will be thrown when invalid weight and rep values are passed in.
        /// It is recommended that input be checked for validity prior to calling this method.
        /// </returns>
        double Calculate(double weight, int reps);
    }
}