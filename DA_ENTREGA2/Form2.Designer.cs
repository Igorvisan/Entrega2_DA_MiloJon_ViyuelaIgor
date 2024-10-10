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
            this.erabiltzaileTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.langileTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erabiltzaileTable)).BeginInit();
            this.SuspendLayout();
            // 
            // langileTable
            // 
            this.langileTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.langileTable.Location = new System.Drawing.Point(175, 109);
            this.langileTable.Name = "langileTable";
            this.langileTable.RowHeadersWidth = 51;
            this.langileTable.RowTemplate.Height = 24;
            this.langileTable.Size = new System.Drawing.Size(436, 288);
            this.langileTable.TabIndex = 0;
            // 
            // erabiltzaileTable
            // 
            this.erabiltzaileTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.erabiltzaileTable.Location = new System.Drawing.Point(834, 109);
            this.erabiltzaileTable.Name = "erabiltzaileTable";
            this.erabiltzaileTable.RowHeadersWidth = 51;
            this.erabiltzaileTable.RowTemplate.Height = 24;
            this.erabiltzaileTable.Size = new System.Drawing.Size(436, 288);
            this.erabiltzaileTable.TabIndex = 1;
            // 
            // pantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 549);
            this.Controls.Add(this.erabiltzaileTable);
            this.Controls.Add(this.langileTable);
            this.Name = "pantallaPrincipal";
            this.Text = "Pantalla Principal";
            this.Load += new System.EventHandler(this.pantallaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.langileTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erabiltzaileTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView langileTable;
        private System.Windows.Forms.DataGridView erabiltzaileTable;
    }
}