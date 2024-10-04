using Tyuiu.ChelolyanAE.Sprint1.Task3.V9.Lib;

namespace Tyuiu.ChelolyanAE.Sprint1.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int minutes = 325;
            double wait = 5;
            double hour = ds.ConvertMinutesToHours(minutes);
            Assert.AreEqual(wait, hour);
            


        }
    }
}