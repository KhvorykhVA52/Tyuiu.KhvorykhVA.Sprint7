using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.KhvorykhVA.Project.V12;
using Tyuiu.KhvorykhVA.Project.V12.Lib;

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
            // Метод загрузки формы
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Обработка изменения состояния радиокнопки
        }

        private void buttonShowShopInfo_KVA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\User\source\repos\Tyuiu.KhvorykhVA.Sprint7\Tyuiu.KhvorykhVA.Project.V12\bin\Debug\net8.0-windows\ShopsInPutFile.csv";
                if (File.Exists(path))
                {
                    using (StreamReader sr = new StreamReader(path, System.Text.Encoding.UTF8))
                    {
                        sr.ReadLine();

                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            textBoxShopInfo_KVA.Text += line + Environment.NewLine;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Файл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxShopInfo_KVA_TextChanged(object sender, EventArgs e)
        {
            // Обработка изменения текста в текстовом поле
        }

        private void buttonShowModels_KVA_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(textBoxName_KVA.Text);
            try
            {
                string path = @"C:\Users\User\source\repos\Tyuiu.KhvorykhVA.Sprint7\Tyuiu.KhvorykhVA.Project.V12\bin\Debug\net8.0-windows\LaptopsInPutFile.csv";
                if (File.Exists(path))
                {
                    string fileData = File.ReadAllText(path);
                    fileData = fileData.Replace('\n', '\r');
                    string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

                    int rows = lines.Length;
                    int columns = lines[0].Split(';').Length;

                    for (int i = 1; i < rows; i++)
                    {
                        string[] values = lines[i].Split(';');
                        if (values[0].Contains(name))
                        {
                            textBoxShowModels_KVA.Text += values[0] + Environment.NewLine;
                        }
                    }
                    textBoxShowModels_KVA.Text += "--------------------" + Environment.NewLine;
                    buttonDone_KVA.Enabled = true;
                    textBoxModel_KVA.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Файл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_KVA_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(textBoxName_KVA.Text);
            try
            {
                string path = @"C:\Users\User\source\repos\Tyuiu.KhvorykhVA.Sprint7\Tyuiu.KhvorykhVA.Project.V12\bin\Debug\net8.0-windows\LaptopsInPutFile.csv";
                if (File.Exists(path))
                {
                    string fileData = File.ReadAllText(path);
                    fileData = fileData.Replace('\n', '\r');
                    string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

                    int rows = lines.Length;
                    int columns = lines[0].Split(';').Length;

                    for (int i = 1; i < rows; i++)
                    {
                        string[] values = lines[i].Split(';');
                        if (values[0].Contains(textBoxModel_KVA.Text))
                        {
                            if (radioButtonDiagonal_KVA.Checked)
                            {
                                textBoxRes_KVA.Text = values[1];
                            }
                            else if (radioButtonScreenSize_KVA.Checked)
                            {
                                textBoxRes_KVA.Text = values[2];
                            }
                            else if (radioButtonRAM_KVA.Checked)
                            {
                                textBoxRes_KVA.Text = values[3];
                            }
                            else if (radioButtonSSD_KVA.Checked)
                            {
                                textBoxRes_KVA.Text = values[4];
                            }
                            else if (radioButtonProcessor_KVA.Checked)
                            {
                                textBoxRes_KVA.Text = values[5];
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Файл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAboutProgram_KVA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonAboutDeveloper_KVA_Click(object sender, EventArgs e)
        {
            FormAboutMe formAboutMe = new FormAboutMe();
            formAboutMe.ShowDialog();
        }

        private void buttonInfo_KVA_Click(object sender, EventArgs e)
        {
            FormAboutMe formAboutMe = new FormAboutMe();
            formAboutMe.ShowDialog();
        }
    }
}
