
namespace MESSI
{
    partial class form_PaginaUsuari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_PaginaUsuari));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnMenuSlide = new System.Windows.Forms.PictureBox();
            this.pbLogoEmpresa = new System.Windows.Forms.PictureBox();
            this.menuVertical = new System.Windows.Forms.Panel();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoEmpresa)).BeginInit();
            this.menuVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.Controls.Add(this.btnMenuSlide);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(250, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1050, 50);
            this.barraTitulo.TabIndex = 1;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1050, 600);
            this.panelContenedor.TabIndex = 2;
            // 
            // btnMenuSlide
            // 
            this.btnMenuSlide.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuSlide.Image")));
            this.btnMenuSlide.Location = new System.Drawing.Point(6, 9);
            this.btnMenuSlide.Name = "btnMenuSlide";
            this.btnMenuSlide.Size = new System.Drawing.Size(35, 35);
            this.btnMenuSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenuSlide.TabIndex = 0;
            this.btnMenuSlide.TabStop = false;
            this.btnMenuSlide.Click += new System.EventHandler(this.btnMenuSlide_Click);
            // 
            // pbLogoEmpresa
            // 
            this.pbLogoEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoEmpresa.Image")));
            this.pbLogoEmpresa.Location = new System.Drawing.Point(0, 0);
            this.pbLogoEmpresa.Name = "pbLogoEmpresa";
            this.pbLogoEmpresa.Size = new System.Drawing.Size(250, 98);
            this.pbLogoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoEmpresa.TabIndex = 0;
            this.pbLogoEmpresa.TabStop = false;
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.Red;
            this.menuVertical.Controls.Add(this.pbLogoEmpresa);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(250, 650);
            this.menuVertical.TabIndex = 0;
            // 
            // form_PaginaUsuari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "form_PaginaUsuari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_PaginaUsuari_FormClosing);
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoEmpresa)).EndInit();
            this.menuVertical.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.PictureBox btnMenuSlide;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pbLogoEmpresa;
        private System.Windows.Forms.Panel menuVertical;
    }
}