﻿using System;
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

        string rutaAcceso = "Data Source=CAFUNEPORTATIL\\SQLEXPRESS;Initial Catalog=MACSBBDD;Integrated Security=True";
        string consulta = "select * from TrustedDevices";
        bool existe = false;
        bool ativarBntDel = false;
        bool ativarBntSav = false;

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
            string textoMac = txtMac.Text;
            string textoHost = txtHost.Text;

            //pillar Mac y Host
            ArrayList direccion = direccionMac();
            textoMac = direccion[0].ToString().ToUpper();
            textoHost = Environment.MachineName.ToUpper();

            //escribir en form
            txtHost.Text = textoHost;
            txtMac.Text = textoMac;

            FuncionesDB db = new FuncionesDB();
            DataSet dts = new DataSet();

            //Verificar boton:
            db.Connectar();

            dts = db.PortarPerConsulta(consulta);

            string valor = dts.Tables[0].Rows[0]["MAC"].ToString();

            if (valor != null)
            {
                bntDel.BackColor = Color.Green;
                ativarBntDel = true;
            }
            else
            {
                bntSave.BackColor = Color.Green;
                ativarBntSav = true;
            }
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            if (ativarBntSav)
            {

            }
            else
            {
                MessageBox.Show("Este boton no puede ser activadoo ahora.");
            }
        }

        private void bntDel_Click(object sender, EventArgs e)
        {

            if (ativarBntDel)
            {
                FuncionesDB db = new FuncionesDB();
                DataSet dts = new DataSet();
                DataTable dt = new DataTable();

                db.Connectar();
                dts = db.PortarPerConsulta(consulta);

                DataRow dr = dts.Tables["TrustedDevices"].NewRow();
                dr["MAC"] = txtMac.Text.ToString();

                dt.Rows.Remove(dr);

                db.Actualitzar();
            }
            else
            {
                MessageBox.Show("Este boton no puede ser activado ahora.");
            }
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
