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
    public partial class form_AdminCoordinates : Form
    {
        public form_AdminCoordinates()
        {
            InitializeComponent();
        }

        private void form_AdminCoordinates_FormClosing(object sender, FormClosingEventArgs e)
        {
            Assembly asm = Assembly.GetEntryAssembly();
            Type formtype = asm.GetType(string.Format("{0}.{1}", "MESSI", "form_PaginaAdministracio"));

            Form frmTrustedUsers = (Form)Activator.CreateInstance(formtype);
            frmTrustedUsers.Show();

            this.Hide();
        }

        Dictionary<string, string> coordenades = new Dictionary<string, string>();
        List<String> LletrasNumeros = new List<string>();

        private void btGenerate_Click(object sender, EventArgs e)
        {
            coordenades.Clear();
            LletrasNumeros.Clear();

            Random R = new Random();
            
            //coordenades.Add("A1", "1234");
            //tb_password.Text = coordenades["A1"];

            string LletraNumero, num_aleatori_pass;
            int longitud, posicio_aleatoria;

            LletraNumero = "";

            //for per la creacio de les coordenades (A1 fins a D5)
            for (char i = (char)65; i < (char)69; i++)
            {
                LletraNumero = Convert.ToString(i);
                for (int j = 1; j <= 5; j++)
                {
                    LletraNumero += j;
                    LletrasNumeros.Add(LletraNumero);
                    LletraNumero = Convert.ToString(i);
                }
                LletraNumero = "";
            }

            longitud = LletrasNumeros.Count;
            posicio_aleatoria = R.Next(0, longitud);

            int contador = 0;

            while (contador < LletrasNumeros.Count)
            {
                num_aleatori_pass = Convert.ToString(R.Next(0, 10000));

                switch (num_aleatori_pass.Length)
                {
                    case 3:
                        num_aleatori_pass = "0" + num_aleatori_pass;
                        break;

                    case 2:
                        num_aleatori_pass = "00" + num_aleatori_pass;
                        break;

                    case 1:
                        num_aleatori_pass = "000" + num_aleatori_pass;
                        break;
                }

                if (!(coordenades.ContainsValue(num_aleatori_pass)))
                {
                    coordenades.Add(LletrasNumeros[contador], num_aleatori_pass);
                    contador++;
                }
            }
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            int columna = tlpCoordinates.ColumnCount - 1;
            int row = tlpCoordinates.RowCount - 1;

            int total_casellas = columna * row;

            for(int i = 0; i <= total_casellas; i++)
            {
                tlpCoordinates.Controls.Remove(tlpCoordinates.GetControlFromPosition(1, 1));
            }

            if(coordenades.Count == 0)
            {
                lbAdvertencia.Text = "Primero clicar al boton 'Generate' y luego a 'Show'";
            }
            else
            {
                lbAdvertencia.Text = "";

                using (Font fuente = new Font("Nirmala UI", 12f, FontStyle.Bold))
                {
                    for (int i = 0; i < total_casellas; i++)
                    {
                        Label lb_panel = new Label();
                        lb_panel.Width = 100;
                        lb_panel.Height = 68;
                        lb_panel.Font = fuente;
                        lb_panel.Dock = DockStyle.Fill;
                        lb_panel.Anchor = AnchorStyles.None;

                        tlpCoordinates.Controls.Add(lb_panel);
                        lb_panel.Text = coordenades[LletrasNumeros[i]];
                    }
                }
            }
        }

        private void form_AdminCoordinates_Load(object sender, EventArgs e)
        {
            tlpCoordinates.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
        }
    }
}