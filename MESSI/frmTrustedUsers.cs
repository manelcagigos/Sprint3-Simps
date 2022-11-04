using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESSI
{
    public partial class frmTrustedUsers : Form
    {
        FuncionesDB classeDB = new FuncionesDB();

        public frmTrustedUsers()
        {
            InitializeComponent();
        }

        private void frmTrustedUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Assembly asm = Assembly.GetEntryAssembly();
            Type formtype = asm.GetType(string.Format("{0}.{1}", "MESSI", "form_PaginaAdministracio"));

            Form frmTrustedUsers = (Form)Activator.CreateInstance(formtype);
            frmTrustedUsers.Show();

            this.Hide();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            string key = "TrustedUser";

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = combUser.Text;
            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
        }

        private void frmTrustedUsers_Load(object sender, EventArgs e)
        {
            classeDB.Connectar();

            DataSet dts = new DataSet();

            dts = classeDB.PortarPerConsulta("Select codeUser From Users");

            combUser.DataBindings.Clear();

            combUser.DataBindings.Add("Items", dts.Tables["Users"], "codeUser");
        }
    }
}
