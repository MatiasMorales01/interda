namespace interda.vistas
{
    partial class vejiga
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
            this.vejig = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.vejig)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(59, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vejiga";
            // 
            // vejig
            // 
            this.vejig.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.vejig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vejig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vejig.Location = new System.Drawing.Point(64, 112);
            this.vejig.Name = "vejig";
            this.vejig.RowHeadersWidth = 51;
            this.vejig.RowTemplate.Height = 24;
            this.vejig.Size = new System.Drawing.Size(941, 413);
            this.vejig.TabIndex = 1;
            // 
            // vejiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 537);
            this.Controls.Add(this.vejig);
            this.Controls.Add(this.label1);
            this.Name = "vejiga";
            this.Text = "vejiga";
            this.Load += new System.EventHandler(this.vejiga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vejig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView vejig;
    }
}