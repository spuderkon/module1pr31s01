using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using exx1;

namespace UnitTestProject1
{
    
    [TestClass]
    public class UnitTest1
    {
        tyly cc = new tyly();
        [TestMethod]
        public void checkquanprog()
        {
           
            const int check = 42;
            int test = cc.quanprog(45,14,15); 
            Assert.AreEqual(check, test);

        }
        [TestMethod]
        public void qualityprog()
        {
            const int check = 45;
            int test = cc.quality(15,3);
            Assert.AreEqual(check,test);
        }
    }
}
