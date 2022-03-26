namespace Examen2_LP3_Douglas_Reyes
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_contraseña = new System.Windows.Forms.TextBox();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn__Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_contraseña
            // 
            this.Txt_contraseña.Location = new System.Drawing.Point(156, 105);
            this.Txt_contraseña.Name = "Txt_contraseña";
            this.Txt_contraseña.Size = new System.Drawing.Size(188, 20);
            this.Txt_contraseña.TabIndex = 11;
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.Location = new System.Drawing.Point(156, 44);
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.Size = new System.Drawing.Size(188, 20);
            this.Txt_usuario.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario";
            // 
            // Btn_salir
            // 
            this.Btn_salir.Location = new System.Drawing.Point(305, 181);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(75, 23);
            this.Btn_salir.TabIndex = 7;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn__Aceptar
            // 
            this.Btn__Aceptar.Location = new System.Drawing.Point(119, 181);
            this.Btn__Aceptar.Name = "Btn__Aceptar";
            this.Btn__Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Btn__Aceptar.TabIndex = 6;
            this.Btn__Aceptar.Text = "Aceptar";
            this.Btn__Aceptar.UseVisualStyleBackColor = true;
            this.Btn__Aceptar.Click += new System.EventHandler(this.Btn__Aceptar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 251);
            this.Controls.Add(this.Txt_contraseña);
            this.Controls.Add(this.Txt_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn__Aceptar);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_contraseña;
        private System.Windows.Forms.TextBox Txt_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn__Aceptar;
    }
}

