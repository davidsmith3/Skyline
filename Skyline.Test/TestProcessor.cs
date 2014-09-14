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
            List<int> result = p.GetSkyline(buildings);

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void Test_OneBuilding() {
            List<Building> buildings = new List<Building>();
            buildings.Add(new Building(1, 11, 5));

            Processor p = new Processor();
            List<int> result = p.GetSkyline(buildings);

            Assert.AreEqual(4, result.Count);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(11, result[1]);
            Assert.AreEqual(5, result[2]);
            Assert.AreEqual(0, result[3]);
        }

        [TestMethod]
        public void Test_WebExample() {
            List<Building> buildings = new List<Building>();
            buildings.Add(new Building(1, 11, 5));
            buildings.Add(new Building(2, 6, 7));

            Processor p = new Processor();
            List<int> result = p.GetSkyline(buildings);

            Assert.AreEqual(4, result.Count);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(11, result[1]);
            Assert.AreEqual(5, result[2]);
            Assert.AreEqual(0, result[3]);
        }
    }
}
