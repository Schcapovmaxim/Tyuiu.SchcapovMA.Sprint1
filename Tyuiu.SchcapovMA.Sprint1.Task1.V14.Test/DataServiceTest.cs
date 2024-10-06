using Tyuiu.SchcapovMA.Sprint1.Task1.V14.Lib;
namespace Tyuiu.SchcapovMA.Sprint1.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 9.0;
            double b = 6.0;
            double c = 3.0;
            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(19, res);
        }
    }
}