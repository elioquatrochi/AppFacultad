namespace NcapaPresentacion
{
    partial class FrmByCSala
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
            this.btnCrearS = new System.Windows.Forms.Button();
            this.btnBuscarS = new System.Windows.Forms.Button();
            this.btnAtrasE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearS
            // 
            this.btnCrearS.BackColor = System.Drawing.Color.Green;
            this.btnCrearS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrearS.Location = new System.Drawing.Point(170, 82);
            this.btnCrearS.Name = "btnCrearS";
            this.btnCrearS.Size = new System.Drawing.Size(154, 55);
            this.btnCrearS.TabIndex = 1;
            this.btnCrearS.Text = "CREAR SALA";
            this.btnCrearS.UseVisualStyleBackColor = false;
            this.btnCrearS.Click += new System.EventHandler(this.btnCrearS_Click);
            // 
            // btnBuscarS
            // 
            this.btnBuscarS.BackColor = System.Drawing.Color.Green;
            this.btnBuscarS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarS.Location = new System.Drawing.Point(170, 237);
            this.btnBuscarS.Name = "btnBuscarS";
            this.btnBuscarS.Size = new System.Drawing.Size(154, 55);
            this.btnBuscarS.TabIndex = 3;
            this.btnBuscarS.Text = "BUSCAR SALA";
            this.btnBuscarS.UseVisualStyleBackColor = false;
            this.btnBuscarS.Click += new System.EventHandler(this.btnBuscarS_Click);
            // 
            // btnAtrasE
            // 
            this.btnAtrasE.BackColor = System.Drawing.Color.Green;
            this.btnAtrasE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAtrasE.Location = new System.Drawing.Point(35, 357);
            this.btnAtrasE.Name = "btnAtrasE";
            this.btnAtrasE.Size = new System.Drawing.Size(92, 41);
            this.btnAtrasE.TabIndex = 25;
            this.btnAtrasE.Text = "Atras";
            this.btnAtrasE.UseVisualStyleBackColor = false;
            this.btnAtrasE.Click += new System.EventHandler(this.btnAtrasE_Click);
            // 
            // FrmByCSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NcapaPresentacion.Properties.Resources.Diseno_sin_titulo_2;
            this.ClientSize = new System.Drawing.Size(513, 429);
            this.Controls.Add(this.btnAtrasE);
            this.Controls.Add(this.btnBuscarS);
            this.Controls.Add(this.btnCrearS);
            this.Name = "FrmByCSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmByCSala";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearS;
        private System.Windows.Forms.Button btnBuscarS;
        private System.Windows.Forms.Button btnAtrasE;
    }
}