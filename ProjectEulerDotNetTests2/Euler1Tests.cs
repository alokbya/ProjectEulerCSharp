using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerDotNet.Tests
{
    [TestClass()]
    public class Euler1Tests
    {
        [TestMethod()]
        public void SumOfMultiplesOf_3and5Test()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0 && 
                    !Euler1.IsMultipleOf_3and5(i))
                {
                    Assert.IsFalse(Euler1.IsMultipleOf_3and5(i));
                }
            }
        }

        [TestMethod]
        public void IsMultipleOf_5Test()
        {
            
            for (int i = 0; i < 100; i++)
            {
                if (i % 5 == 0 && !Euler1.IsMultipleOf_5(i))
                {
                    Assert.IsFalse(Euler1.IsMultipleOf_5(i));
                }
            }
        }

        [TestMethod]
        public void IsMultipleOf_3Test()
        {
            for (int i = 0; i < 100; i++)
            {
                if(i % 3 == 0 && !Euler1.IsMultipleOf_3(i))
                {
                    Assert.IsFalse(Euler1.IsMultipleOf_3(i));
                }
            }
        }
    }
}