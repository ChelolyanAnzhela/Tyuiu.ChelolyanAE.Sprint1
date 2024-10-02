using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ChelolyanAE.Sprint1.Task3.V9.Lib
{
    public class DataService : ISprint1Task3V9
    {
        public double ConvertMinutesToHours(int minutes)
        {
           double x = minutes;
           return Math.Round (x / 60, 3);
        }
    }
}
