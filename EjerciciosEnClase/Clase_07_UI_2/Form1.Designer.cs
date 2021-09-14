
namespace Clase_07_UI_2
{
    partial class Form1
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
            this.txt_info = new System.Windows.Forms.TextBox();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_info
            // 
            this.txt_info.Location = new System.Drawing.Point(205, 105);
            this.txt_info.Name = "txt_info";
            this.txt_info.PlaceholderText = "Aca va la info";
            this.txt_info.Size = new System.Drawing.Size(242, 27);
            this.txt_info.TabIndex = 0;
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(230, 191);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(184, 29);
            this.btn_mostrar.TabIndex = 1;
            this.btn_mostrar.Text = "Mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Location = new System.Drawing.Point(205, 59);
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.PlaceholderText = "Aca va la info";
            this.txt_nombreCliente.Size = new System.Drawing.Size(242, 27);
            this.txt_nombreCliente.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_nombreCliente);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.txt_info);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_info;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.TextBox txt_nombreCliente;
    }
}

