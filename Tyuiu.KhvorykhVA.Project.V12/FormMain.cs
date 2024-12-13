using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.KhvorykhVA.Project.V12.Lib;
using Tyuiu.KhvorykhVA.Project.V12;

namespace Tyuiu.KhvorykhVA.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //
        }

        private void buttonShowShopInfo_KVA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\User\source\repos\Tyuiu.KhvorykhVA.Sprint7.Project.V12\Tyuiu.KhvorykhVA.Sprint7.Project.V12\bin\Release\ShopsInPutFile.csv";
                textBoxShopInfo_KVA.Text = ds.CollectTextFromFile(path, Convert.ToString(textBoxName_KVA.Text), 1) + Environment.NewLine +
                                           ds.CollectTextFromFile(path, Convert.ToString(textBoxName_KVA.Text), 2) + Environment.NewLine +
                                           ds.CollectTextFromFile(path, Convert.ToString(textBoxName_KVA.Text), 3) + Environment.NewLine +
                                           ds.CollectTextFromFile(path, Convert.ToString(textBoxName_KVA.Text), 4);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxShopInfo_KVA_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void buttonShowModels_KVA_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(textBoxName_KVA.Text);
            try
            {
                string path = $@"C:\Users\User\source\repos\Tyuiu.KhvorykhVA.Sprint7.Project.V12\Tyuiu.KhvorykhVA.Sprint7.Project.V12\bin\Release\ShopsInPutFile.csv";
                string fileData = File.ReadAllText(path);
                fileData = fileData.Replace('\n', '\r');
                string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

                int rows = lines.Length;
                int columns = lines[0].Split(';').Length;

                for (int i = 1; i < rows; i++)
                {
                    textBoxShowModels_KVA.Text += ds.CollectTextFromFileInt(path, i, 0) + Environment.NewLine;
                }
                textBoxShowModels_KVA.Text += "--------------------" + Environment.NewLine;
                buttonDone_KVA.Enabled = true;
                textBoxModel_KVA.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_KVA_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(textBoxName_KVA.Text);
            try
            {
                string path = $@"C:\Users\User\source\repos\Tyuiu.KhvorykhVA.Sprint7.Project.V12\Tyuiu.KhvorykhVA.Sprint7.Project.V12\bin\Release\ShopsInPutFile.csv";
                if (radioButtonDiagonal_KVA.Checked)
                {
                    textBoxRes_KVA.Text = ds.CollectTextFromFile(path, Convert.ToString(textBoxModel_KVA.Text), 1);
                }
                if (radioButtonScreenSize_KVA.Checked)
                {
                    textBoxRes_KVA.Text = ds.CollectTextFromFile(path, Convert.ToString(textBoxModel_KVA.Text), 2);
                }
                if (radioButtonRAM_KVA.Checked)
                {
                    textBoxRes_KVA.Text = ds.CollectTextFromFile(path, Convert.ToString(textBoxModel_KVA.Text), 3);
                }
                if (radioButtonSSD_KVA.Checked)
                {
                    textBoxRes_KVA.Text = ds.CollectTextFromFile(path, Convert.ToString(textBoxModel_KVA.Text), 4);
                }
                if (radioButtonProcessor_KVA.Checked)
                {
                    textBoxRes_KVA.Text = ds.CollectTextFromFile(path, Convert.ToString(textBoxModel_KVA.Text), 5);
                }
                if (radioButtonProcessorFrequency_KVA.Checked)
                {
                    textBoxRes_KVA.Text = ds.CollectTextFromFile(path, Convert.ToString(textBoxModel_KVA.Text), 6);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_KVA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
