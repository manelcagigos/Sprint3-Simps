using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESSI
{
    public partial class form_PaginaAdministracio : Form
    {
        public form_PaginaAdministracio()
        {
            InitializeComponent();
        }

        private void form_PaginaAdministracio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bt_GestioUsuaris_Click(object sender, EventArgs e)
        {
            Assembly asm = Assembly.GetEntryAssembly();
            Type formtype = asm.GetType(string.Format("{0}.{1}", "MESSI", "frmTrustedUsers"));

            Form frmTrustedUsers = (Form)Activator.CreateInstance(formtype);
            frmTrustedUsers.Show();

            this.Hide();
        }

        private void bt_regeneracioCoors_Click(object sender, EventArgs e)
        {
            Assembly asm = Assembly.GetEntryAssembly();
            Type formtype = asm.GetType(string.Format("{0}.{1}", "MESSI", "form_AdminCoordinates"));

            Form frmTrustedUsers = (Form)Activator.CreateInstance(formtype);
            frmTrustedUsers.Show();

            this.Hide();
        }

        private void bt_GestioDispositiu_Click(object sender, EventArgs e)
        {
            Assembly asm = Assembly.GetEntryAssembly();
            Type formtype = asm.GetType(string.Format("{0}.{1}", "MESSI", "TrustedDevices"));

            Form frmTrustedUsers = (Form)Activator.CreateInstance(formtype);
            frmTrustedUsers.Show();

            this.Hide();
        }
    }
}
