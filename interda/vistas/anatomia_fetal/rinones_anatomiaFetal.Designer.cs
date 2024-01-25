namespace interda.vistas
{
    partial class rinones_anatomiaFetal
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
            this.rinones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rinones)).BeginInit();
            this.SuspendLayout();
            // 
            // rinones
            // 
            this.rinones.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.rinones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rinones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rinones.Location = new System.Drawing.Point(12, 85);
            this.rinones.Name = "rinones";
            this.rinones.RowHeadersWidth = 51;
            this.rinones.RowTemplate.Height = 24;
            this.rinones.Size = new System.Drawing.Size(776, 348);
            this.rinones.TabIndex = 7;
            this.rinones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rinones_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Riñones";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rinones_anatomiaFetal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 540);
            this.Controls.Add(this.rinones);
            this.Controls.Add(this.label1);
            this.Name = "rinones_anatomiaFetal";
            this.Text = "rinones_anatomiaFetal";
            this.Load += new System.EventHandler(this.rinones_anatomiaFetal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rinones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rinones;
        private System.Windows.Forms.Label label1;
    }
}