namespace DA_ENTREGA2
{
    partial class Form1
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
            this.nombreLbl = new System.Windows.Forms.Label();
            this.userText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLbl.Location = new System.Drawing.Point(711, 171);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(102, 31);
            this.nombreLbl.TabIndex = 0;
            this.nombreLbl.Text = "Nombre";
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(608, 205);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(314, 22);
            this.userText.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(652, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Iniciar Sesion";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(608, 291);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(314, 22);
            this.passwordText.TabIndex = 3;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(698, 257);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(134, 31);
            this.passwordLbl.TabIndex = 4;
            this.passwordLbl.Text = "Contraseña";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 563);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.nombreLbl);
            this.Name = "Form1";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label passwordLbl;
    }
}

