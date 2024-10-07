using Tyuiu.SchcapovMA.Sprint1.Task3.V4.Lib;
namespace Tyuiu.SchcapovMA.Sprint1.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 2.75;
            double b = 0.5;
            int c = 7;

            var res = ds.PurchaseAmount(a, b, c);
            Assert.AreEqual(22.75, res);
        }
    }
}