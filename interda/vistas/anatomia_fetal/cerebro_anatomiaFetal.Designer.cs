namespace interda.vistas
{
    partial class cerebro_anatomiaFetal
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
            this.cerebro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cerebro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cerebro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cerebro
            // 
            this.cerebro.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.cerebro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cerebro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cerebro.Location = new System.Drawing.Point(12, 78);
            this.cerebro.Name = "cerebro";
            this.cerebro.RowHeadersWidth = 51;
            this.cerebro.RowTemplate.Height = 24;
            this.cerebro.Size = new System.Drawing.Size(776, 360);
            this.cerebro.TabIndex = 3;
            this.cerebro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cerebro_CellContentClick);
            // 
            // cerebro_anatomiaFetal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cerebro);
            this.Controls.Add(this.label1);
            this.Name = "cerebro_anatomiaFetal";
            this.Text = "cerebro_anatomiaFetal";
            this.Load += new System.EventHandler(this.cerebro_anatomiaFetal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cerebro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView cerebro;
    }
}