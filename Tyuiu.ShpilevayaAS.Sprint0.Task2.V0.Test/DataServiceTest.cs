using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShpilevayaAS.Sprint0.Task2.V0.Lib;
namespace Tyuiu.ShpilevayaAS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Арина";
            var res = DataService.GetMassage(name);
            Assert.AreEqual("Привет..., Арина", res);
        }
    }
}
