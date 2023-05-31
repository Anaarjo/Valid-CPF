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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtCPF.KeyPress += textBox1_KeyPress;
        }

        public void textBox1_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Aqui só aceitará números e será possível apagá-los.
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Impede que o caractere seja inserido no TextBox
                e.Handled = true;
            }
        }


        void BtnValidar_Click(object sender, EventArgs e)
        {
            // Declaração da variável
            string numeroString = txtCPF.Text;
            // Utilização do método para validar
            if (Tenta.ValidaCPF.Validar(numeroString))
            {
                // Quando clicar no botão de validar
                //irá aparecer essa mensagem caso seja válido
                new MessageBox("CPF válido").ShowDialog();
            }
            // Caso contrário será inválido
            else
            {
                new MessageBoxInvalid("CPF inválido").ShowDialog();
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)

        {
            // Aqui apaga oque está dentro da textBox "txtCPF".
            txtCPF.Clear();
        }


    }

}

