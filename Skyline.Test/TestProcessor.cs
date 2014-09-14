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
            buildings.Add(new Building(3, 13, 9));
            buildings.Add(new Building(12, 7, 16));
            buildings.Add(new Building(14, 3, 25));
            buildings.Add(new Building(19, 18, 22));
            buildings.Add(new Building(23, 13, 29));
            buildings.Add(new Building(24, 4, 28));

            Processor p = new Processor();
            List<int> result = p.GetSkyline(buildings);

            Assert.AreEqual(18, result.Count);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(11, result[1]);
            Assert.AreEqual(3, result[2]);
            Assert.AreEqual(13, result[3]);
            Assert.AreEqual(9, result[4]);
            Assert.AreEqual(0, result[5]);
            Assert.AreEqual(12, result[6]);
            Assert.AreEqual(7, result[7]);
            Assert.AreEqual(16, result[8]);
            Assert.AreEqual(3, result[9]);
            Assert.AreEqual(19, result[10]);
            Assert.AreEqual(18, result[11]);
            Assert.AreEqual(22, result[12]);
            Assert.AreEqual(3, result[13]);
            Assert.AreEqual(23, result[14]);
            Assert.AreEqual(13, result[15]);
            Assert.AreEqual(29, result[16]);
            Assert.AreEqual(0, result[17]);
        }
    }
}
