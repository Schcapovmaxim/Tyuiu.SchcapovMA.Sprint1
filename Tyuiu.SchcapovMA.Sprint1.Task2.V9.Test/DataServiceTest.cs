using Tyuiu.SchcapovMA.Sprint1.Task2.V9.Lib;
namespace Tyuiu.SchcapovMA.Sprint1.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValiidExpression()
        {
            DataService ds = new DataService();
            int r = 2;
            var res = ds.CalculateVolumeCircle(r);
            Assert.AreEqual(33.51, res);
        }
    }
}