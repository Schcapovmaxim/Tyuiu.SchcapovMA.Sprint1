using Tyuiu.SchcapovMA.Sprint1.Task7.V26.Lib;
namespace Tyuiu.SchcapovMA.Sprint1.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 4;
            double wait = 1.153;
            double res = ds.Calculate(x,y);
            Assert.AreEqual(res,wait);
        }
    }
}