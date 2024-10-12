using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SchcapovMA.Sprint1.Task7.V26.Lib
{
    public class DataService : ISprint1Task7V26
    {
        public double Calculate(double x, double y)
        {
            double res = ((Math.Sin(Math.Pow(x,2)) + y)/(y+1))-((x*y-12)/(34+Math.Pow(x,2)));
            return Math.Round(res,3);
        }
    }
}
