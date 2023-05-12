namespace NcapaPresentacion
{
    partial class FrmEmpresa
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
            this.txtTelefonoEm = new System.Windows.Forms.TextBox();
            this.txtEmailEm = new System.Windows.Forms.TextBox();
            this.txtApellidoNombre = new System.Windows.Forms.TextBox();
            this.txtContraEm = new System.Windows.Forms.TextBox();
            this.txtCuitEm = new System.Windows.Forms.TextBox();
            this.cboRoless = new System.Windows.Forms.ComboBox();
            this.btnSiguienteE = new System.Windows.Forms.Button();
            this.btnAtrasE = new System.Windows.Forms.Button();
            this.btnAgregarE = new System.Windows.Forms.Button();
            this.txtUbicacionEm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTelefonoEm
            // 
            this.txtTelefonoEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoEm.Location = new System.Drawing.Point(183, 170);
            this.txtTelefonoEm.Name = "txtTelefonoEm";
            this.txtTelefonoEm.Size = new System.Drawing.Size(140, 22);
            this.txtTelefonoEm.TabIndex = 5;
            // 
            // txtEmailEm
            // 
            this.txtEmailEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailEm.Location = new System.Drawing.Point(183, 126);
            this.txtEmailEm.Name = "txtEmailEm";
            this.txtEmailEm.Size = new System.Drawing.Size(140, 22);
            this.txtEmailEm.TabIndex = 7;
            // 
            // txtApellidoNombre
            // 
            this.txtApellidoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoNombre.Location = new System.Drawing.Point(183, 34);
            this.txtApellidoNombre.Name = "txtApellidoNombre";
            this.txtApellidoNombre.Size = new System.Drawing.Size(140, 22);
            this.txtApellidoNombre.TabIndex = 8;
            // 
            // txtContraEm
            // 
            this.txtContraEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraEm.Location = new System.Drawing.Point(183, 78);
            this.txtContraEm.Name = "txtContraEm";
            this.txtContraEm.PasswordChar = '*';
            this.txtContraEm.Size = new System.Drawing.Size(140, 22);
            this.txtContraEm.TabIndex = 9;
            // 
            // txtCuitEm
            // 
            this.txtCuitEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuitEm.Location = new System.Drawing.Point(183, 222);
            this.txtCuitEm.Name = "txtCuitEm";
            this.txtCuitEm.Size = new System.Drawing.Size(140, 22);
            this.txtCuitEm.TabIndex = 10;
            // 
            // cboRoless
            // 
            this.cboRoless.FormattingEnabled = true;
            this.cboRoless.Location = new System.Drawing.Point(183, 314);
            this.cboRoless.Name = "cboRoless";
            this.cboRoless.Size = new System.Drawing.Size(140, 21);
            this.cboRoless.TabIndex = 11;
            // 
            // btnSiguienteE
            // 
            this.btnSiguienteE.BackColor = System.Drawing.Color.Green;
            this.btnSiguienteE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSiguienteE.Location = new System.Drawing.Point(319, 405);
            this.btnSiguienteE.Name = "btnSiguienteE";
            this.btnSiguienteE.Size = new System.Drawing.Size(92, 41);
            this.btnSiguienteE.TabIndex = 14;
            this.btnSiguienteE.Text = "Siguiente";
            this.btnSiguienteE.UseVisualStyleBackColor = false;
            this.btnSiguienteE.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAtrasE
            // 
            this.btnAtrasE.BackColor = System.Drawing.Color.Green;
            this.btnAtrasE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAtrasE.Location = new System.Drawing.Point(81, 405);
            this.btnAtrasE.Name = "btnAtrasE";
            this.btnAtrasE.Size = new System.Drawing.Size(92, 41);
            this.btnAtrasE.TabIndex = 22;
            this.btnAtrasE.Text = "Atras";
            this.btnAtrasE.UseVisualStyleBackColor = false;
            this.btnAtrasE.Click += new System.EventHandler(this.btnAtrasE_Click);
            // 
            // btnAgregarE
            // 
            this.btnAgregarE.BackColor = System.Drawing.Color.Green;
            this.btnAgregarE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarE.Location = new System.Drawing.Point(141, 356);
            this.btnAgregarE.Name = "btnAgregarE";
            this.btnAgregarE.Size = new System.Drawing.Size(223, 30);
            this.btnAgregarE.TabIndex = 23;
            this.btnAgregarE.Text = "Agregar";
            this.btnAgregarE.UseVisualStyleBackColor = false;
            this.btnAgregarE.Click += new System.EventHandler(this.btnAgregarE_Click);
            // 
            // txtUbicacionEm
            // 
            this.txtUbicacionEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicacionEm.Location = new System.Drawing.Point(183, 268);
            this.txtUbicacionEm.Name = "txtUbicacionEm";
            this.txtUbicacionEm.Size = new System.Drawing.Size(140, 22);
            this.txtUbicacionEm.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(67, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Apellido y Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(67, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(67, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Correo Electronico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(67, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(67, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(67, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "CUIT";
            // 
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NcapaPresentacion.Properties.Resources.BORCELLE_1;
            this.ClientSize = new System.Drawing.Size(518, 458);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUbicacionEm);
            this.Controls.Add(this.btnAgregarE);
            this.Controls.Add(this.btnAtrasE);
            this.Controls.Add(this.btnSiguienteE);
            this.Controls.Add(this.cboRoless);
            this.Controls.Add(this.txtCuitEm);
            this.Controls.Add(this.txtContraEm);
            this.Controls.Add(this.txtApellidoNombre);
            this.Controls.Add(this.txtEmailEm);
            this.Controls.Add(this.txtTelefonoEm);
            this.Name = "FrmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmpresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTelefonoEm;
        private System.Windows.Forms.TextBox txtEmailEm;
        private System.Windows.Forms.TextBox txtApellidoNombre;
        private System.Windows.Forms.TextBox txtContraEm;
        private System.Windows.Forms.TextBox txtCuitEm;
        private System.Windows.Forms.ComboBox cboRoless;
        private System.Windows.Forms.Button btnSiguienteE;
        private System.Windows.Forms.Button btnAtrasE;
        private System.Windows.Forms.Button btnAgregarE;
        private System.Windows.Forms.TextBox txtUbicacionEm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}