using Tyuiu.ChelolyanAE.Sprint1.Task5.V3.Lib;

namespace Tyuiu.ChelolyanAE.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 139573;
            int h = ds.Calculate(k);
            int result = h;
            int wait = 5;
            Assert.AreEqual(wait, result);
        }
    }
}