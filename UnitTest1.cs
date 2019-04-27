using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using two_way_list;
namespace ListTest
{
    [TestClass]
    public class UnitTest1
    {
        public List<int> lista = new two_way_list.List<int>();

    [TestMethod]

        public void TestMethod1()
        {
            lista.InsertLast(5);
            lista.InsertLast(6);
            lista.InsertLast(7);
            Assert.AreEqual(7, lista.Last.data);
        }
        [TestMethod]
        public void TestMethod2()
        {
            lista.InsertFront(5);
            lista.InsertFront(6);
            lista.InsertFront(7);
            Assert.AreEqual(5, lista.Last.data);
        }
        [TestMethod]
        public void TestMethod3()
        {
            lista.InsertFront(5);
            lista.InsertFront(6);
            lista.InsertFront(7);
            lista.Iteratorforward = lista.Head;
            lista.Iteratorforward++;
            Assert.AreEqual(6, lista.Iteratorforward.data);
            Assert.AreEqual(7, lista.Head.data);


        }
        [TestMethod] 
        public void TestMethod4()
        {
            lista.InsertFront(5);
            lista.InsertFront(6);
            lista.InsertFront(7);
            lista.DeleteThisNode(lista.Last);
            Assert.AreEqual(7, lista.Head.data);
            Assert.AreEqual(6, lista.Last.data);
        }
        [TestMethod]

        public void TestMethod5()
        {
            lista.InsertFront(5);
            lista.InsertFront(6);
            lista.InsertFront(7);
            lista.DeleteThisNode(lista.Last);
            Assert.AreEqual(2, lista.ItemCounter);
        }


        [TestMethod]

        public void TestMethod6()
        {
            lista.InsertFront(5);
            lista.InsertFront(6);
            lista.InsertFront(7);
            lista.DeleteNodebyKey(5);
            Assert.AreEqual(6, lista.Last.data);
        }

        [TestMethod]

        public void TestMethod7()
        {
            lista.InsertFront(5);
            lista.InsertFront(6);
            lista.InsertFront(7);
            lista.DeleteNodebyKey(5);
            Assert.AreEqual(2, lista.ItemCounter);
        }
        [TestMethod]
        public void TestMethod8()
        {
            lista.InsertLast(5);
            lista.InsertLast(6);
            lista.InsertLast(7);
            lista.DeleteNodebyKey(5);
            Assert.AreEqual(2, lista.ItemCounter);
        }
        [TestMethod]

        public void TestMethod9()
        {
            lista.InsertLast(5);
            lista.InsertLast(6);
            lista.InsertLast(7);
            lista.DeleteNodebyKey(5);
            Assert.AreEqual(7, lista.Last.data);
            Assert.AreEqual(6, lista.Head.data);

        }
        [TestMethod]

        public void TestMethod10()
        {
            lista.InsertLast(5);
            lista.InsertAfter(lista.Head,6);
            lista.InsertAfter(lista.Head,7);
            lista.DeleteNodebyKey(5);
            Assert.AreEqual(7, lista.Head.data);
            Assert.AreEqual(6, lista.Last.data);

        }
    }

}
