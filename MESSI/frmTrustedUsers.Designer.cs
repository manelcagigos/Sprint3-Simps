
namespace MESSI
{
    partial class frmTrustedUsers
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
            this.lbComboBox = new System.Windows.Forms.Label();
            this.combUser = new System.Windows.Forms.ComboBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.btCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbComboBox
            // 
            this.lbComboBox.AutoSize = true;
            this.lbComboBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComboBox.Location = new System.Drawing.Point(40, 26);
            this.lbComboBox.Name = "lbComboBox";
            this.lbComboBox.Size = new System.Drawing.Size(66, 32);
            this.lbComboBox.TabIndex = 0;
            this.lbComboBox.Text = "User";
            // 
            // combUser
            // 
            this.combUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combUser.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combUser.FormattingEnabled = true;
            this.combUser.Location = new System.Drawing.Point(124, 26);
            this.combUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combUser.Name = "combUser";
            this.combUser.Size = new System.Drawing.Size(214, 36);
            this.combUser.TabIndex = 1;
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(124, 104);
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(120, 46);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btRegister
            // 
            this.btRegister.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegister.Location = new System.Drawing.Point(264, 104);
            this.btRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(120, 46);
            this.btRegister.TabIndex = 3;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btCheck
            // 
            this.btCheck.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheck.Location = new System.Drawing.Point(400, 104);
            this.btCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(120, 46);
            this.btCheck.TabIndex = 4;
            this.btCheck.Text = "Check";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // frmTrustedUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(760, 178);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.combUser);
            this.Controls.Add(this.lbComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTrustedUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trusted Users";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTrustedUsers_FormClosing);
            this.Load += new System.EventHandler(this.frmTrustedUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbComboBox;
        private System.Windows.Forms.ComboBox combUser;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btCheck;
    }
}