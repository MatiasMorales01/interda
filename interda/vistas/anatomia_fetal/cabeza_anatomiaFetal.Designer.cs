namespace interda.vistas
{
    partial class cabeza_anatomiaFetal
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
            this.cabeza = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cabeza)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cabeza";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cabeza
            // 
            this.cabeza.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.cabeza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cabeza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cabeza.Location = new System.Drawing.Point(12, 85);
            this.cabeza.Name = "cabeza";
            this.cabeza.RowHeadersWidth = 51;
            this.cabeza.RowTemplate.Height = 24;
            this.cabeza.Size = new System.Drawing.Size(776, 353);
            this.cabeza.TabIndex = 4;
            this.cabeza.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cerebro_CellContentClick);
            // 
            // cabeza_anatomiaFetal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cabeza);
            this.Controls.Add(this.label1);
            this.Name = "cabeza_anatomiaFetal";
            this.Text = "cabeza_anatomiaFetal";
            ((System.ComponentModel.ISupportInitialize)(this.cabeza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView cabeza;
    }
}