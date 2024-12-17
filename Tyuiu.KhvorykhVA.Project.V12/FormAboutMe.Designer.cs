namespace Tyuiu.KhvorykhVA.Sprint7.Project.V12
{
    partial class FormAboutMe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutMe));
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(190, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(299, 75);
            label1.TabIndex = 0;
            label1.Text = "Разработчик: Хворых Виктор Александрович\r\nГруппа: АСОиУБ-24-1\r\nПрограмма разработана на языке С#\r\nТюменский индустриальный университет\r\nВнутреннее имя: Tyuiu.KhvorykhVA.Sprint7.Project.V12";
            //
            // button1
            //
            button1.BackColor = System.Drawing.Color.GhostWhite;
            button1.Location = new System.Drawing.Point(410, 195);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(79, 27);
            button1.TabIndex = 1;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            //
            // pictureBox1
            //
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(159, 154);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            //
            // FormAbout
            //
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightSteelBlue;
            ClientSize = new System.Drawing.Size(500, 241);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximumSize = new System.Drawing.Size(516, 280);
            MinimumSize = new System.Drawing.Size(516, 280);
            Name = "FormAbout";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Дополнительная информация";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
