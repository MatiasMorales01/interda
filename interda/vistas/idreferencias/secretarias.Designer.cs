namespace interda.vistas
{
    partial class secretarias
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
            this.secre = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.secre)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(83, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Secretarias";
            // 
            // secre
            // 
            this.secre.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.secre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.secre.Location = new System.Drawing.Point(88, 94);
            this.secre.Name = "secre";
            this.secre.RowHeadersWidth = 51;
            this.secre.RowTemplate.Height = 24;
            this.secre.Size = new System.Drawing.Size(901, 414);
            this.secre.TabIndex = 1;
            // 
            // secretarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 536);
            this.Controls.Add(this.secre);
            this.Controls.Add(this.label1);
            this.Name = "secretarias";
            this.Text = "secretarias";
            this.Load += new System.EventHandler(this.secretarias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.secre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView secre;
    }
}