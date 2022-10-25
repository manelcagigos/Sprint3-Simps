
namespace MESSI
{
    partial class form_ValidacioAdmin
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
            this.lb_MESSIadmin = new System.Windows.Forms.Label();
            this.lb_LLetraNumero = new System.Windows.Forms.Label();
            this.tbLP_NumerosAleatoris = new System.Windows.Forms.TableLayoutPanel();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_hashtag = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.tbLP_NumerosAleatoris.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_MESSIadmin
            // 
            this.lb_MESSIadmin.AutoSize = true;
            this.lb_MESSIadmin.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MESSIadmin.Location = new System.Drawing.Point(24, 29);
            this.lb_MESSIadmin.Name = "lb_MESSIadmin";
            this.lb_MESSIadmin.Size = new System.Drawing.Size(405, 54);
            this.lb_MESSIadmin.TabIndex = 0;
            this.lb_MESSIadmin.Text = "MESSI Administration";
            // 
            // lb_LLetraNumero
            // 
            this.lb_LLetraNumero.AutoSize = true;
            this.lb_LLetraNumero.Font = new System.Drawing.Font("Nirmala UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LLetraNumero.ForeColor = System.Drawing.Color.Red;
            this.lb_LLetraNumero.Location = new System.Drawing.Point(163, 104);
            this.lb_LLetraNumero.Name = "lb_LLetraNumero";
            this.lb_LLetraNumero.Size = new System.Drawing.Size(99, 76);
            this.lb_LLetraNumero.TabIndex = 1;
            this.lb_LLetraNumero.Text = "C5";
            // 
            // tbLP_NumerosAleatoris
            // 
            this.tbLP_NumerosAleatoris.BackColor = System.Drawing.Color.White;
            this.tbLP_NumerosAleatoris.ColumnCount = 3;
            this.tbLP_NumerosAleatoris.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.58491F));
            this.tbLP_NumerosAleatoris.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.41509F));
            this.tbLP_NumerosAleatoris.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tbLP_NumerosAleatoris.Controls.Add(this.btn_c, 0, 3);
            this.tbLP_NumerosAleatoris.Controls.Add(this.btn_hashtag, 2, 3);
            this.tbLP_NumerosAleatoris.Location = new System.Drawing.Point(27, 206);
            this.tbLP_NumerosAleatoris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLP_NumerosAleatoris.Name = "tbLP_NumerosAleatoris";
            this.tbLP_NumerosAleatoris.RowCount = 4;
            this.tbLP_NumerosAleatoris.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLP_NumerosAleatoris.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLP_NumerosAleatoris.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tbLP_NumerosAleatoris.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tbLP_NumerosAleatoris.Size = new System.Drawing.Size(367, 378);
            this.tbLP_NumerosAleatoris.TabIndex = 2;
            // 
            // btn_c
            // 
            this.btn_c.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_c.Location = new System.Drawing.Point(3, 290);
            this.btn_c.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(112, 84);
            this.btn_c.TabIndex = 0;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_hashtag
            // 
            this.btn_hashtag.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hashtag.Location = new System.Drawing.Point(247, 290);
            this.btn_hashtag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_hashtag.Name = "btn_hashtag";
            this.btn_hashtag.Size = new System.Drawing.Size(114, 84);
            this.btn_hashtag.TabIndex = 1;
            this.btn_hashtag.Text = "#";
            this.btn_hashtag.UseVisualStyleBackColor = true;
            this.btn_hashtag.Click += new System.EventHandler(this.btn_hashtag_Click);
            // 
            // tb_password
            // 
            this.tb_password.Enabled = false;
            this.tb_password.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(138, 620);
            this.tb_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_password.MaxLength = 4;
            this.tb_password.Multiline = true;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(146, 54);
            this.tb_password.TabIndex = 3;
            this.tb_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(349, 584);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(45, 20);
            this.lb_password.TabIndex = 4;
            this.lb_password.Text = "1234";
            // 
            // form_ValidacioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(423, 710);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tbLP_NumerosAleatoris);
            this.Controls.Add(this.lb_LLetraNumero);
            this.Controls.Add(this.lb_MESSIadmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_ValidacioAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.form_ValidacioAdmin_Load);
            this.tbLP_NumerosAleatoris.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_MESSIadmin;
        private System.Windows.Forms.Label lb_LLetraNumero;
        private System.Windows.Forms.TableLayoutPanel tbLP_NumerosAleatoris;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_hashtag;
        private System.Windows.Forms.Label lb_password;
    }
}