using Tyuiu.BelousovaOD.Sprint4.Task6.V14.Lib;
namespace Tyuiu.BelousovaOD.Sprint4.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль" };
            string[] res = ds.Calculate(months);
            string[] wait = { "Январь", "Февраль", "Март", "Апрель", "Июнь", "Июль" };

            CollectionAssert.AreEqual(wait, res);

        }
    }
}




