namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnValidar = new S.A_tentativa.TesteDeClasseDeBotao();
            btnLimpar = new S.A_tentativa.TesteDeClasseDeBotao();
            txtCPF = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnValidar
            // 
            btnValidar.BackColor = Color.DarkBlue;
            btnValidar.FlatAppearance.BorderSize = 0;
            btnValidar.FlatStyle = FlatStyle.Flat;
            btnValidar.ForeColor = Color.White;
            btnValidar.Location = new Point(365, 207);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(97, 40);
            btnValidar.TabIndex = 0;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = false;
            btnValidar.Click += BtnValidar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.DodgerBlue;
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(490, 207);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(97, 40);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "Limpar\r\n";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtCPF
            // 
            txtCPF.BackColor = Color.FromArgb(232, 234, 237);
            txtCPF.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtCPF.Location = new Point(365, 131);
            txtCPF.MaxLength = 11;
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(222, 39);
            txtCPF.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(365, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(222, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-17, -75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 441);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 234, 237);
            ClientSize = new Size(599, 292);
            Controls.Add(pictureBox2);
            Controls.Add(txtCPF);
            Controls.Add(btnLimpar);
            Controls.Add(btnValidar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "S.A";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private S.A_tentativa.TesteDeClasseDeBotao btnValidar;
        private S.A_tentativa.TesteDeClasseDeBotao btnLimpar;
        private TextBox txtCPF;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}