
namespace Clase_07_UI_2
{
    partial class Alta_Instrumento
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
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.cbx_marca = new System.Windows.Forms.ComboBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(165, 112);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(125, 27);
            this.txt_modelo.TabIndex = 0;
            // 
            // cbx_marca
            // 
            this.cbx_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_marca.FormattingEnabled = true;
            this.cbx_marca.Location = new System.Drawing.Point(165, 50);
            this.cbx_marca.Name = "cbx_marca";
            this.cbx_marca.Size = new System.Drawing.Size(151, 28);
            this.cbx_marca.TabIndex = 1;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(123, 203);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(94, 29);
            this.btn_aceptar.TabIndex = 2;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(261, 203);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 29);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Alta_Instrumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 317);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.cbx_marca);
            this.Controls.Add(this.txt_modelo);
            this.Name = "Alta_Instrumento";
            this.Text = "Alta_Instrumento";
            this.Load += new System.EventHandler(this.Alta_Instrumento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.ComboBox cbx_marca;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}