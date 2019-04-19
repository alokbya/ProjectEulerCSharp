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
    public class Euler2Tests
    {
        [TestMethod()]
        public void isEvenTest()
        {
            for(uint i = 0; i <= 100; i++)
            {
                if(i % 2 == 0 && !Euler2.IsEven(i))
                {
                    Assert.IsFalse(Euler2.IsEven(i));
                }
            }
        }
    }
}