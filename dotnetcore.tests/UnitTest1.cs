using Xunit;
using dotnetcore;
using System;

namespace dotnetcore.tests
{
   
    public class UnitTest1
    {

        private Operators _operator;

        public UnitTest1()
        {
            _operator = new Operators();
        }

        [Theory]
        [InlineData(1,2)]
        //[InlineData(1,-7)]
        //[InlineData(1,1)]
        public void Divide(double a, double b)
        {
            var result = _operator.Divide(a,b);
            Assert.Equal(0.5,result,1);
        }

        [Theory]
        //[InlineData(1,2)]
        [InlineData(1,-7)]
        //[InlineData(1,1)]
        public void Add(double a, double b)
        {
            var result = _operator.Add(a,b);
            Assert.Equal(-6.0,result,0);
        }
    }
}
