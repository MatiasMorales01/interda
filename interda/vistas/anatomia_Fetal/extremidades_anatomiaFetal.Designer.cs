namespace interda.vistas.anatomia_fetal
{
    partial class extremidades_anatomiaFetal
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
            this.ext = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ext)).BeginInit();
            this.SuspendLayout();
            // 
            // ext
            // 
            this.ext.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.ext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ext.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ext.Location = new System.Drawing.Point(12, 85);
            this.ext.Name = "ext";
            this.ext.RowHeadersWidth = 51;
            this.ext.RowTemplate.Height = 24;
            this.ext.Size = new System.Drawing.Size(776, 348);
            this.ext.TabIndex = 9;
            this.ext.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ext_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Extremidades";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // extremidades_anatomiaFetal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 542);
            this.Controls.Add(this.ext);
            this.Controls.Add(this.label1);
            this.Name = "extremidades_anatomiaFetal";
            this.Text = "extremidades_anatomiaFetal";
            this.Load += new System.EventHandler(this.extremidades_anatomiaFetal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ext;
        private System.Windows.Forms.Label label1;
    }
}