using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFSystem.Consultar
{
    public partial class ConsultarCliente : Form
    {
        /// <summary>
        /// Aplicação criada por Edivaldo dos Santos Jorge
        /// Facebook - Edvaldo Jorge (fb.me/edy96jorge)
        /// Instagram - @jorgeedvaldo (instagram.com/jorgeedvaldo)
        /// </summary>

        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {
            cbtipoconsulta.Text = "Nome";
        }

        private void txtNumeroCasa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
