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
    public partial class form_ValidacioAdmin : Form
    {
        public form_ValidacioAdmin()
        {
            InitializeComponent();;
        }

        //La taula de coordenades i codi, ha de ser fixa o ha de variar cada cop, pero llavors
        //com la ensenyem cada vegada al usuari, perque si variar cada cop, l'usuari no sabara mai el codi
        //i no podem ensenyar-lo amb un boto perque el podria veure qualsevol persona.

        Dictionary<string, string> coordenades = new Dictionary<string, string>();

        private void form_ValidacioAdmin_Load(object sender, EventArgs e)
        {
            FuncionesDB funcionsBSDD = new FuncionesDB();

            funcionsBSDD.Executa("DELETE FROM AdminCoordinates");

            Random R = new Random();

            List<String> LletrasNumeros = new List<string>();
            List<String> numeros_teclat = new List<string>() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};
            Queue<String> cua_numeros = new Queue<string>();          

            //coordenades.Add("A1", "1234");
            //tb_password.Text = coordenades["A1"];

            string LletraNumero, num_aleatori_pass;
            int longitud, posicio_aleatoria, posicio_aleatoria_teclat, longitud_cua;

            LletraNumero = "";
            posicio_aleatoria_teclat = 0;

            //for per la creacio de les coordenades (A1 fins a D5)
            for(char i = (char) 65; i < (char)69; i++)
            {
                LletraNumero = Convert.ToString(i);
                for(int j = 1; j <= 5; j++)
                {
                    LletraNumero += j;
                    LletrasNumeros.Add(LletraNumero);
                    LletraNumero = Convert.ToString(i);
                }
                LletraNumero = "";
            }

            longitud = LletrasNumeros.Count;
            posicio_aleatoria = R.Next(0, longitud);

            lb_LLetraNumero.Text = LletrasNumeros[posicio_aleatoria];

            //for per guardar els numeros de manera aleatoria en una cua
            for(int i = 0; i <=9; i++)
            {
                longitud = numeros_teclat.Count;
                posicio_aleatoria_teclat = R.Next(0, longitud);
                cua_numeros.Enqueue(numeros_teclat[posicio_aleatoria_teclat]);
                numeros_teclat.RemoveAt(posicio_aleatoria_teclat);
            }

            longitud_cua = cua_numeros.Count;

            //Creacio dels butons + adjudicacio dels numeros amb aleatori desde una cua
            using (Font fuente = new Font("Nirmala UI", 16f))
            {
                for (int i = 0; i < longitud_cua; i++)
                {
                    Button btn_panel = new Button();
                    btn_panel.Width = 100;
                    btn_panel.Height = 68;
                    btn_panel.Font = fuente;

                    tbLP_NumerosAleatoris.Controls.Add(btn_panel);
                    btn_panel.Text = cua_numeros.Dequeue();
                    btn_panel.Click += new System.EventHandler(this.btns_Click);
                }
            }

            int contador = 0;

            //bucle per la creacio de els numeros vinculats a les coordenades
            while(contador < LletrasNumeros.Count)
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
                    funcionsBSDD.Executa("INSERT INTO AdminCoordinates(Coordinate, ValueCoord) VALUES('" + LletrasNumeros[contador] + "', '" + num_aleatori_pass + "')");
                    contador++;
                }
            }

            if (coordenades.ContainsKey(lb_LLetraNumero.Text))
            {
                lb_password.Text = coordenades[lb_LLetraNumero.Text];
            }
        }

        int numero_digits = 0;

        //Metode per escriure el valor del boto clicat a el textBox de password (tb_password)
        private void btns_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(numero_digits < 4)
            {
                tb_password.Enabled = false;
                tb_password.Text += btn.Text;
                numero_digits++;
            }  
        }

        //Metode per esborrar els valors de tb_password quan cliquin al boto amb la lletra C
        private void btn_c_Click(object sender, EventArgs e)
        {
            tb_password.Clear();
            numero_digits = 0;
        }

        //Metode per validar les dades fent comparacions i en cas de ser correctes obrir el formulari d'administracio
        private void btn_hashtag_Click(object sender, EventArgs e)
        {
            if(tb_password.Text == coordenades[lb_LLetraNumero.Text])
            {
                form_PaginaAdministracio fmPA = new form_PaginaAdministracio();
                fmPA.Show();
                this.Hide();
            }
            else
            {
                tb_password.Clear();
                numero_digits = 0;
            }
        }
    }
}