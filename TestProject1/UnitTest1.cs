using MS_Test_Practice;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = { 5, 5, 4, 7, 4, 1, 1, 1 };
           
            PurchaseList purchaseList = new PurchaseList();
            int result1= purchaseList.SoldOnce(arr);
            Assert.AreEqual(7, result1);
            int result2= purchaseList.SoldMore(arr);
            Assert.AreEqual(5,result2 );
        }
        [TestMethod]
        public void TestMethod2()
        {
            SwapCondition swap = new SwapCondition();
            string result = swap.CheckRearrangement("noon", "moon");
            Assert.AreEqual("No", result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            SwapCondition swap = new SwapCondition();
            string result = swap.CheckRearrangement("part", "trap");
            Assert.AreEqual("Yes", result);
        }
    }
}