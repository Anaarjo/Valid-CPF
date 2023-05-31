namespace WinFormsApp1
{
    partial class MessageBoxInvalid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxInvalid));
            testeDeClasseDeBotao1 = new S.A_tentativa.TesteDeClasseDeBotao();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // testeDeClasseDeBotao1
            // 
            testeDeClasseDeBotao1.BackColor = Color.MidnightBlue;
            testeDeClasseDeBotao1.FlatAppearance.BorderSize = 0;
            testeDeClasseDeBotao1.FlatStyle = FlatStyle.Flat;
            testeDeClasseDeBotao1.ForeColor = Color.White;
            testeDeClasseDeBotao1.Location = new Point(86, 149);
            testeDeClasseDeBotao1.Name = "testeDeClasseDeBotao1";
            testeDeClasseDeBotao1.Size = new Size(93, 40);
            testeDeClasseDeBotao1.TabIndex = 2;
            testeDeClasseDeBotao1.Text = "OK";
            testeDeClasseDeBotao1.UseVisualStyleBackColor = false;
            testeDeClasseDeBotao1.Click += testeDeClasseDeBotao1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Miriam CLM", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(72, 92);
            label2.Name = "label2";
            label2.Size = new Size(0, 27);
            label2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(229, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 47);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(250, 0);
            label1.Name = "label1";
            label1.Size = new Size(34, 37);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // MessageBoxInvalid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 195);
            Controls.Add(panel1);
            Controls.Add(testeDeClasseDeBotao1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MessageBoxInvalid";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MessageBoxInvalid";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private S.A_tentativa.TesteDeClasseDeBotao testeDeClasseDeBotao1;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
    }
}