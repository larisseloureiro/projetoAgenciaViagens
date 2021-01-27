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
    public partial class FormMenu : Form
    {
        Thread novatela2;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void orçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            novatela2 = new Thread(NewForm);
            novatela2.SetApartmentState(ApartmentState.STA);
            novatela2.Start();
            //thread usa quando é varios processos

            //FORMA 2 DE ABRIR O NOVO FORMULARIO, abre um nome mas bloqueia para nao abrir varios menu
            //FormMenu formMenu = new FormMenu();
            //FormMenu.ShowDialog();


        }

        private void NewForm()
        {
            Application.Run(new FormOrcamento());
        }

        private void FuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuncionarios FormMenu = new FormFuncionarios();
            FormMenu.ShowDialog();

        }
    }
}
