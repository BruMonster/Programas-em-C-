using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteDeControles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeUsuario;
            DateTime dataNascimento;
            string cidade;
            bool generoM;
            bool generoF;
            int numeroCadastro;

            nomeUsuario = textBox1.Text;
            dataNascimento = dateTimePicker1.Value;
            cidade = comboBox1.Text;
            generoM = radioButton1.Checked;
            generoF = radioButton2.Checked;
            numeroCadastro = Convert.ToInt32(textBox2.Text);

            MessageBox.Show("Seja Bem Vindo " + nomeUsuario);
            MessageBox.Show("Nascido em: " + dataNascimento);
            MessageBox.Show("Cidade: " + cidade);
            MessageBox.Show("Sexo Masculino:" + generoM);
            MessageBox.Show("Sexo Feminino:" + generoF);
            MessageBox.Show("Número de cadastro:" + numeroCadastro);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
