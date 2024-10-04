using Tyuiu.ChelolyanAE.Sprint1.Task6.V13.Lib;

namespace Tyuiu.ChelolyanAE.Sprint1.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds= new DataService();
            bool strcheck = false;
            string text = "¿·¬„ƒ≈∏";
            bool res = ds.CheckWordsAlphabet(text);

            Assert.AreEqual(strcheck, res);
        }
    }
}