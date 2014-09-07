using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Skyline.Domain;

namespace Skyline.Test {
    [TestClass]
    public class TestProcessor {
        [TestMethod]
        public void Test_Empty() {
            List<Building> buildings = new List<Building>();

            Processor p = new Processor();
            List<Coordinate> result = p.GetSkyline(buildings);

            Assert.AreEqual(0, result.Count);
        }
    }
}
