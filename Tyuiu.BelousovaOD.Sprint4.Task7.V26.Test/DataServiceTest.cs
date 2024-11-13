using Newtonsoft.Json.Linq;
using Tyuiu.BelousovaOD.Sprint4.Task7.V26.Lib;
namespace Tyuiu.BelousovaOD.Sprint4.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string array = "351268459614723";
            var res = ds.Calculate(5, 3, array);
            Assert.AreEqual(res, 18432);
        }
    }
}