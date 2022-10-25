
namespace MESSI
{
    partial class form_PaginaAdministracio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnael_superior = new System.Windows.Forms.Panel();
            this.lb_capçalera = new System.Windows.Forms.Label();
            this.bt_regeneracioCoors = new System.Windows.Forms.Button();
            this.bt_GestioDispositiu = new System.Windows.Forms.Button();
            this.bt_GestioUsuaris = new System.Windows.Forms.Button();
            this.pnael_superior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnael_superior
            // 
            this.pnael_superior.BackColor = System.Drawing.Color.Black;
            this.pnael_superior.Controls.Add(this.lb_capçalera);
            this.pnael_superior.Location = new System.Drawing.Point(-2, 0);
            this.pnael_superior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnael_superior.Name = "pnael_superior";
            this.pnael_superior.Size = new System.Drawing.Size(903, 85);
            this.pnael_superior.TabIndex = 0;
            // 
            // lb_capçalera
            // 
            this.lb_capçalera.AutoSize = true;
            this.lb_capçalera.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_capçalera.ForeColor = System.Drawing.Color.Silver;
            this.lb_capçalera.Location = new System.Drawing.Point(193, 9);
            this.lb_capçalera.Name = "lb_capçalera";
            this.lb_capçalera.Size = new System.Drawing.Size(529, 65);
            this.lb_capçalera.TabIndex = 1;
            this.lb_capçalera.Text = "Administració de MESSI";
            // 
            // bt_regeneracioCoors
            // 
            this.bt_regeneracioCoors.BackColor = System.Drawing.Color.White;
            this.bt_regeneracioCoors.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_regeneracioCoors.Location = new System.Drawing.Point(91, 265);
            this.bt_regeneracioCoors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_regeneracioCoors.Name = "bt_regeneracioCoors";
            this.bt_regeneracioCoors.Size = new System.Drawing.Size(222, 128);
            this.bt_regeneracioCoors.TabIndex = 0;
            this.bt_regeneracioCoors.Text = "Regeneració de Coordenades";
            this.bt_regeneracioCoors.UseVisualStyleBackColor = false;
            // 
            // bt_GestioDispositiu
            // 
            this.bt_GestioDispositiu.BackColor = System.Drawing.Color.White;
            this.bt_GestioDispositiu.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GestioDispositiu.Location = new System.Drawing.Point(336, 265);
            this.bt_GestioDispositiu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_GestioDispositiu.Name = "bt_GestioDispositiu";
            this.bt_GestioDispositiu.Size = new System.Drawing.Size(222, 128);
            this.bt_GestioDispositiu.TabIndex = 3;
            this.bt_GestioDispositiu.Text = "Gestió de dispositius";
            this.bt_GestioDispositiu.UseVisualStyleBackColor = false;
            // 
            // bt_GestioUsuaris
            // 
            this.bt_GestioUsuaris.BackColor = System.Drawing.Color.White;
            this.bt_GestioUsuaris.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GestioUsuaris.Location = new System.Drawing.Point(582, 265);
            this.bt_GestioUsuaris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_GestioUsuaris.Name = "bt_GestioUsuaris";
            this.bt_GestioUsuaris.Size = new System.Drawing.Size(222, 128);
            this.bt_GestioUsuaris.TabIndex = 4;
            this.bt_GestioUsuaris.Text = "Gestió d\'usuaris";
            this.bt_GestioUsuaris.UseVisualStyleBackColor = false;
            // 
            // form_PaginaAdministracio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.bt_GestioUsuaris);
            this.Controls.Add(this.bt_GestioDispositiu);
            this.Controls.Add(this.pnael_superior);
            this.Controls.Add(this.bt_regeneracioCoors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "form_PaginaAdministracio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_PaginaAdministracio_FormClosing);
            this.pnael_superior.ResumeLayout(false);
            this.pnael_superior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnael_superior;
        private System.Windows.Forms.Label lb_capçalera;
        private System.Windows.Forms.Button bt_regeneracioCoors;
        private System.Windows.Forms.Button bt_GestioDispositiu;
        private System.Windows.Forms.Button bt_GestioUsuaris;
    }
}