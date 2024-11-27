using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BelousovaOD.Sprint4.Task6.V14.Lib
{
    public class DataService : ISprint4Task6V14
    {
        public string[] Calculate(string[] array)
        {
            string[] months = Array.FindAll(array, month => month.Length > 3);
            return months;

        }
    }
}

