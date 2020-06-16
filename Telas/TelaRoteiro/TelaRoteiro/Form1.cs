using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaRoteiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NF : 156 ROTERIZADA" +"\n"+"COM SUCESSO");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODAS AS NFs DO ROMANEIO: 1567" + "\n" + "FORAM ADICIONADAS");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Intinerário Finalizado"+"\n"+"Com Sucesso"+"\n"+"Redirecionando para Google Maps");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Instantes Você Será"+"\n"+"Redirecionado para o Google Maps");
        }
    }
}
