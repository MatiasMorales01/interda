namespace interda.vistas
{
    partial class anexo
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
            this.anex = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.anex)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(72, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anexos";
            // 
            // anex
            // 
            this.anex.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.anex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.anex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.anex.Location = new System.Drawing.Point(77, 122);
            this.anex.Name = "anex";
            this.anex.RowHeadersWidth = 51;
            this.anex.RowTemplate.Height = 24;
            this.anex.Size = new System.Drawing.Size(897, 368);
            this.anex.TabIndex = 1;
            // 
            // anexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 537);
            this.Controls.Add(this.anex);
            this.Controls.Add(this.label1);
            this.Name = "anexo";
            this.Text = "anexo";
            this.Load += new System.EventHandler(this.anexo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView anex;
    }
}