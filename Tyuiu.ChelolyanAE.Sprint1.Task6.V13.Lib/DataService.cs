using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.ChelolyanAE.Sprint1.Task6.V13.Lib
{
    public class DataService : ISprint1Task6V13
    {
        public bool CheckWordsAlphabet(string value)
        {
            value = value.Trim(new char[] { ' ', '.', ',' });
            for (int i = 1; i < value.Length; i++)
            {
                if (value[i - 1] != value[i] - 1)
                {
                    return false;
                }
            }
            return true;

        }
    }
}
