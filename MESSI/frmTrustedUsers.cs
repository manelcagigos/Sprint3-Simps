using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESSI
{
    public partial class frmTrustedUsers : Form
    {
        public frmTrustedUsers()
        {
            InitializeComponent();
        }

        private void frmTrustedUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            string key = "TrustedUser";

            //try
            //{
            //    var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //    var settings = configFile.AppSettings.Settings;
            //    if (settings[key] == null)
            //    {
            //        settings.Add(key, combUser.Text);
            //    }
            //    else
            //    {
            //        settings[key].Value = combUser.Text;
            //    }
            //    configFile.Save(ConfigurationSaveMode.Modified);
            //    ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            //}
            //catch (ConfigurationErrorsException)
            //{
                  //Console.WriteLine("Error writing app settings");
            //}

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = combUser.Text;
            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
