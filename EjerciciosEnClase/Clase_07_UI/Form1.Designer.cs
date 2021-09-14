
namespace Clase_07_UI
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
            this.txt_cuadritoDeTexto = new System.Windows.Forms.TextBox();
            this.btn_MostrarInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_cuadritoDeTexto
            // 
            this.txt_cuadritoDeTexto.Location = new System.Drawing.Point(209, 93);
            this.txt_cuadritoDeTexto.Name = "txt_cuadritoDeTexto";
            this.txt_cuadritoDeTexto.Size = new System.Drawing.Size(125, 27);
            this.txt_cuadritoDeTexto.TabIndex = 0;
            // 
            // btn_MostrarInfo
            // 
            this.btn_MostrarInfo.Location = new System.Drawing.Point(240, 199);
            this.btn_MostrarInfo.Name = "btn_MostrarInfo";
            this.btn_MostrarInfo.Size = new System.Drawing.Size(277, 29);
            this.btn_MostrarInfo.TabIndex = 1;
            this.btn_MostrarInfo.Text = "Mostrar Informacion";
            this.btn_MostrarInfo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_MostrarInfo);
            this.Controls.Add(this.txt_cuadritoDeTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cuadritoDeTexto;
        private System.Windows.Forms.Button btn_MostrarInfo;
    }
}

