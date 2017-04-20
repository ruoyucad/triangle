using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Triangle.Tests
{
   
    public class TriangleTesterTests
    {
        [Test]
        public void AnalyzeTest_IsScalene()
        {
            NUnit.Framework.Assert.IsTrue(TriangleTester.GetTriangleType(1, 2, 3));
            // check triangle with three different dimensions 
        }
        [Test]
        public void AnalyzeTest2_IsScalene()
        {
            // check triangle with three different dimensions 
            NUnit.Framework.Assert.IsTrue(TriangleTester.GetTriangleType(78,89,100));
        }
        [Test]
        public void AnalyzeTest3_IsIsosceles()
        {
            NUnit.Framework.Assert.IsTrue(TriangleTester.GetTriangleType(10, 10, 5));
            // check triangle with two same dimensions 
        }
        [Test]
        public void AnalyzeTest4_IsIsosceles()
        {
            NUnit.Framework.Assert.IsTrue(TriangleTester.GetTriangleType(20, 10, 10));
            // check triangle with two same dimensions 
        }
        [Test]
        public void AnalyzeTest5_IsEquilateral()
        {
            NUnit.Framework.Assert.IsTrue(TriangleTester.GetTriangleType(3, 3, 3));
            // check triangle with three same dimensions 
        }
        [Test]
        public void AnalyzeTest6_IsEquilateral()
        {
            NUnit.Framework.Assert.IsTrue(TriangleTester.GetTriangleType(88, 88, 88));
            // check triangle with three same dimensions 
        }
        [Test]
        public void AnalyzeTest7_NotForm()
        {
            NUnit.Framework.Assert.IsFalse(TriangleTester.GetTriangleType(-10, -10, 9));
            // check wherther negative value will pass the test
        }
        [Test]
        public void AnalyzeTest8_NotForm()
        {
            // check with 0 as dimensions
            NUnit.Framework.Assert.IsFalse(TriangleTester.GetTriangleType(0,0,0));
        }

    }
}