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

namespace MESSI
{
    public partial class TrustedDevices : Form
    {
        public TrustedDevices()
        {
            InitializeComponent();
        }

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
            ArrayList direccion = direccionMac();
            txtMac.Text = direccion[0].ToString().ToUpper();
            txtHost.Text = Environment.MachineName.ToUpper();
        }
    }
}
