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
            linkedList.InsertAtLast(40);
            linkedList.InsertAtLast(70);
            int actual = 3;
            //Act
            linkedList.DeleteAtSpecifiedPosition(40);
            int expected = linkedList.LinkedlistCount() ;//return 3
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        //checking delete is working or not
        public void TestMethod2()
        {
            //Arange
            linkedList.InsertAtLast(56);
            linkedList.InsertAtLast(30);
            linkedList.InsertAtLast(40);
            linkedList.InsertAtLast(70);
            Assert.IsTrue(linkedList.DeleteAtSpecifiedPosition(40));
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arange
            linkedList.InsertAtLast(56);
            linkedList.InsertAtLast(30);
            linkedList.InsertAtLast(70);
            Assert.IsFalse(linkedList.DeleteAtSpecifiedPosition(40));
        }
    }
}
