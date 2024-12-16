using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhvorykhVA.Project.V12.Lib;

namespace Tyuiu.KhvorykhVA.Project.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalcHonor()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\User\source\repos\Tyuiu.KhvorykhVA.Sprint7\Tyuiu.KhvorykhVA.Project.V12\bin\Debug\net8.0-windows\LaptopsInPutFile.csv";

            string row = "Honor MagicBook 14 NMH-WFP9HN 14";

            int column = 1;
            string res = ds.CollectTextFromFile(path, row, column);

            string wait = "14";
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalcAcer()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\User\source\repos\Tyuiu.KhvorykhVA.Sprint7\Tyuiu.KhvorykhVA.Project.V12\bin\Debug\net8.0-windows\LaptopsInPutFile.csv";

            string row = "Acer Extensa 15 EX215-23";

            int column = 1;
            string res = ds.CollectTextFromFile(path, row, column);

            string wait = "15.6";
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalcAsus()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\User\source\repos\Tyuiu.KhvorykhVA.Sprint7\Tyuiu.KhvorykhVA.Project.V12\bin\Debug\net8.0-windows\LaptopsInPutFile.csv";

            string row = "Asus VivoBook X1502ZA-BQ2345";

            int column = 1;
            string res = ds.CollectTextFromFile(path, row, column);

            string wait = "15.6";
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalcIntHonor()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\User\source\repos\Tyuiu.KhvorykhVA.Sprint7\Tyuiu.KhvorykhVA.Project.V12\bin\Debug\net8.0-windows\LaptopsInPutFile.csv";

            int row = 1;
            int column = 1;
            string res = ds.CollectTextFromFileInt(path, row, column);

            string wait = "14";
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalcIntAcer()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\User\source\repos\Tyuiu.KhvorykhVA.Sprint7\Tyuiu.KhvorykhVA.Project.V12\bin\Debug\net8.0-windows\LaptopsInPutFile.csv";

            int row = 2;
            int column = 1;
            string res = ds.CollectTextFromFileInt(path, row, column);

            string wait = "15.6";
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalcIntAsus()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\User\source\repos\Tyuiu.KhvorykhVA.Sprint7\Tyuiu.KhvorykhVA.Project.V12\bin\Debug\net8.0-windows\LaptopsInPutFile.csv";

            int row = 3;
            int column = 1;
            string res = ds.CollectTextFromFileInt(path, row, column);

            string wait = "15.6";
            Assert.AreEqual(wait, res);
        }
    }
}
