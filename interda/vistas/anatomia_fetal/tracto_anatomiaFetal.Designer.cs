namespace interda.vistas
{
    partial class tracto_anatomiaFetal
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
            this.tracto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tracto)).BeginInit();
            this.SuspendLayout();
            // 
            // tracto
            // 
            this.tracto.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tracto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tracto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tracto.Location = new System.Drawing.Point(12, 80);
            this.tracto.Name = "tracto";
            this.tracto.RowHeadersWidth = 51;
            this.tracto.RowTemplate.Height = 24;
            this.tracto.Size = new System.Drawing.Size(776, 353);
            this.tracto.TabIndex = 6;
            this.tracto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tracto_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tracto Gastrointestinal";
            // 
            // tracto_anatomiaFetal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 539);
            this.Controls.Add(this.tracto);
            this.Controls.Add(this.label1);
            this.Name = "tracto_anatomiaFetal";
            this.Text = "tracto_anatomiaFetal";
            this.Load += new System.EventHandler(this.tracto_anatomiaFetal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tracto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tracto;
        private System.Windows.Forms.Label label1;
    }
}