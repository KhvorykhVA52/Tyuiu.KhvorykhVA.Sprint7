namespace Tyuiu.KhvorykhVA.Sprint7.Project.V12
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelButtonsInPut_KVA;
        private System.Windows.Forms.GroupBox groupBoxInfo_KVA;
        private System.Windows.Forms.RadioButton radioButtonDiagonal_KVA;
        private System.Windows.Forms.Label labelName_KVA;
        private System.Windows.Forms.TextBox textBoxName_KVA;
        private System.Windows.Forms.Button buttonDone_KVA;
        private System.Windows.Forms.Button buttonInfo_KVA;
        private System.Windows.Forms.Panel panelRes_KVA;
        private System.Windows.Forms.Label labelModel_KVA;
        private System.Windows.Forms.TextBox textBoxModel_KVA;
        private System.Windows.Forms.Button buttonShowModels_KVA;
        private System.Windows.Forms.RadioButton radioButtonProcessor_KVA;
        private System.Windows.Forms.RadioButton radioButtonScreenSize_KVA;
        private System.Windows.Forms.RadioButton radioButtonSSD_KVA;
        private System.Windows.Forms.RadioButton radioButtonRAM_KVA;
        private System.Windows.Forms.TextBox textBoxShowModels_KVA;
        private System.Windows.Forms.TextBox textBoxRes_KVA;
        private System.Windows.Forms.Label labelShowModels_KVA;
        private System.Windows.Forms.Label labelRes_KVA;
        private System.Windows.Forms.ToolTip toolTip_KVA;
        private System.Windows.Forms.Button buttonShowShopInfo_KVA;
        private System.Windows.Forms.Label labelShopInfo_KVA;
        private System.Windows.Forms.TextBox textBoxShopInfo_KVA;
        private System.Windows.Forms.Button buttonAboutProgram_KVA; // Переименованная кнопка

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtonsInPut_KVA = new Panel();
            buttonAboutProgram_KVA = new Button();
            buttonShowShopInfo_KVA = new Button();
            buttonShowModels_KVA = new Button();
            groupBoxInfo_KVA = new GroupBox();
            radioButtonProcessor_KVA = new RadioButton();
            radioButtonScreenSize_KVA = new RadioButton();
            radioButtonSSD_KVA = new RadioButton();
            radioButtonRAM_KVA = new RadioButton();
            radioButtonDiagonal_KVA = new RadioButton();
            labelModel_KVA = new Label();
            textBoxModel_KVA = new TextBox();
            labelName_KVA = new Label();
            textBoxName_KVA = new TextBox();
            buttonDone_KVA = new Button();
            buttonInfo_KVA = new Button();
            panelRes_KVA = new Panel();
            labelShopInfo_KVA = new Label();
            labelShowModels_KVA = new Label();
            labelRes_KVA = new Label();
            textBoxShowModels_KVA = new TextBox();
            textBoxRes_KVA = new TextBox();
            textBoxShopInfo_KVA = new TextBox();
            toolTip_KVA = new ToolTip(components);
            panelButtonsInPut_KVA.SuspendLayout();
            groupBoxInfo_KVA.SuspendLayout();
            panelRes_KVA.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtonsInPut_KVA
            // 
            panelButtonsInPut_KVA.BackColor = Color.SlateBlue;
            panelButtonsInPut_KVA.Controls.Add(buttonAboutProgram_KVA);
            panelButtonsInPut_KVA.Controls.Add(buttonShowShopInfo_KVA);
            panelButtonsInPut_KVA.Controls.Add(buttonShowModels_KVA);
            panelButtonsInPut_KVA.Controls.Add(groupBoxInfo_KVA);
            panelButtonsInPut_KVA.Controls.Add(buttonDone_KVA);
            panelButtonsInPut_KVA.Controls.Add(buttonInfo_KVA);
            panelButtonsInPut_KVA.Dock = DockStyle.Top;
            panelButtonsInPut_KVA.Location = new Point(0, 0);
            panelButtonsInPut_KVA.Name = "panelButtonsInPut_KVA";
            panelButtonsInPut_KVA.Size = new Size(854, 201);
            panelButtonsInPut_KVA.TabIndex = 0;
            // 
            // buttonAboutProgram_KVA
            // 
            buttonAboutProgram_KVA.Location = new Point(735, 51);
            buttonAboutProgram_KVA.Name = "buttonAboutProgram_KVA";
            buttonAboutProgram_KVA.Size = new Size(109, 23);
            buttonAboutProgram_KVA.TabIndex = 5;
            buttonAboutProgram_KVA.Text = "О программе";
            buttonAboutProgram_KVA.UseVisualStyleBackColor = true;
            buttonAboutProgram_KVA.Click += buttonAboutProgram_KVA_Click;
            // 
            // buttonShowShopInfo_KVA
            // 
            buttonShowShopInfo_KVA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonShowShopInfo_KVA.BackColor = Color.DarkSlateBlue;
            buttonShowShopInfo_KVA.ForeColor = SystemColors.ControlText;
            buttonShowShopInfo_KVA.Image = (Image)resources.GetObject("buttonShowShopInfo_KVA.Image");
            buttonShowShopInfo_KVA.Location = new Point(756, 96);
            buttonShowShopInfo_KVA.Name = "buttonShowShopInfo_KVA";
            buttonShowShopInfo_KVA.Size = new Size(88, 47);
            buttonShowShopInfo_KVA.TabIndex = 4;
            toolTip_KVA.SetToolTip(buttonShowShopInfo_KVA, "Выводит информацию о производителе.");
            buttonShowShopInfo_KVA.UseVisualStyleBackColor = false;
            buttonShowShopInfo_KVA.Click += buttonShowShopInfo_KVA_Click;
            // 
            // buttonShowModels_KVA
            // 
            buttonShowModels_KVA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonShowModels_KVA.BackColor = Color.DarkSlateBlue;
            buttonShowModels_KVA.ForeColor = SystemColors.ControlText;
            buttonShowModels_KVA.Image = (Image)resources.GetObject("buttonShowModels_KVA.Image");
            buttonShowModels_KVA.Location = new Point(663, 96);
            buttonShowModels_KVA.Name = "buttonShowModels_KVA";
            buttonShowModels_KVA.Size = new Size(88, 47);
            buttonShowModels_KVA.TabIndex = 3;
            toolTip_KVA.SetToolTip(buttonShowModels_KVA, "Выводит модели ноутбуков, которые есть в базе данных.");
            buttonShowModels_KVA.UseVisualStyleBackColor = false;
            buttonShowModels_KVA.Click += buttonShowModels_KVA_Click;
            // 
            // groupBoxInfo_KVA
            // 
            groupBoxInfo_KVA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxInfo_KVA.Controls.Add(radioButtonProcessor_KVA);
            groupBoxInfo_KVA.Controls.Add(radioButtonScreenSize_KVA);
            groupBoxInfo_KVA.Controls.Add(radioButtonSSD_KVA);
            groupBoxInfo_KVA.Controls.Add(radioButtonRAM_KVA);
            groupBoxInfo_KVA.Controls.Add(radioButtonDiagonal_KVA);
            groupBoxInfo_KVA.Controls.Add(labelModel_KVA);
            groupBoxInfo_KVA.Controls.Add(textBoxModel_KVA);
            groupBoxInfo_KVA.Controls.Add(labelName_KVA);
            groupBoxInfo_KVA.Controls.Add(textBoxName_KVA);
            groupBoxInfo_KVA.ForeColor = SystemColors.ControlText;
            groupBoxInfo_KVA.Location = new Point(11, 12);
            groupBoxInfo_KVA.Name = "groupBoxInfo_KVA";
            groupBoxInfo_KVA.Size = new Size(647, 183);
            groupBoxInfo_KVA.TabIndex = 2;
            groupBoxInfo_KVA.TabStop = false;
            groupBoxInfo_KVA.Text = "Ввод данных:";
            // 
            // radioButtonProcessor_KVA
            // 
            radioButtonProcessor_KVA.AutoSize = true;
            radioButtonProcessor_KVA.Location = new Point(347, 119);
            radioButtonProcessor_KVA.Name = "radioButtonProcessor_KVA";
            radioButtonProcessor_KVA.Size = new Size(87, 19);
            radioButtonProcessor_KVA.TabIndex = 7;
            radioButtonProcessor_KVA.TabStop = true;
            radioButtonProcessor_KVA.Text = "Процессор";
            radioButtonProcessor_KVA.UseVisualStyleBackColor = true;
            // 
            // radioButtonScreenSize_KVA
            // 
            radioButtonScreenSize_KVA.AutoSize = true;
            radioButtonScreenSize_KVA.Location = new Point(207, 119);
            radioButtonScreenSize_KVA.Name = "radioButtonScreenSize_KVA";
            radioButtonScreenSize_KVA.Size = new Size(134, 19);
            radioButtonScreenSize_KVA.TabIndex = 6;
            radioButtonScreenSize_KVA.TabStop = true;
            radioButtonScreenSize_KVA.Text = "Разрешение экрана";
            radioButtonScreenSize_KVA.UseVisualStyleBackColor = true;
            // 
            // radioButtonSSD_KVA
            // 
            radioButtonSSD_KVA.AutoSize = true;
            radioButtonSSD_KVA.Location = new Point(207, 144);
            radioButtonSSD_KVA.Name = "radioButtonSSD_KVA";
            radioButtonSSD_KVA.Size = new Size(86, 19);
            radioButtonSSD_KVA.TabIndex = 5;
            radioButtonSSD_KVA.TabStop = true;
            radioButtonSSD_KVA.Text = "Объем SSD";
            radioButtonSSD_KVA.UseVisualStyleBackColor = true;
            radioButtonSSD_KVA.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButtonRAM_KVA
            // 
            radioButtonRAM_KVA.AutoSize = true;
            radioButtonRAM_KVA.Location = new Point(6, 144);
            radioButtonRAM_KVA.Name = "radioButtonRAM_KVA";
            radioButtonRAM_KVA.Size = new Size(139, 19);
            radioButtonRAM_KVA.TabIndex = 8;
            radioButtonRAM_KVA.TabStop = true;
            radioButtonRAM_KVA.Text = "Оперативная память";
            radioButtonRAM_KVA.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiagonal_KVA
            // 
            radioButtonDiagonal_KVA.AutoSize = true;
            radioButtonDiagonal_KVA.Location = new Point(1, 119);
            radioButtonDiagonal_KVA.Name = "radioButtonDiagonal_KVA";
            radioButtonDiagonal_KVA.Size = new Size(181, 19);
            radioButtonDiagonal_KVA.TabIndex = 2;
            radioButtonDiagonal_KVA.TabStop = true;
            radioButtonDiagonal_KVA.Text = "Диагональ экрана в дюймах";
            radioButtonDiagonal_KVA.UseVisualStyleBackColor = true;
            // 
            // labelModel_KVA
            // 
            labelModel_KVA.AutoSize = true;
            labelModel_KVA.Location = new Point(6, 71);
            labelModel_KVA.Name = "labelModel_KVA";
            labelModel_KVA.Size = new Size(148, 15);
            labelModel_KVA.TabIndex = 4;
            labelModel_KVA.Text = "Введите название модели";
            // 
            // textBoxModel_KVA
            // 
            textBoxModel_KVA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxModel_KVA.Enabled = false;
            textBoxModel_KVA.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxModel_KVA.Location = new Point(5, 90);
            textBoxModel_KVA.Name = "textBoxModel_KVA";
            textBoxModel_KVA.Size = new Size(635, 23);
            textBoxModel_KVA.TabIndex = 3;
            // 
            // labelName_KVA
            // 
            labelName_KVA.AutoSize = true;
            labelName_KVA.Location = new Point(6, 18);
            labelName_KVA.Name = "labelName_KVA";
            labelName_KVA.Size = new Size(145, 15);
            labelName_KVA.TabIndex = 1;
            labelName_KVA.Text = "Введите название бренда";
            // 
            // textBoxName_KVA
            // 
            textBoxName_KVA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName_KVA.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxName_KVA.Location = new Point(5, 39);
            textBoxName_KVA.Name = "textBoxName_KVA";
            textBoxName_KVA.Size = new Size(636, 23);
            textBoxName_KVA.TabIndex = 0;
            // 
            // buttonDone_KVA
            // 
            buttonDone_KVA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDone_KVA.BackColor = Color.DarkSlateBlue;
            buttonDone_KVA.Enabled = false;
            buttonDone_KVA.Image = (Image)resources.GetObject("buttonDone_KVA.Image");
            buttonDone_KVA.Location = new Point(663, 148);
            buttonDone_KVA.Name = "buttonDone_KVA";
            buttonDone_KVA.Size = new Size(88, 47);
            buttonDone_KVA.TabIndex = 1;
            toolTip_KVA.SetToolTip(buttonDone_KVA, "Выполнить запрос.");
            buttonDone_KVA.UseVisualStyleBackColor = false;
            buttonDone_KVA.Click += buttonDone_KVA_Click;
            // 
            // buttonInfo_KVA
            // 
            buttonInfo_KVA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonInfo_KVA.BackColor = Color.DarkSlateBlue;
            buttonInfo_KVA.Image = (Image)resources.GetObject("buttonInfo_KVA.Image");
            buttonInfo_KVA.Location = new Point(756, 148);
            buttonInfo_KVA.Name = "buttonInfo_KVA";
            buttonInfo_KVA.Size = new Size(88, 47);
            buttonInfo_KVA.TabIndex = 0;
            toolTip_KVA.SetToolTip(buttonInfo_KVA, "Информация о разработчике.");
            buttonInfo_KVA.UseVisualStyleBackColor = false;
            buttonInfo_KVA.Click += buttonInfo_KVA_Click;
            // 
            // panelRes_KVA
            // 
            panelRes_KVA.BackColor = Color.SlateBlue;
            panelRes_KVA.Controls.Add(labelShopInfo_KVA);
            panelRes_KVA.Controls.Add(labelShowModels_KVA);
            panelRes_KVA.Controls.Add(labelRes_KVA);
            panelRes_KVA.Controls.Add(textBoxShowModels_KVA);
            panelRes_KVA.Controls.Add(textBoxRes_KVA);
            panelRes_KVA.Controls.Add(textBoxShopInfo_KVA);
            panelRes_KVA.Dock = DockStyle.Fill;
            panelRes_KVA.Location = new Point(0, 201);
            panelRes_KVA.Name = "panelRes_KVA";
            panelRes_KVA.Size = new Size(854, 288);
            panelRes_KVA.TabIndex = 2;
            // 
            // labelShopInfo_KVA
            // 
            labelShopInfo_KVA.AutoSize = true;
            labelShopInfo_KVA.Location = new Point(426, 53);
            labelShopInfo_KVA.Name = "labelShopInfo_KVA";
            labelShopInfo_KVA.Size = new Size(155, 15);
            labelShopInfo_KVA.TabIndex = 6;
            labelShopInfo_KVA.Text = "Сведения о производителе";
            // 
            // labelShowModels_KVA
            // 
            labelShowModels_KVA.AutoSize = true;
            labelShowModels_KVA.Location = new Point(11, 53);
            labelShowModels_KVA.Name = "labelShowModels_KVA";
            labelShowModels_KVA.Size = new Size(51, 15);
            labelShowModels_KVA.TabIndex = 5;
            labelShowModels_KVA.Text = "Модели";
            // 
            // labelRes_KVA
            // 
            labelRes_KVA.AutoSize = true;
            labelRes_KVA.Location = new Point(11, 7);
            labelRes_KVA.Name = "labelRes_KVA";
            labelRes_KVA.Size = new Size(60, 15);
            labelRes_KVA.TabIndex = 4;
            labelRes_KVA.Text = "Результат";
            // 
            // textBoxShowModels_KVA
            // 
            textBoxShowModels_KVA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxShowModels_KVA.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxShowModels_KVA.Location = new Point(11, 72);
            textBoxShowModels_KVA.Multiline = true;
            textBoxShowModels_KVA.Name = "textBoxShowModels_KVA";
            textBoxShowModels_KVA.ReadOnly = true;
            textBoxShowModels_KVA.ScrollBars = ScrollBars.Vertical;
            textBoxShowModels_KVA.Size = new Size(410, 205);
            textBoxShowModels_KVA.TabIndex = 3;
            // 
            // textBoxRes_KVA
            // 
            textBoxRes_KVA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxRes_KVA.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxRes_KVA.Location = new Point(11, 26);
            textBoxRes_KVA.Name = "textBoxRes_KVA";
            textBoxRes_KVA.ReadOnly = true;
            textBoxRes_KVA.Size = new Size(833, 23);
            textBoxRes_KVA.TabIndex = 2;
            // 
            // textBoxShopInfo_KVA
            // 
            textBoxShopInfo_KVA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxShopInfo_KVA.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxShopInfo_KVA.Location = new Point(426, 72);
            textBoxShopInfo_KVA.Multiline = true;
            textBoxShopInfo_KVA.Name = "textBoxShopInfo_KVA";
            textBoxShopInfo_KVA.ReadOnly = true;
            textBoxShopInfo_KVA.Size = new Size(418, 205);
            textBoxShopInfo_KVA.TabIndex = 1;
            textBoxShopInfo_KVA.TextChanged += textBoxShopInfo_KVA_TextChanged;
            // 
            // toolTip_KVA
            // 
            toolTip_KVA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 489);
            Controls.Add(panelRes_KVA);
            Controls.Add(panelButtonsInPut_KVA);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная";
            Load += FormMain_Load;
            panelButtonsInPut_KVA.ResumeLayout(false);
            groupBoxInfo_KVA.ResumeLayout(false);
            groupBoxInfo_KVA.PerformLayout();
            panelRes_KVA.ResumeLayout(false);
            panelRes_KVA.PerformLayout();
            ResumeLayout(false);
        }
    }
}
