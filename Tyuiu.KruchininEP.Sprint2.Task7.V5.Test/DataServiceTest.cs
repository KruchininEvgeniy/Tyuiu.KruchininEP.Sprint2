
using Tyuiu.KruchininEP.Sprint2.Task7.V5.Lib;

namespace Tyuiu.KruchininEP.Sprint2.Task7.V5.Test
{

    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0;
            double y = 0.5;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;

            Assert.AreEqual(wait, res);


        }
    }
}