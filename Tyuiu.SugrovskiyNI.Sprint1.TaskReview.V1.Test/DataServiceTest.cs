using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint1.TaskReview.V1.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint1.TaskReview.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 2; 
            double b = 3; 
            double c = 1;
            double wait = -6.108;
            double res = ds.Calculate(a, b, c);
            Assert.AreEqual(wait, res);


        }
    }
}
