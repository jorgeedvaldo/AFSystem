using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace AFSystem
{
    class Edv
    {
        /// <summary>
        /// Aplicação criada por Edivaldo dos Santos Jorge
        /// Facebook - Edvaldo Jorge (fb.me/edy96jorge)
        /// Instagram - @jorgeedvaldo (instagram.com/jorgeedvaldo)
        /// </summary>

        #region Métodos uteis
        public static void LimparTextBox(Form fr)
        {
            foreach (Control cn in fr.Controls)
            {
                if (cn.GetType().Name == "TextBox")
                {
                    cn.Text = "";
                }
            }
        }
        #endregion
    }
}
