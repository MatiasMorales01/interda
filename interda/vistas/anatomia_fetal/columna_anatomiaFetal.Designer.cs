namespace interda.vistas
{
    partial class columna_anatomiaFetal
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
            this.columna = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.columna)).BeginInit();
            this.SuspendLayout();
            // 
            // columna
            // 
            this.columna.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.columna.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.columna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.columna.Location = new System.Drawing.Point(12, 80);
            this.columna.Name = "columna";
            this.columna.RowHeadersWidth = 51;
            this.columna.RowTemplate.Height = 24;
            this.columna.Size = new System.Drawing.Size(776, 353);
            this.columna.TabIndex = 5;
            this.columna.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cerebro_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Columna Vertebral";
            // 
            // columna_anatomiaFetal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.columna);
            this.Controls.Add(this.label1);
            this.Name = "columna_anatomiaFetal";
            this.Text = "columna_anatomiaFetal";
            ((System.ComponentModel.ISupportInitialize)(this.columna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView columna;
        private System.Windows.Forms.Label label1;
    }
}