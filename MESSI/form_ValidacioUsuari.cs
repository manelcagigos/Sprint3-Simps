using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MESSI.TrustedDevices;

namespace MESSI
{
    public partial class form_ValidacioUsuari : Form
    {
        FuncionesDB ddbb = new FuncionesDB();

        public form_ValidacioUsuari()
        {
            InitializeComponent();
        }

        int comptador_errors = 0;
        int numero_intents = 3;
        DataSet dts = new DataSet();
        TrustedDevices td = new TrustedDevices();

        private void bt_LogIn_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\manel\\Desktop\\log_error.log", true);

            string consulta = "Select Users.* FROM Users Where(LOWER(Users.codeUser) = '" + tb_username.Text + "' AND Users.password = '" + tb_password.Text + "'); ";

            dts = ddbb.PortarPerConsulta(consulta);

            string valorCodeUser, valorPassUser, txtMAC, txtHOST;
            bool dadesCorrectes;

            try
            {
                if (dts.Tables[0].Rows.Count == 0)
                {
                    throw new Exception("Credenciales incorrectas.");
                }
                else
                {
                    valorCodeUser = dts.Tables[0].Rows[0]["codeUser"].ToString();
                    valorPassUser = dts.Tables[0].Rows[0]["password"].ToString();
                }

                if (tb_username.Text != valorCodeUser || tb_password.Text != valorPassUser)
                {
                    sw.Write(DateTime.Now + ":" + tb_username.Text + "\n");
                    numero_intents--;
                    comptador_errors++;
                    lb_intents.Text = Convert.ToString(numero_intents);
                }
                else
                {
                    ArrayList direccionMAC;
                    direccionMAC = direccionMac();

                    txtMAC = direccionMAC[0].ToString().ToUpper();
                    txtHOST = Environment.MachineName.ToUpper();

                    string consultaMacHost = "select * from TrustedDevices where 1=1 " + "AND MAC = '" + txtMAC + "' AND HostName = '" + txtHOST + "'";

                    dts = ddbb.PortarPerConsulta(consultaMacHost);

                    if (dts.Tables[0].Rows.Count >= 1)
                    {
                        dadesCorrectes = true;
                        if (dadesCorrectes)
                        {
                            string key = "TrustedUser";

                            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                            if (config.AppSettings.Settings[key].Value == tb_username.Text)
                            {
                                form_PaginaUsuari fmPU = new form_PaginaUsuari();
                                fmPU.Show();
                                this.Hide();
                            }
                        }
                    }
                    
                }

                if (comptador_errors == 3)
                {
                    MessageBox.Show("MES DE 3 ERROS, VIGILA AMB LA PRIMERA ORDRE!!!");
                    Application.Exit();
                }
            }
            catch
            {

            }

            sw.Close();
        }
    }
}
