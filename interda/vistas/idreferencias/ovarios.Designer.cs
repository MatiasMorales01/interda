namespace interda.vistas
{
    partial class ovarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.ov = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ov)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(61, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ovarios";
            // 
            // ov
            // 
            this.ov.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.ov.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ov.Location = new System.Drawing.Point(66, 102);
            this.ov.Name = "ov";
            this.ov.RowHeadersWidth = 51;
            this.ov.RowTemplate.Height = 24;
            this.ov.Size = new System.Drawing.Size(914, 405);
            this.ov.TabIndex = 1;
            // 
            // ovarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 542);
            this.Controls.Add(this.ov);
            this.Controls.Add(this.label1);
            this.Name = "ovarios";
            this.Text = "ovarios";
            this.Load += new System.EventHandler(this.ovarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ov;
    }
}