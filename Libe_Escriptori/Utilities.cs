using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libe_Escriptori
{
    public static class Utilities
    {
        /**
        * TEXT BOX ACTION -- Delete the written text inside the text box when you select it
        */
        public static void textBoxSearch_Enter(TextBox textBoxNickSearch, String textHint)
        {
            if (textBoxNickSearch.Text == textHint)
            {
                textBoxNickSearch.ForeColor = Color.Black;
                textBoxNickSearch.Text = "";
            }
        }
        /**
        * Función que vuelve a dejar la palabra "buscar..." cuando salimos del textBoxNickSearch 
        * y no hay nada escrito en él.
        */
        public static void textBoxSearch_Leave(TextBox textBoxNickSearch, String textHint)
        {
            if (textBoxNickSearch.Text == "")
            {
                textBoxNickSearch.ForeColor = Color.Gray;
                textBoxNickSearch.Text = textHint;
            }

        }

    }
}
