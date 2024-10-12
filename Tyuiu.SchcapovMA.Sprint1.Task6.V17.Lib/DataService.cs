using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SchcapovMA.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {

            string result = "";
            for (int k = value.Length-1; k >= 0; k--)
            {
               result += value[k];

            }
            return result==value;
        }
        
    }
}
