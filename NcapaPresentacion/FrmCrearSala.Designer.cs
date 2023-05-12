namespace NcapaPresentacion
{
    partial class FrmCrearSala
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtrasE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aquí iria las salas creadas";
            // 
            // btnAtrasE
            // 
            this.btnAtrasE.BackColor = System.Drawing.Color.Green;
            this.btnAtrasE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAtrasE.Location = new System.Drawing.Point(80, 315);
            this.btnAtrasE.Name = "btnAtrasE";
            this.btnAtrasE.Size = new System.Drawing.Size(92, 41);
            this.btnAtrasE.TabIndex = 24;
            this.btnAtrasE.Text = "Atras";
            this.btnAtrasE.UseVisualStyleBackColor = false;
            this.btnAtrasE.Click += new System.EventHandler(this.btnAtrasE_Click);
            // 
            // FrmCrearSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NcapaPresentacion.Properties.Resources.Diseno_sin_titulo_2;
            this.ClientSize = new System.Drawing.Size(490, 389);
            this.Controls.Add(this.btnAtrasE);
            this.Controls.Add(this.label1);
            this.Name = "FrmCrearSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCrearSala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtrasE;
    }
}