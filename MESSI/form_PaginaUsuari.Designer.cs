
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
            this.panel_superior = new System.Windows.Forms.Panel();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_messi = new System.Windows.Forms.Label();
            this.bt_opcio1 = new System.Windows.Forms.Button();
            this.bt_opcio2 = new System.Windows.Forms.Button();
            this.bt_opcio3 = new System.Windows.Forms.Button();
            this.bt_opcio4 = new System.Windows.Forms.Button();
            this.panel_superior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_superior
            // 
            this.panel_superior.BackColor = System.Drawing.Color.Red;
            this.panel_superior.Controls.Add(this.lb_username);
            this.panel_superior.Controls.Add(this.lb_messi);
            this.panel_superior.Location = new System.Drawing.Point(-1, 0);
            this.panel_superior.Name = "panel_superior";
            this.panel_superior.Size = new System.Drawing.Size(801, 39);
            this.panel_superior.TabIndex = 0;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.BackColor = System.Drawing.Color.Red;
            this.lb_username.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(661, 3);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(137, 32);
            this.lb_username.TabIndex = 1;
            this.lb_username.Text = "USERNAME";
            // 
            // lb_messi
            // 
            this.lb_messi.AutoSize = true;
            this.lb_messi.BackColor = System.Drawing.Color.Red;
            this.lb_messi.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_messi.Location = new System.Drawing.Point(3, 3);
            this.lb_messi.Name = "lb_messi";
            this.lb_messi.Size = new System.Drawing.Size(81, 32);
            this.lb_messi.TabIndex = 0;
            this.lb_messi.Text = "MESSI";
            // 
            // bt_opcio1
            // 
            this.bt_opcio1.BackColor = System.Drawing.Color.White;
            this.bt_opcio1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_opcio1.ForeColor = System.Drawing.Color.Black;
            this.bt_opcio1.Location = new System.Drawing.Point(-1, 39);
            this.bt_opcio1.Name = "bt_opcio1";
            this.bt_opcio1.Size = new System.Drawing.Size(154, 89);
            this.bt_opcio1.TabIndex = 1;
            this.bt_opcio1.Text = "Opció 1";
            this.bt_opcio1.UseVisualStyleBackColor = false;
            // 
            // bt_opcio2
            // 
            this.bt_opcio2.BackColor = System.Drawing.Color.White;
            this.bt_opcio2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_opcio2.ForeColor = System.Drawing.Color.Black;
            this.bt_opcio2.Location = new System.Drawing.Point(-1, 122);
            this.bt_opcio2.Name = "bt_opcio2";
            this.bt_opcio2.Size = new System.Drawing.Size(154, 89);
            this.bt_opcio2.TabIndex = 2;
            this.bt_opcio2.Text = "Opció 2";
            this.bt_opcio2.UseVisualStyleBackColor = false;
            // 
            // bt_opcio3
            // 
            this.bt_opcio3.BackColor = System.Drawing.Color.White;
            this.bt_opcio3.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_opcio3.ForeColor = System.Drawing.Color.Black;
            this.bt_opcio3.Location = new System.Drawing.Point(-1, 208);
            this.bt_opcio3.Name = "bt_opcio3";
            this.bt_opcio3.Size = new System.Drawing.Size(154, 89);
            this.bt_opcio3.TabIndex = 3;
            this.bt_opcio3.Text = "Opció 3";
            this.bt_opcio3.UseVisualStyleBackColor = false;
            // 
            // bt_opcio4
            // 
            this.bt_opcio4.BackColor = System.Drawing.Color.White;
            this.bt_opcio4.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_opcio4.ForeColor = System.Drawing.Color.Black;
            this.bt_opcio4.Location = new System.Drawing.Point(-1, 292);
            this.bt_opcio4.Name = "bt_opcio4";
            this.bt_opcio4.Size = new System.Drawing.Size(154, 89);
            this.bt_opcio4.TabIndex = 4;
            this.bt_opcio4.Text = "Opció 4";
            this.bt_opcio4.UseVisualStyleBackColor = false;
            // 
            // form_PaginaUsuari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 379);
            this.Controls.Add(this.bt_opcio4);
            this.Controls.Add(this.bt_opcio3);
            this.Controls.Add(this.bt_opcio2);
            this.Controls.Add(this.bt_opcio1);
            this.Controls.Add(this.panel_superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_PaginaUsuari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_PaginaUsuari_FormClosing);
            this.panel_superior.ResumeLayout(false);
            this.panel_superior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_superior;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_messi;
        private System.Windows.Forms.Button bt_opcio1;
        private System.Windows.Forms.Button bt_opcio2;
        private System.Windows.Forms.Button bt_opcio3;
        private System.Windows.Forms.Button bt_opcio4;
    }
}