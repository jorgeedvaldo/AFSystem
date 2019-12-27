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
    public partial class CadUtilizador : Form
    {
        /// <summary>
        /// Aplicação criada por Edivaldo dos Santos Jorge
        /// Facebook - Edvaldo Jorge (fb.me/edy96jorge)
        /// Instagram - @jorgeedvaldo (instagram.com/jorgeedvaldo)
        /// </summary>

        public CadUtilizador()
        {
            InitializeComponent();
        }

        #region Métodos
        void verificarValidar(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text))
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

        private void CadUtilizador_Load(object sender, EventArgs e)
        {
            cbCargo.Text = "Atendente";
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
