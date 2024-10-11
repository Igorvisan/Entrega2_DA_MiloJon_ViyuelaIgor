namespace DA_ENTREGA2
{
    partial class añadirEmpleado
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
            this.nombreLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxArduraduna = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.nombreLabel.Location = new System.Drawing.Point(245, 102);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(114, 31);
            this.nombreLabel.TabIndex = 0;
            this.nombreLabel.Text = "Nombre: ";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(355, 111);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(215, 22);
            this.nameText.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.passwordLabel.Location = new System.Drawing.Point(213, 189);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(146, 31);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Contraseña: ";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(355, 198);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(215, 22);
            this.passwordText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(213, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Arduraduna: ";
            // 
            // checkBoxArduraduna
            // 
            this.checkBoxArduraduna.AutoSize = true;
            this.checkBoxArduraduna.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxArduraduna.Location = new System.Drawing.Point(373, 291);
            this.checkBoxArduraduna.Name = "checkBoxArduraduna";
            this.checkBoxArduraduna.Size = new System.Drawing.Size(104, 33);
            this.checkBoxArduraduna.TabIndex = 6;
            this.checkBoxArduraduna.Text = "Bai/Ez";
            this.checkBoxArduraduna.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(239, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 73);
            this.button1.TabIndex = 7;
            this.button1.Text = "CONFIRMAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // añadirEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxArduraduna);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nombreLabel);
            this.Name = "añadirEmpleado";
            this.Text = "AÑADIR";
            this.Load += new System.EventHandler(this.añadirEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxArduraduna;
        private System.Windows.Forms.Button button1;
    }
}