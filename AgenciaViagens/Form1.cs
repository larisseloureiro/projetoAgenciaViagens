using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace AgenciaViagens
{
    public partial class Form1 : Form
    {

        Thread novatela;
        public Form1()
        {
            InitializeComponent();
        }

    

        private void novoForm()
        {
            Application.Run(new FormMenu());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Entrar(object sender, EventArgs e)
        {
            if (textBox1.Text == "Larisse")
            {
                MessageBox.Show("\n\tUsuário permitido!\n\t " + DateTime.Now, "ALERTA", MessageBoxButtons.OKCancel);
                this.Close();

                novatela = new Thread(novoForm);
                novatela.SetApartmentState(ApartmentState.STA);
                novatela.Start();
                //thread usa quando é varios processos

                //FORMA 2 DE ABRIR O NOVO FORMULARIO, abre um nome mas bloqueia para nao abrir varios menu
                //FormMenu formMenu = new FormMenu();
                //FormMenu.ShowDialog();

            }
            else
            {
                MessageBox.Show("Senha Inválida!");
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
