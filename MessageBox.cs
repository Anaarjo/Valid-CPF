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
    public partial class MessageBox : Form
    {
        public MessageBox(string msgToDisplay)
        {
            InitializeComponent();
            label1.Text = msgToDisplay;
        }

        private void testeDeClasseDeBotao1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
