using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhvorykhVA.Project.V12.Lib;

namespace Tyuiu.KhvorykhVA.Project.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\User\source\repos\Tyuiu.KhvorykhVA.Sprint7\Tyuiu.KhvorykhVA.Project.V12\bin\Debug\net8.0-windows\HonorInPutFile.csv";

            string row = "Honor MagicBook 14 NMH-WFP9HN 14";
            int column = 1;
            string res = ds.CollectTextFromFile(path, row, column);

            string wait = "15,6";
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalcInt()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\User\source\repos\Tyuiu.KhvorykhVA.Sprint7\Tyuiu.KhvorykhVA.Project.V12\bin\Debug\net8.0-windows\HonorInPutFile.csv";

            int row = 1;
            int column = 1;
            string res = ds.CollectTextFromFileInt(path, row, column);

            string wait = "15,6";
            Assert.AreEqual(wait, res);
        }
    }
}
