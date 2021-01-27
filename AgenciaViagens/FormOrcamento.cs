using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AgenciaViagens
{
    public partial class FormOrcamento : Form
    {
        public FormOrcamento()
        {
            InitializeComponent();
        }

        private void label1_Nome_Click(object sender, EventArgs e)
        {

        }

      

        private void button1_Orçamento(object sender, EventArgs e)
        {  //decimal ou double, decimal usa mais mas para banco eh o melhor
            float valorv = 0, valorp = 0, valor = 0 ;
            string destino;
            destino = comboBoxDestino.Text;
            if (destino == "SP")
            {
                valor = 200.0f;
                
            } else if (destino == "RJ")
            {
                valor = 100.0f;
            } else if (destino == "Natal")
            {
                valor = 400.0f;
            } 
            if (radioButton1Vista.Checked == true)
            {
                valorv = valor * 0.9f;
            } else if (radioButton1Parcelado.Checked == true)
            {
                valorp = valor * 1.05f;
            }
            MessageBox.Show("A vista " + valorv + "\nParcelado " + valorp);
            MessageBox.Show("Orçamento em arquivo gerado!");

            string nomearquivo = "Orcamento" + textBox1_Nome.Text + "txt";
            StreamWriter arquivo = new StreamWriter(nomearquivo,false);
            arquivo.WriteLine("Cadastro de Orçamento");
            arquivo.WriteLine("----------------------");
            arquivo.WriteLine("Data: " + DateTime.Now);
            arquivo.WriteLine("Nome: " + textBox1_Nome.Text);
            arquivo.WriteLine("Destino: " + comboBoxDestino.Text);
            arquivo.WriteLine("A vista R$" + valorv + "\nParcelado R$" + valorp);
             arquivo.Close();

            
        }

        private void Label1_Vlr_Click(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_Nome_Leave(object sender, EventArgs e)
        {
            if (textBox1_Nome.Text == "")
            {
                errorP.SetError(textBox1_Nome, "Nome Obrigatório!");
                textBox1_Nome.Focus();
            }
            else
            {
                errorP.Clear();
                textBox1_Nome.Text = textBox1_Nome.Text.ToUpper();
            }
                
        }

    }
}

