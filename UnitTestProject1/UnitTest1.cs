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
            linkedList.InsertAtLast(22);
            linkedList.InsertAtLast(59);
            linkedList.InsertAtLast(30);
            int actual = 30;
            //Act
            int expected = linkedList.search(30);//return 30
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arange
            linkedList.InsertAtLast(3);
            linkedList.InsertAtLast(9);
            linkedList.InsertAtLast(2);
            int actual = 0;
            //Act
            int expected = linkedList.search(50);//return 0 
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arange
            int actual = 0;
            //Act
            int expected = linkedList.search(22);//return 0 
            //Assert
            Assert.AreEqual(actual, expected);
        }

    }
}
