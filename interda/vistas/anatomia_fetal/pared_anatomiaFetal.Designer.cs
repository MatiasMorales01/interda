namespace interda.vistas
{
    partial class pared_anatomiaFetal
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
            this.pared = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pared)).BeginInit();
            this.SuspendLayout();
            // 
            // pared
            // 
            this.pared.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.pared.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pared.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pared.Location = new System.Drawing.Point(12, 85);
            this.pared.Name = "pared";
            this.pared.RowHeadersWidth = 51;
            this.pared.RowTemplate.Height = 24;
            this.pared.Size = new System.Drawing.Size(776, 348);
            this.pared.TabIndex = 9;
            this.pared.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pared_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pared Abdominal";
            // 
            // pared_anatomiaFetal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 542);
            this.Controls.Add(this.pared);
            this.Controls.Add(this.label1);
            this.Name = "pared_anatomiaFetal";
            this.Text = "pared_anatomiaFetal";
            this.Load += new System.EventHandler(this.pared_anatomiaFetal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pared)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pared;
        private System.Windows.Forms.Label label1;
    }
}