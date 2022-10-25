
namespace MESSI
{
    partial class form_ValidacioUsuari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ValidacioUsuari));
            this.pb_circulo = new System.Windows.Forms.PictureBox();
            this.pb_fotoUser = new System.Windows.Forms.PictureBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.pb_user_username = new System.Windows.Forms.PictureBox();
            this.pb_password = new System.Windows.Forms.PictureBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.bt_LogIn = new System.Windows.Forms.Button();
            this.lb_numeroIntents = new System.Windows.Forms.Label();
            this.lb_intents = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_circulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fotoUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_password)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_circulo
            // 
            this.pb_circulo.Image = ((System.Drawing.Image)(resources.GetObject("pb_circulo.Image")));
            this.pb_circulo.Location = new System.Drawing.Point(-1, -1);
            this.pb_circulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_circulo.Name = "pb_circulo";
            this.pb_circulo.Size = new System.Drawing.Size(322, 339);
            this.pb_circulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_circulo.TabIndex = 0;
            this.pb_circulo.TabStop = false;
            // 
            // pb_fotoUser
            // 
            this.pb_fotoUser.BackColor = System.Drawing.Color.White;
            this.pb_fotoUser.Image = ((System.Drawing.Image)(resources.GetObject("pb_fotoUser.Image")));
            this.pb_fotoUser.Location = new System.Drawing.Point(74, 66);
            this.pb_fotoUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_fotoUser.Name = "pb_fotoUser";
            this.pb_fotoUser.Size = new System.Drawing.Size(172, 208);
            this.pb_fotoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_fotoUser.TabIndex = 1;
            this.pb_fotoUser.TabStop = false;
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(98, 362);
            this.tb_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_username.MaxLength = 1000;
            this.tb_username.Multiline = true;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(175, 54);
            this.tb_username.TabIndex = 2;
            this.tb_username.Text = "Username";
            // 
            // pb_user_username
            // 
            this.pb_user_username.BackColor = System.Drawing.Color.Silver;
            this.pb_user_username.Image = ((System.Drawing.Image)(resources.GetObject("pb_user_username.Image")));
            this.pb_user_username.Location = new System.Drawing.Point(46, 362);
            this.pb_user_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_user_username.Name = "pb_user_username";
            this.pb_user_username.Size = new System.Drawing.Size(54, 55);
            this.pb_user_username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_user_username.TabIndex = 3;
            this.pb_user_username.TabStop = false;
            // 
            // pb_password
            // 
            this.pb_password.BackColor = System.Drawing.Color.Silver;
            this.pb_password.Image = ((System.Drawing.Image)(resources.GetObject("pb_password.Image")));
            this.pb_password.Location = new System.Drawing.Point(46, 445);
            this.pb_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_password.Name = "pb_password";
            this.pb_password.Size = new System.Drawing.Size(54, 55);
            this.pb_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_password.TabIndex = 4;
            this.pb_password.TabStop = false;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(98, 445);
            this.tb_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_password.MaxLength = 11;
            this.tb_password.Multiline = true;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(175, 54);
            this.tb_password.TabIndex = 5;
            this.tb_password.Text = "Password";
            // 
            // bt_LogIn
            // 
            this.bt_LogIn.BackColor = System.Drawing.Color.Red;
            this.bt_LogIn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LogIn.Location = new System.Drawing.Point(107, 537);
            this.bt_LogIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_LogIn.Name = "bt_LogIn";
            this.bt_LogIn.Size = new System.Drawing.Size(127, 71);
            this.bt_LogIn.TabIndex = 6;
            this.bt_LogIn.Text = "LOG IN";
            this.bt_LogIn.UseVisualStyleBackColor = false;
            this.bt_LogIn.Click += new System.EventHandler(this.bt_LogIn_Click);
            // 
            // lb_numeroIntents
            // 
            this.lb_numeroIntents.AutoSize = true;
            this.lb_numeroIntents.Location = new System.Drawing.Point(103, 643);
            this.lb_numeroIntents.Name = "lb_numeroIntents";
            this.lb_numeroIntents.Size = new System.Drawing.Size(123, 20);
            this.lb_numeroIntents.TabIndex = 7;
            this.lb_numeroIntents.Text = "Numero Intents:";
            // 
            // lb_intents
            // 
            this.lb_intents.AutoSize = true;
            this.lb_intents.Location = new System.Drawing.Point(226, 642);
            this.lb_intents.Name = "lb_intents";
            this.lb_intents.Size = new System.Drawing.Size(18, 20);
            this.lb_intents.TabIndex = 8;
            this.lb_intents.Text = "3";
            // 
            // form_ValidacioUsuari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(321, 689);
            this.Controls.Add(this.lb_intents);
            this.Controls.Add(this.lb_numeroIntents);
            this.Controls.Add(this.bt_LogIn);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.pb_password);
            this.Controls.Add(this.pb_user_username);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.pb_fotoUser);
            this.Controls.Add(this.pb_circulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_ValidacioUsuari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pb_circulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fotoUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_circulo;
        private System.Windows.Forms.PictureBox pb_fotoUser;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.PictureBox pb_user_username;
        private System.Windows.Forms.PictureBox pb_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button bt_LogIn;
        private System.Windows.Forms.Label lb_numeroIntents;
        private System.Windows.Forms.Label lb_intents;
    }
}