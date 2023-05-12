namespace NcapaPresentacion
{
    partial class FrmUsuario_Empresa
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
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnAtrasE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.BackColor = System.Drawing.Color.Green;
            this.btnEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmpresa.Location = new System.Drawing.Point(185, 118);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(154, 55);
            this.btnEmpresa.TabIndex = 0;
            this.btnEmpresa.Text = "EMPRESA";
            this.btnEmpresa.UseVisualStyleBackColor = false;
            this.btnEmpresa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.Green;
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsuario.Location = new System.Drawing.Point(185, 281);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(154, 55);
            this.btnUsuario.TabIndex = 2;
            this.btnUsuario.Text = "PERSONA";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnAtrasE
            // 
            this.btnAtrasE.BackColor = System.Drawing.Color.Green;
            this.btnAtrasE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAtrasE.Location = new System.Drawing.Point(24, 384);
            this.btnAtrasE.Name = "btnAtrasE";
            this.btnAtrasE.Size = new System.Drawing.Size(92, 41);
            this.btnAtrasE.TabIndex = 26;
            this.btnAtrasE.Text = "Atras";
            this.btnAtrasE.UseVisualStyleBackColor = false;
            this.btnAtrasE.Click += new System.EventHandler(this.btnAtrasE_Click);
            // 
            // FrmUsuario_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NcapaPresentacion.Properties.Resources.Diseno_sin_titulo_21;
            this.ClientSize = new System.Drawing.Size(530, 459);
            this.Controls.Add(this.btnAtrasE);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnEmpresa);
            this.Name = "FrmUsuario_Empresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsuario_Empresa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnAtrasE;
    }
}