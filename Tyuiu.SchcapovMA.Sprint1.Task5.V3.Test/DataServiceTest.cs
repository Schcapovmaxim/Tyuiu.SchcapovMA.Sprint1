using Tyuiu.SchcapovMA.Sprint1.Task5.V3.Lib;
namespace Tyuiu.SchcapovMA.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 130985;
            
            int res = ds.Calculate(k);
            
            double result = Convert.ToDouble(res);
            double wait = 9;
            Assert.AreEqual(wait, result);
        }
    }
}