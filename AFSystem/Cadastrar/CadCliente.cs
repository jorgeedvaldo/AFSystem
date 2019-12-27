﻿using System;
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
    public partial class CadCliente : Form
    {
        /// <summary>
        /// Aplicação criada por Edivaldo dos Santos Jorge
        /// Facebook - Edvaldo Jorge (fb.me/edy96jorge)
        /// Instagram - @jorgeedvaldo (instagram.com/jorgeedvaldo)
        /// </summary>

        public CadCliente()
        {
            InitializeComponent();           
        }

        #region metodos

        //Este método é chamado quando o texto das txtBox q são obrigatórias é alterado
        void verificarValidar(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtBI.Text) || string.IsNullOrEmpty(txtTel1.Text))
            {
                btConfirmar.Enabled = false;
                lbAviso.Visible = true;
            }
            else {
                btConfirmar.Enabled = true;
                lbAviso.Visible = false;
            }
        }

        #endregion

        #region metodos KeyPress para as text box dos telemoveis 
        private void txtTel1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == '+'))
            {
                e.Handled = true;
                label2.Visible = true;
            }
            else {
                label2.Visible = false;
            }
        }
        private void txtTel2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == '+'))
            {
                e.Handled = true;
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
            }
        }
        #endregion

        private void Cadastrar_Clientes_Load(object sender, EventArgs e)
        {
            cbGenero.Text = "Masculino";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //Cancelando a operação
            DialogResult SimNao = MessageBox.Show("Tem a certeza que deseja cancelar esta operação?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(SimNao == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

       
    }
}
