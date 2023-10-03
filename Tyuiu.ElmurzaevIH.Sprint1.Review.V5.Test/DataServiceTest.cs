using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElmurzaevIH.Sprint1.Review.V5.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint1.Review.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.6;
            var res = ds.Calculate(x);

            var wait = -0.624;
            Assert.AreEqual(wait, res);
        }
    }
}
