
namespace HeroeApp
{
    partial class FrmUniverso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNuevoHeroe = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCrearE = new System.Windows.Forms.Button();
            this.FrmModal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNuevoHeroe
            // 
            this.btnNuevoHeroe.Location = new System.Drawing.Point(301, 74);
            this.btnNuevoHeroe.Name = "btnNuevoHeroe";
            this.btnNuevoHeroe.Size = new System.Drawing.Size(122, 23);
            this.btnNuevoHeroe.TabIndex = 0;
            this.btnNuevoHeroe.Text = "Nuevo Heroe";
            this.btnNuevoHeroe.UseVisualStyleBackColor = true;
            this.btnNuevoHeroe.Click += new System.EventHandler(this.btnNuevoHeroe_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombre.Location = new System.Drawing.Point(42, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(119, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre del Universo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(177, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCrearE
            // 
            this.btnCrearE.Location = new System.Drawing.Point(42, 61);
            this.btnCrearE.Name = "btnCrearE";
            this.btnCrearE.Size = new System.Drawing.Size(154, 49);
            this.btnCrearE.TabIndex = 6;
            this.btnCrearE.Text = "Crear";
            this.btnCrearE.UseVisualStyleBackColor = true;
            this.btnCrearE.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmModal
            // 
            this.FrmModal.Location = new System.Drawing.Point(503, 85);
            this.FrmModal.Name = "FrmModal";
            this.FrmModal.Size = new System.Drawing.Size(94, 44);
            this.FrmModal.TabIndex = 8;
            this.FrmModal.Text = "Modal";
            this.FrmModal.UseVisualStyleBackColor = true;
            this.FrmModal.Click += new System.EventHandler(this.FrmModal_Click);
            // 
            // FrmUniverso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(765, 431);
            this.Controls.Add(this.FrmModal);
            this.Controls.Add(this.btnCrearE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnNuevoHeroe);
            this.IsMdiContainer = true;
            this.Location = new System.Drawing.Point(2000, 0);
            this.Name = "FrmUniverso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Titulo del formulario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUniverso_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoHeroe;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCrearE;
        private System.Windows.Forms.Button FrmModal;
    }
}

