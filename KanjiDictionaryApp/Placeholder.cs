using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanjiDictionaryApp
{
    public static class Placeholder
    {
        public static void enter_event_placeholder(TextBox txt, string str)
        {
            if (txt.Text == str)
            {
                txt.Text = "";
                txt.ForeColor = Color.FromArgb(50, 49, 69);
            }
        }

        public static void leave_event_placeholder(TextBox txt, string str)
        {
            if (txt.Text == "")
            {
                txt.Text = str;
                txt.ForeColor = Color.DarkGray;
            }
        }
    }
}
