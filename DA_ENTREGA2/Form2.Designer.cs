namespace DA_ENTREGA2
{
    partial class pantallaPrincipal
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
            this.langileTable = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.langileTable)).BeginInit();
            this.SuspendLayout();
            // 
            // langileTable
            // 
            this.langileTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.langileTable.Location = new System.Drawing.Point(513, 128);
            this.langileTable.Name = "langileTable";
            this.langileTable.RowHeadersWidth = 51;
            this.langileTable.RowTemplate.Height = 24;
            this.langileTable.Size = new System.Drawing.Size(436, 288);
            this.langileTable.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(599, 26);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(240, 51);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "AÑADIR ";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(599, 468);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(240, 51);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "ELIMINAR";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // reloadButton
            // 
            this.reloadButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadButton.ForeColor = System.Drawing.Color.Black;
            this.reloadButton.Location = new System.Drawing.Point(955, 128);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(88, 51);
            this.reloadButton.TabIndex = 4;
            this.reloadButton.Text = "RELOAD";
            this.reloadButton.UseVisualStyleBackColor = false;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // pantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 549);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.langileTable);
            this.Name = "pantallaPrincipal";
            this.Text = "Pantalla Principal";
            this.Load += new System.EventHandler(this.pantallaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.langileTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView langileTable;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button reloadButton;
    }
}