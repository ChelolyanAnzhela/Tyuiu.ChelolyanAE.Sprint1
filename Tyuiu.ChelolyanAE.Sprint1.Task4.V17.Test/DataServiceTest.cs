using Tyuiu.ChelolyanAE.Sprint1.Task4.V17.Lib;

namespace Tyuiu.ChelolyanAE.Sprint1.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 35;
            double y = 2;
            double wait = 0.200;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}