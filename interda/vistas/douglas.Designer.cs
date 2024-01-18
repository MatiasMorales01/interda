namespace interda.vistas
{
    partial class douglas
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
            this.doug = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.doug)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(82, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Douglas";
            // 
            // doug
            // 
            this.doug.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.doug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.doug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doug.Location = new System.Drawing.Point(87, 123);
            this.doug.Name = "doug";
            this.doug.RowHeadersWidth = 51;
            this.doug.RowTemplate.Height = 24;
            this.doug.Size = new System.Drawing.Size(885, 383);
            this.doug.TabIndex = 1;
            // 
            // douglas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 538);
            this.Controls.Add(this.doug);
            this.Controls.Add(this.label1);
            this.Name = "douglas";
            this.Text = "douglas";
            this.Load += new System.EventHandler(this.douglas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView doug;
    }
}