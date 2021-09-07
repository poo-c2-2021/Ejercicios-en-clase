
namespace HeroeApp
{
    partial class FrmHereo
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPoder = new System.Windows.Forms.Label();
            this.numNivelFuerza = new System.Windows.Forms.NumericUpDown();
            this.lblNivelFuerza = new System.Windows.Forms.Label();
            this.lblEsAyudante = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.chkEsAyudante = new System.Windows.Forms.CheckBox();
            this.cmbPoder = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNivelFuerza)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPoder
            // 
            this.lblPoder.AutoSize = true;
            this.lblPoder.Location = new System.Drawing.Point(23, 78);
            this.lblPoder.Name = "lblPoder";
            this.lblPoder.Size = new System.Drawing.Size(38, 15);
            this.lblPoder.TabIndex = 1;
            this.lblPoder.Text = "Poder";
            // 
            // numNivelFuerza
            // 
            this.numNivelFuerza.Location = new System.Drawing.Point(127, 114);
            this.numNivelFuerza.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numNivelFuerza.Name = "numNivelFuerza";
            this.numNivelFuerza.Size = new System.Drawing.Size(137, 23);
            this.numNivelFuerza.TabIndex = 2;
            // 
            // lblNivelFuerza
            // 
            this.lblNivelFuerza.AutoSize = true;
            this.lblNivelFuerza.Location = new System.Drawing.Point(23, 122);
            this.lblNivelFuerza.Name = "lblNivelFuerza";
            this.lblNivelFuerza.Size = new System.Drawing.Size(82, 15);
            this.lblNivelFuerza.TabIndex = 3;
            this.lblNivelFuerza.Text = "NivelDeFuerza";
            // 
            // lblEsAyudante
            // 
            this.lblEsAyudante.AutoSize = true;
            this.lblEsAyudante.Location = new System.Drawing.Point(25, 163);
            this.lblEsAyudante.Name = "lblEsAyudante";
            this.lblEsAyudante.Size = new System.Drawing.Size(72, 15);
            this.lblEsAyudante.TabIndex = 4;
            this.lblEsAyudante.Text = "Es Ayudante";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(127, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(137, 23);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // chkEsAyudante
            // 
            this.chkEsAyudante.AutoSize = true;
            this.chkEsAyudante.Checked = true;
            this.chkEsAyudante.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkEsAyudante.Location = new System.Drawing.Point(127, 163);
            this.chkEsAyudante.Name = "chkEsAyudante";
            this.chkEsAyudante.Size = new System.Drawing.Size(91, 19);
            this.chkEsAyudante.TabIndex = 7;
            this.chkEsAyudante.Text = "Es Ayudante";
            this.chkEsAyudante.UseVisualStyleBackColor = true;
            // 
            // cmbPoder
            // 
            this.cmbPoder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPoder.FormattingEnabled = true;
            this.cmbPoder.Items.AddRange(new object[] {
            "Telepatia",
            "Velocidad",
            "Fuerza",
            "Volar"});
            this.cmbPoder.Location = new System.Drawing.Point(127, 74);
            this.cmbPoder.Name = "cmbPoder";
            this.cmbPoder.Size = new System.Drawing.Size(137, 23);
            this.cmbPoder.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(77, 224);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(71, 38);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmHereo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbPoder);
            this.Controls.Add(this.chkEsAyudante);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEsAyudante);
            this.Controls.Add(this.lblNivelFuerza);
            this.Controls.Add(this.numNivelFuerza);
            this.Controls.Add(this.lblPoder);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmHereo";
            this.Text = "FrmHereo";
            ((System.ComponentModel.ISupportInitialize)(this.numNivelFuerza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPoder;
        private System.Windows.Forms.NumericUpDown numNivelFuerza;
        private System.Windows.Forms.Label lblNivelFuerza;
        private System.Windows.Forms.Label lblEsAyudante;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox chkEsAyudante;
        private System.Windows.Forms.ComboBox cmbPoder;
        private System.Windows.Forms.Button btnGuardar;
    }
}