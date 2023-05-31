using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MessageBoxInvalid : Form
    {
        public MessageBoxInvalid(string msgToDisplayu)
        {
            InitializeComponent();

            label2.Text = msgToDisplayu;


        }

        private void testeDeClasseDeBotao1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
