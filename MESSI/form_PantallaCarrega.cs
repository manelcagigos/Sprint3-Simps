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
    public partial class form_PantallaCarrega : Form
    {
        public form_PantallaCarrega()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;

            if(panel2.Width >= 700)
            {
                timer_PantallaCarrega.Stop();
                form_ValidacioUsuari fmVU = new form_ValidacioUsuari();
                fmVU.Show();
                this.Hide();
            }
        }

        private void formPantallaCarrega_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F2)
            {
                timer_PantallaCarrega.Stop();
                this.Hide();
                form_ValidacioAdmin fmVA = new form_ValidacioAdmin();
                fmVA.Show();
            }

            if (e.Control)
            {
                timer_PantallaCarrega.Stop();
                this.Hide();
                form_ValidacioUsuari fmVU = new form_ValidacioUsuari();
                fmVU.Show();
            }
        }
    }
}
