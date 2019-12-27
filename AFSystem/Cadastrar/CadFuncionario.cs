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
    /// <summary>
    /// Aplicação criada por Edivaldo dos Santos Jorge
    /// Facebook - Edvaldo Jorge (fb.me/edy96jorge)
    /// Instagram - @jorgeedvaldo (instagram.com/jorgeedvaldo)
    /// </summary>

    public partial class CadFuncionario : Form
    {
        String Foto = "";

        public CadFuncionario()
        {
            InitializeComponent();
        }

        #region metodos

        //Este método é chamado quando o texto das txtBox q são obrigatórias é alterado
        void verificarValidar(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtBI.Text) || string.IsNullOrEmpty(txtTel1.Text) || string.IsNullOrEmpty(txtMunicipio.Text) || string.IsNullOrEmpty(txtDistrito.Text) || string.IsNullOrEmpty(txtBairro.Text) || string.IsNullOrEmpty(txtRua.Text))
            {
                btConfirmar.Enabled = false;
                lbAviso.Visible = true;
            }
            else
            {
                if (radioButton1.Checked)
                {
                    if (string.IsNullOrEmpty(txtuser.Text) || string.IsNullOrEmpty(txtpassword.Text))
                    {
                        btConfirmar.Enabled = false;
                        lbAviso.Visible = true;                     
                    }
                    else {
                        btConfirmar.Enabled = true;
                        lbAviso.Visible = false;
                    }
                }
                else {
                    btConfirmar.Enabled = true;
                    lbAviso.Visible = false;
                }
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
            else
            {
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

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadFuncionario_Load(object sender, EventArgs e)
        {
            cbGenero.Text = "Masculino";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = radioButton1.Checked;

            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtBI.Text) || string.IsNullOrEmpty(txtTel1.Text) || string.IsNullOrEmpty(txtMunicipio.Text) || string.IsNullOrEmpty(txtDistrito.Text) || string.IsNullOrEmpty(txtBairro.Text) || string.IsNullOrEmpty(txtRua.Text))
            {
                btConfirmar.Enabled = false;
                lbAviso.Visible = true;
            }
            else
            {
                if (radioButton1.Checked)
                {
                    if (string.IsNullOrEmpty(txtuser.Text) || string.IsNullOrEmpty(txtpassword.Text))
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
                else
                {
                    btConfirmar.Enabled = true;
                    lbAviso.Visible = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Abrir Imagem";
            ofd.Filter = "Jpg Files(*.jpg)|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
                Foto = ofd.FileName.ToString();
            }
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
           
        }

    }
}
