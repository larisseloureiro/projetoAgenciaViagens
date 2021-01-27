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
    public partial class FormFuncionarios : Form
    {
        public FormFuncionarios()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxNome_Leave(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "")
            {
                errorP.SetError(textBoxNome, "Nome Obrigatório!");
                textBoxNome.Focus();
            }
            else
            {
                errorP.Clear();
                textBoxNome.Text = textBoxNome.Text.ToUpper();
            }

        }

        private void RadioButtonHor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButtonMensal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonFicha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arquivo gerado!" ,"ALERTA");

            string nomefun = "funcionario" + textBoxNome.Text + "txt";
            StreamWriter arquivo = new StreamWriter(nomefun, false);
            arquivo.WriteLine("Cadastro " + DateTime.Now);
            arquivo.WriteLine("----------------------");
            arquivo.WriteLine("Funcionário: " + textBoxNome.Text);
            if (radioButtonMensal.Checked == true)
            {
                arquivo.WriteLine("Quantidade de vales: 30");
            } else
            {
                arquivo.WriteLine("Quantidade de vales: ___");
            }
            arquivo.Close();
            
        }

        private void FormFuncionarios_Load(object sender, EventArgs e)
        {

        }
    }
    }

