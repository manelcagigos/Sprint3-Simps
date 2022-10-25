
namespace MESSI
{
    partial class form_PantallaCarrega
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_PantallaCarrega));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer_PantallaCarrega = new System.Windows.Forms.Timer(this.components);
            this.pbSplashCarrega = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSplashCarrega)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 346);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 14);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "BENVINGUT A LA DARK SITE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(0, 346);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(17, 14);
            this.panel2.TabIndex = 3;
            // 
            // timer_PantallaCarrega
            // 
            this.timer_PantallaCarrega.Enabled = true;
            this.timer_PantallaCarrega.Interval = 38;
            this.timer_PantallaCarrega.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbSplashCarrega
            // 
            this.pbSplashCarrega.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSplashCarrega.Image = ((System.Drawing.Image)(resources.GetObject("pbSplashCarrega.Image")));
            this.pbSplashCarrega.Location = new System.Drawing.Point(0, 0);
            this.pbSplashCarrega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSplashCarrega.Name = "pbSplashCarrega";
            this.pbSplashCarrega.Size = new System.Drawing.Size(711, 360);
            this.pbSplashCarrega.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSplashCarrega.TabIndex = 0;
            this.pbSplashCarrega.TabStop = false;
            // 
            // form_PantallaCarrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbSplashCarrega);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_PantallaCarrega";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formPantallaCarrega_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbSplashCarrega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer_PantallaCarrega;
        private System.Windows.Forms.PictureBox pbSplashCarrega;
    }
}

