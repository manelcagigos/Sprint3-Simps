using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESSI
{
    public partial class form_PaginaUsuari : Form
    {
        public form_PaginaUsuari()
        {
            InitializeComponent();
        }

        private void form_PaginaUsuari_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
