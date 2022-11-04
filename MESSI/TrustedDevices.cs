using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Net.NetworkInformation;
using System.Data.SqlClient;
using System.Reflection;

namespace MESSI
{
    public partial class TrustedDevices : Form
    {
        public TrustedDevices()
        {
            InitializeComponent();
        }

        //string rutaAcceso = "Data Source=CAFUNEPORTATIL\\SQLEXPRESS;Initial Catalog=MACSBBDD;Integrated Security=True";
        //string consulta = "select * from dbo.datosdebbdd";
        //bool existe = false;

        //Metodo para conseguir la MAC del PC
        //Se necesita 2 usings, Collections y Net.Network
        public static ArrayList direccionMac()
        {
            ArrayList direccionMac = new ArrayList();
            //comando para buscar los adaptadores de red
            NetworkInterface[] adaptador = null;
            //.getAllNet pilla todos los adaptadores de red del PC
            adaptador = NetworkInterface.GetAllNetworkInterfaces();

            //valida que tenemos al menos un adaptador
            if (adaptador != null && adaptador.Length > 0)
            {
                //recorre todos los adaptadores
                foreach (NetworkInterface interfaces in adaptador)
                {
                    //obtiene la direccion MAC
                    var direccion = interfaces.GetPhysicalAddress();
                    byte[] bytes = direccion.GetAddressBytes();
                    string mac = string.Empty;
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        //separamos los numeros en pares
                        mac = mac + bytes[i].ToString("x2");
                        if (i != bytes.Length-1)
                        {
                            //ponemos un guion cada 2 numeros
                            mac = mac + "-";
                        }
                    }
                    direccionMac.Add(mac);
                }
            }
            return direccionMac;
        }


        private void TrustedDevices_Load(object sender, EventArgs e)
        {
            //pillar Mac y Host
            ArrayList direccion = direccionMac();
            txtMac.Text = direccion[0].ToString().ToUpper();
            txtHost.Text = Environment.MachineName.ToUpper();

            ////Verificar boton:
            //SqlConnection conect;
            //conect = new SqlConnection(rutaAcceso);

            //SqlDataAdapter tabla;
            //tabla = new SqlDataAdapter(consulta, conect);

            //conect.Open();

            //DataSet dts = new DataSet();
            //tabla.Fill(dts, "mac");

            //conect.Close();

            //DataRow dr = dts.Tables[0].NewRow();

            //for (int i = 0; i < dts.Tables.Count; i++)
            //{
            //    dts.Tables[i].Rows.Contains(txtMac);
            //    existe = true;
            //}

            //dr["MAC"] = txtMac.Text;

            
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            

            
        }

        private void bntDel_Click(object sender, EventArgs e)
        {


        }

        private void TrustedDevices_FormClosing(object sender, FormClosingEventArgs e)
        {
            Assembly asm = Assembly.GetEntryAssembly();
            Type formtype = asm.GetType(string.Format("{0}.{1}", "MESSI", "form_PaginaAdministracio"));

            Form frmTrustedUsers = (Form)Activator.CreateInstance(formtype);
            frmTrustedUsers.Show();

            this.Hide();
        }
    }
}
