namespace WinFormsApp1
{
    partial class MessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBox));
            panel1 = new Panel();
            label2 = new Label();
            testeDeClasseDeBotao1 = new S.A_tentativa.TesteDeClasseDeBotao();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 47);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(229, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 37);
            label2.TabIndex = 1;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // testeDeClasseDeBotao1
            // 
            testeDeClasseDeBotao1.BackColor = Color.MidnightBlue;
            testeDeClasseDeBotao1.FlatAppearance.BorderSize = 0;
            testeDeClasseDeBotao1.FlatStyle = FlatStyle.Flat;
            testeDeClasseDeBotao1.ForeColor = Color.White;
            testeDeClasseDeBotao1.Location = new Point(94, 143);
            testeDeClasseDeBotao1.Name = "testeDeClasseDeBotao1";
            testeDeClasseDeBotao1.Size = new Size(93, 40);
            testeDeClasseDeBotao1.TabIndex = 1;
            testeDeClasseDeBotao1.Text = "OK";
            testeDeClasseDeBotao1.UseVisualStyleBackColor = false;
            testeDeClasseDeBotao1.Click += testeDeClasseDeBotao1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Miriam CLM", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(72, 92);
            label1.Name = "label1";
            label1.Size = new Size(0, 27);
            label1.TabIndex = 2;
            // 
            // MessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 234, 237);
            ClientSize = new Size(267, 195);
            Controls.Add(label1);
            Controls.Add(testeDeClasseDeBotao1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MessageBox";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private S.A_tentativa.TesteDeClasseDeBotao testeDeClasseDeBotao1;
        private Label label1;
        private Label label2;
    }
}