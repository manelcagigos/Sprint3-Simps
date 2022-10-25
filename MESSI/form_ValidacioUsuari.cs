using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESSI
{
    public partial class form_ValidacioUsuari : Form
    {
        public form_ValidacioUsuari()
        {
            InitializeComponent();
        }

        int comptador_errors = 0;
        int numero_intents = 3;

        private void bt_LogIn_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\manel\\Desktop\\log_error.log", true);

            if (tb_username.Text != "manel" || tb_password.Text != "12345aA")
            {
                sw.Write(DateTime.Now + ":" + tb_username.Text + "\n");
                numero_intents--;
                comptador_errors++;
                lb_intents.Text = Convert.ToString(numero_intents);
            }
            else
            {
                form_PaginaUsuari fmPU = new form_PaginaUsuari();
                fmPU.Show();
                this.Hide();
            }

            if (comptador_errors == 3)
            {
                MessageBox.Show("MES DE 3 ERROS, VIGILA AMB LA PRIMERA ORDRE!!!");
                Application.Exit();
            }
            sw.Close();
        }
    }
}
