using System;
using Xunit;
using MathOperation;

namespace MathOperationTests {
    public class OperationTests {
        [Fact]
        public void AddTwoNumbers_ReturnsSum () 
        {
            int num1 = 10;
            int num2 = 20;
            int result = MathOperation.MathOperations.Add(num1,num2);// Method from class library 
            Assert.Equal (30, result);
        }
    }
}