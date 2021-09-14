
namespace Clase_07_UI_2
{
    partial class Menu_Principal
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
            this.btn_alta = new System.Windows.Forms.Button();
            this.rtx_catalogo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_alta
            // 
            this.btn_alta.Location = new System.Drawing.Point(83, 112);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(125, 23);
            this.btn_alta.TabIndex = 0;
            this.btn_alta.Text = "Crear Guitarra";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // rtx_catalogo
            // 
            this.rtx_catalogo.Location = new System.Drawing.Point(289, 112);
            this.rtx_catalogo.Name = "rtx_catalogo";
            this.rtx_catalogo.Size = new System.Drawing.Size(213, 214);
            this.rtx_catalogo.TabIndex = 2;
            this.rtx_catalogo.Text = "";
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtx_catalogo);
            this.Controls.Add(this.btn_alta);
            this.Name = "Menu_Principal";
            this.Text = "Menu_Principal";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.RichTextBox rtx_catalogo;
    }
}