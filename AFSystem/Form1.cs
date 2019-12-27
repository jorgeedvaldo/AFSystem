using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFSystem
{
    /// <summary>
    /// Aplicação criada por Edivaldo dos Santos Jorge
    /// Facebook - Edvaldo Jorge (fb.me/edy96jorge)
    /// Instagram - @jorgeedvaldo (instagram.com/jorgeedvaldo)
    /// </summary>

    public partial class Form1 : EdvFramework.EdvForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Métodos 

        void openForm(Form cn)
        {
            if (this.MdiChildren.Length != 0)
            {
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }
            }
            cn.MdiParent = this;
            cn.StartPosition = FormStartPosition.CenterParent;
            cn.WindowState = FormWindowState.Maximized;
            cn.Show();
            
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            //Mudar a cor do fundo do form mdi
            foreach (Control cn in this.Controls)
            {
                if (cn.GetType().Name == "MdiClient")
                {
                    cn.BackColor = Color.FromName("Control");                 
                }
            }

            lbdatadeHoje.Text = DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = panel1.Visible == true ? false : true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openForm(new Cadastrar.CadCliente());
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openForm(new Cadastrar.CadFuncionario());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openForm(new Cadastrar.CadProduto());
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openForm(new Consultar.ConsultarCliente());           
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openForm(new Consultar.ConsultarFuncionario());
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openForm(new Consultar.ConsultarProduto());
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Cadastrar.CadCliente());
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Cadastrar.CadProduto());
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Cadastrar.CadFornecedor());
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Cadastrar.CadFuncionario());
        }

        private void utilizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Cadastrar.CadUtilizador());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openForm(new Consultar.ConsultarCliente());
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            openForm(new Consultar.ConsultarProduto());
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            openForm(new Consultar.ConsultarFornecedor());
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            openForm(new Consultar.ConsultarFuncionario());
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            openForm(new Consultar.ConsultarUtilizador());
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Consultar.ConsultarVenda());
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult SimNao = MessageBox.Show("Tem a certeza que deseja sair do sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(SimNao == System.Windows.Forms.DialogResult.Yes){
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbdatadeHoje.Text = DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToLongTimeString();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void minhasAnotaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openForm(new Consultar.ConsultarVenda());
        }
    }
}
