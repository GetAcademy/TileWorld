using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TileWorld;

namespace TileWorldTest
{
    [TestClass]
    public class TileBoardTest
    {
        [TestMethod]
        public void TestGetBoard()
        {
            var tileBoard = new TileBoard(2, 2);
            var board = tileBoard.GetBoard();

            Assert.AreEqual("█░\n░█\n", board);
        }

        [TestMethod]
        public void TestGetBoard2()
        {
            var tileBoard = new TileBoard(3, 3);
            var board = tileBoard.GetBoard();

            Assert.AreEqual("█░█\n░█░\n█░█\n", board);
        }

        [TestMethod]
        public void TestGetBoard3()
        {
            var tileBoard = new TileBoard(5, 5);
            var board = tileBoard.GetBoard();

            Assert.AreEqual("█░█░█\n░█░█░\n█░█░█\n░█░█░\n█░█░█\n", board);
        }

        [TestMethod]
        public void TestGetRow()
        {
            var tileBoard = new TileBoard(30, 3);
            var board = tileBoard.GetRow();
            Assert.AreEqual("█░█", board);
        }

        [TestMethod]
        public void TestGetRow2()
        {
            var tileBoard = new TileBoard(30, 4);
            var board = tileBoard.GetRow();
            Assert.AreEqual("█░█░", board);
        }

        [TestMethod]
        public void TestGetRow3()
        {
            var tileBoard = new TileBoard(30, 4);
            var board = tileBoard.GetRow(false);
            Assert.AreEqual("░█░█", board);
        }
    }
}
