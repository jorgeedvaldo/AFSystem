using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFSystem.Cadastrar
{
    public partial class CadProduto : Form
    {
        /// <summary>
        /// Aplicação criada por Edivaldo dos Santos Jorge
        /// Facebook - Edvaldo Jorge (fb.me/edy96jorge)
        /// Instagram - @jorgeedvaldo (instagram.com/jorgeedvaldo)
        /// </summary>

        public CadProduto()
        {
            InitializeComponent();
        }

        #region Métodos
        void verificarValidar(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtPreco.Text) || string.IsNullOrEmpty(txtQuantidade.Text))
            {
                btConfirmar.Enabled = false;
                lbAviso.Visible = true;
            }
            else
            {
                btConfirmar.Enabled = true;
                lbAviso.Visible = false;
            }
        }
        #endregion

        #region metodos KeyPress para as text box dos preços e quantidade
        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
           
        }
        #endregion

        private void CadProduto_Load(object sender, EventArgs e)
        {
            cbFornecedor.Text = "Nenhum";
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
