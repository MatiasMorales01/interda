namespace interda.vistas
{
    partial class cordon_anatomiaFetal
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
            this.cordon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cordon)).BeginInit();
            this.SuspendLayout();
            // 
            // cordon
            // 
            this.cordon.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.cordon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cordon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cordon.Location = new System.Drawing.Point(12, 85);
            this.cordon.Name = "cordon";
            this.cordon.RowHeadersWidth = 51;
            this.cordon.RowTemplate.Height = 24;
            this.cordon.Size = new System.Drawing.Size(776, 348);
            this.cordon.TabIndex = 9;
            this.cordon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cordon_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cordón Umbilical";
            // 
            // cordon_anatomiaFetal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 537);
            this.Controls.Add(this.cordon);
            this.Controls.Add(this.label1);
            this.Name = "cordon_anatomiaFetal";
            this.Text = "cordon_anatomiaFetal";
            this.Load += new System.EventHandler(this.cordon_anatomiaFetal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cordon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cordon;
        private System.Windows.Forms.Label label1;
    }
}