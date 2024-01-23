namespace interda.vistas
{
    partial class endometrio
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
            this.endo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.endo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(80, 37);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endometrio";
            // 
            // endo
            // 
            this.endo.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.endo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.endo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.endo.Location = new System.Drawing.Point(85, 111);
            this.endo.Name = "endo";
            this.endo.RowHeadersWidth = 51;
            this.endo.RowTemplate.Height = 24;
            this.endo.Size = new System.Drawing.Size(883, 395);
            this.endo.TabIndex = 1;
            // 
            // endometrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 536);
            this.Controls.Add(this.endo);
            this.Controls.Add(this.label1);
            this.Name = "endometrio";
            this.Text = "endometrio";
            this.Load += new System.EventHandler(this.endometrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.endo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView endo;
    }
}