using Tyuiu.ChelolyanAE.Sprint1.Task1.V26.Lib;

namespace Tyuiu.ChelolyanAE.Sprint1.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}