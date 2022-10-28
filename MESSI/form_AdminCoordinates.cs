﻿using System;
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
    public partial class form_AdminCoordinates : Form
    {
        public form_AdminCoordinates()
        {
            InitializeComponent();
        }

        private void form_AdminCoordinates_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            Random R = new Random();

            List<String> LletrasNumeros = new List<string>();
            List<String> numeros_teclat = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Queue<String> cua_numeros = new Queue<string>();

            //coordenades.Add("A1", "1234");
            //tb_password.Text = coordenades["A1"];

            string LletraNumero, num_aleatori_pass;
            int longitud, posicio_aleatoria, posicio_aleatoria_teclat, longitud_cua;

            LletraNumero = "";
            posicio_aleatoria_teclat = 0;

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

            //longitud_cua = cua_numeros.Count;

            //Creacio dels butons + adjudicacio dels numeros amb aleatori desde una cua
            //using (Font fuente = new Font("Nirmala UI", 16f))
            //{
            //    for (int i = 0; i < longitud_cua; i++)
            //    {
            //        TextBox txt_panel = new TextBox();
            //        txt_panel.Width = 100;
            //        txt_panel.Height = 68;
            //        txt_panel.Font = fuente;

            //        tbLP_NumerosAleatoris.Controls.Add(txt_panel);
            //        btn_panel.Text = cua_numeros.Dequeue();
            //        btn_panel.Click += new System.EventHandler(this.btns_Click);
            //    }
            //}

            int contador = 0;

            //bucle per la creacio de els numeros vinculats a les coordenades
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

            if (coordenades.ContainsKey(lb_LLetraNumero.Text))
            {
                lb_password.Text = coordenades[lb_LLetraNumero.Text];
            }
        }
    }
}
