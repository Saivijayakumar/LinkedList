using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LinkedList;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        LinkedListMethods linkedList;
        [TestInitialize]
        public void setup()
        {
            linkedList = new LinkedListMethods();
        }
        [TestMethod]
        public void TestMethod1()
        {
            //Arange
            linkedList.InsertAtLast(56);
            linkedList.InsertAtLast(30);
            linkedList.InsertAtLast(70);
            int actual = 30;
            //Act
            linkedList.InsertAtSpecifiedposition(30, 40);
            int expected = linkedList.search(30);//return 30
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arange
            linkedList.InsertAtLast(56);
            linkedList.InsertAtLast(30);
            linkedList.InsertAtLast(70);
            int actual = 40;
            //Act
            linkedList.InsertAtSpecifiedposition(30, 40);
            int expected = linkedList.search(40);//return 40
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
