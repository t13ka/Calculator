﻿namespace Globogames.Calculator.Implementations.RegexCalculator.Operations
{
    using System.Collections;
    using System.Collections.Generic;

    using Globogames.Abstractions;

    public class MathOperationsCollection : IMathOperationCollection
    {
        public MathOperationsCollection()
        {
            MathOperations =
                new List<IMathOperation>
                    {
                        new SumMathOperation('+', 0),
                        new SubtractionMathOperation('-', 0),
                        new MultiplicationMathOperation('*', 1),
                        new DivisionMathOperation('/', 1),
                        new ExponentiationMathOperation('^', 1)
                    };
        }

        private IEnumerable<IMathOperation> MathOperations { get; }

        public IEnumerator<IMathOperation> GetEnumerator()
        {
            return MathOperations.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return MathOperations.GetEnumerator();
        }
    }
}