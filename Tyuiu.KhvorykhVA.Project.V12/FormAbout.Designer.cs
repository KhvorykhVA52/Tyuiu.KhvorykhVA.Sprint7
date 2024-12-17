namespace Tyuiu.KhvorykhVA.Sprint7.Project.V12
{
    partial class FormAbout
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxAbout;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonClose = new Button();
            textBoxAbout = new TextBox();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(567, 330);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Ок";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // textBoxAbout
            // 
            textBoxAbout.Font = new Font("Segoe UI", 12F);
            textBoxAbout.Location = new Point(-3, -1);
            textBoxAbout.Multiline = true;
            textBoxAbout.Name = "textBoxAbout";
            textBoxAbout.ReadOnly = true;
            textBoxAbout.Size = new Size(662, 308);
            textBoxAbout.TabIndex = 3;
            textBoxAbout.Text = resources.GetString("textBoxAbout.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 374);
            Controls.Add(textBoxAbout);
            Controls.Add(buttonClose);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
