
namespace MESSI
{
    partial class form_AdminCoordinates
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
            this.panelBarraSuperior = new System.Windows.Forms.Panel();
            this.btGenerate = new System.Windows.Forms.Button();
            this.btShow = new System.Windows.Forms.Button();
            this.tlpCoordinates = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBarraSuperior.SuspendLayout();
            this.tlpCoordinates.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarraSuperior
            // 
            this.panelBarraSuperior.BackColor = System.Drawing.Color.Black;
            this.panelBarraSuperior.Controls.Add(this.btShow);
            this.panelBarraSuperior.Controls.Add(this.btGenerate);
            this.panelBarraSuperior.Location = new System.Drawing.Point(-2, 0);
            this.panelBarraSuperior.Name = "panelBarraSuperior";
            this.panelBarraSuperior.Size = new System.Drawing.Size(802, 100);
            this.panelBarraSuperior.TabIndex = 0;
            // 
            // btGenerate
            // 
            this.btGenerate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenerate.Location = new System.Drawing.Point(50, 21);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(125, 60);
            this.btGenerate.TabIndex = 0;
            this.btGenerate.Text = "Generate";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // btShow
            // 
            this.btShow.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShow.Location = new System.Drawing.Point(221, 21);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(125, 60);
            this.btShow.TabIndex = 1;
            this.btShow.Text = "Show";
            this.btShow.UseVisualStyleBackColor = true;
            // 
            // tlpCoordinates
            // 
            this.tlpCoordinates.ColumnCount = 6;
            this.tlpCoordinates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCoordinates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCoordinates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tlpCoordinates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpCoordinates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tlpCoordinates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tlpCoordinates.Controls.Add(this.label1, 1, 0);
            this.tlpCoordinates.Location = new System.Drawing.Point(48, 134);
            this.tlpCoordinates.Name = "tlpCoordinates";
            this.tlpCoordinates.RowCount = 5;
            this.tlpCoordinates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.59406F));
            this.tlpCoordinates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.40594F));
            this.tlpCoordinates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlpCoordinates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpCoordinates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tlpCoordinates.Size = new System.Drawing.Size(716, 304);
            this.tlpCoordinates.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // form_AdminCoordinates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpCoordinates);
            this.Controls.Add(this.panelBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_AdminCoordinates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Coordinates";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_AdminCoordinates_FormClosing);
            this.panelBarraSuperior.ResumeLayout(false);
            this.tlpCoordinates.ResumeLayout(false);
            this.tlpCoordinates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraSuperior;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.TableLayoutPanel tlpCoordinates;
        private System.Windows.Forms.Label label1;
    }
}