using Tyuiu.SchcapovMA.Sprint1.Task6.V17.Lib;
namespace Tyuiu.SchcapovMA.Sprint1.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "321";
            DataService ds = new DataService();
            bool res = ds.CheckPalindrome(strTest);
            bool wait = false;
            Assert.AreEqual(res, wait);
        }
    }
}