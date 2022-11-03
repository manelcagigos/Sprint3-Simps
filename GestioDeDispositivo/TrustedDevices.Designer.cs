
namespace GestioDeDispositivo
{
    partial class TrustedDevices
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
            this.lbMac = new System.Windows.Forms.Label();
            this.lbHost = new System.Windows.Forms.Label();
            this.bntSave = new System.Windows.Forms.Button();
            this.bntDel = new System.Windows.Forms.Button();
            this.txtMac = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbMac
            // 
            this.lbMac.AutoSize = true;
            this.lbMac.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMac.Location = new System.Drawing.Point(49, 46);
            this.lbMac.Name = "lbMac";
            this.lbMac.Size = new System.Drawing.Size(53, 21);
            this.lbMac.TabIndex = 0;
            this.lbMac.Text = "M.A.C.";
            // 
            // lbHost
            // 
            this.lbHost.AutoSize = true;
            this.lbHost.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHost.Location = new System.Drawing.Point(49, 89);
            this.lbHost.Name = "lbHost";
            this.lbHost.Size = new System.Drawing.Size(84, 21);
            this.lbHost.TabIndex = 1;
            this.lbHost.Text = "HostName";
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(53, 141);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(105, 33);
            this.bntSave.TabIndex = 2;
            this.bntSave.Text = "Save";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // bntDel
            // 
            this.bntDel.Location = new System.Drawing.Point(165, 141);
            this.bntDel.Name = "bntDel";
            this.bntDel.Size = new System.Drawing.Size(105, 33);
            this.bntDel.TabIndex = 3;
            this.bntDel.Text = "Delete";
            this.bntDel.UseVisualStyleBackColor = true;
            this.bntDel.Click += new System.EventHandler(this.bntDel_Click);
            // 
            // txtMac
            // 
            this.txtMac.Enabled = false;
            this.txtMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMac.Location = new System.Drawing.Point(165, 47);
            this.txtMac.Name = "txtMac";
            this.txtMac.Size = new System.Drawing.Size(165, 20);
            this.txtMac.TabIndex = 4;
            // 
            // txtHost
            // 
            this.txtHost.Enabled = false;
            this.txtHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHost.Location = new System.Drawing.Point(165, 90);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(212, 20);
            this.txtHost.TabIndex = 5;
            // 
            // TrustedDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(608, 203);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.txtMac);
            this.Controls.Add(this.bntDel);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.lbHost);
            this.Controls.Add(this.lbMac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TrustedDevices";
            this.Text = "Trusted Devices";
            this.Load += new System.EventHandler(this.TrustedDevices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMac;
        private System.Windows.Forms.Label lbHost;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.Button bntDel;
        private System.Windows.Forms.TextBox txtMac;
        private System.Windows.Forms.TextBox txtHost;
    }
}

