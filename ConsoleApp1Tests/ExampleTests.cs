
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleApp1.Tests
{
    [TestFixture()]
    public class ExampleTests
    {
    
        [Test()]
        [TestCase("abc", "cba")]
        [TestCase("marcus", "sucram")]
        [TestCase("apple", "elppa")]
        public void ReverseTest(string input , string expect)
        {
            var ex = new Example();
            var result = ex.Reverse(input);

            Assert.AreEqual(expect, result);
        }
    }
}