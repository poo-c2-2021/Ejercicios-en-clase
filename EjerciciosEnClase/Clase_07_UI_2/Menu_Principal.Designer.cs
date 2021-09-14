
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
            this.lbl_Info = new System.Windows.Forms.Label();
            this.btn_prop = new System.Windows.Forms.Button();
            this.tb_numero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_alta
            // 
            this.btn_alta.Location = new System.Drawing.Point(86, 147);
            this.btn_alta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(143, 31);
            this.btn_alta.TabIndex = 0;
            this.btn_alta.Text = "Crear Guitarra";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // rtx_catalogo
            // 
            this.rtx_catalogo.Location = new System.Drawing.Point(330, 149);
            this.rtx_catalogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtx_catalogo.Name = "rtx_catalogo";
            this.rtx_catalogo.Size = new System.Drawing.Size(243, 284);
            this.rtx_catalogo.TabIndex = 2;
            this.rtx_catalogo.Text = "";
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Location = new System.Drawing.Point(416, 515);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(87, 20);
            this.lbl_Info.TabIndex = 3;
            this.lbl_Info.Text = "infoguitarra";
            // 
            // btn_prop
            // 
            this.btn_prop.Location = new System.Drawing.Point(43, 500);
            this.btn_prop.Name = "btn_prop";
            this.btn_prop.Size = new System.Drawing.Size(106, 49);
            this.btn_prop.TabIndex = 4;
            this.btn_prop.Text = "button1";
            this.btn_prop.UseVisualStyleBackColor = true;
            this.btn_prop.Click += new System.EventHandler(this.btn_prop_Click);
            // 
            // tb_numero
            // 
            this.tb_numero.Location = new System.Drawing.Point(191, 511);
            this.tb_numero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.Size = new System.Drawing.Size(37, 27);
            this.tb_numero.TabIndex = 5;
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.tb_numero);
            this.Controls.Add(this.btn_prop);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.rtx_catalogo);
            this.Controls.Add(this.btn_alta);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu_Principal";
            this.Text = "Menu_Principal";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.RichTextBox rtx_catalogo;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.Button btn_prop;
        private System.Windows.Forms.TextBox tb_numero;
    }
}