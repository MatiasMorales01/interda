namespace interda.vistas
{
    partial class ecografo
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
            this.eco = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.eco)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(91, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ecografo";
            // 
            // eco
            // 
            this.eco.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.eco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eco.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.eco.Location = new System.Drawing.Point(96, 92);
            this.eco.Name = "eco";
            this.eco.RowHeadersWidth = 51;
            this.eco.RowTemplate.Height = 24;
            this.eco.Size = new System.Drawing.Size(835, 396);
            this.eco.TabIndex = 1;
            // 
            // ecografo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 537);
            this.Controls.Add(this.eco);
            this.Controls.Add(this.label1);
            this.Name = "ecografo";
            this.Text = "ecografo";
            this.Load += new System.EventHandler(this.ecografo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView eco;
    }
}