namespace interda.vistas
{
    partial class isapre
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
            this.isa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.isa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(81, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Isapre";
            // 
            // isa
            // 
            this.isa.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.isa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.isa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.isa.Location = new System.Drawing.Point(86, 90);
            this.isa.Name = "isa";
            this.isa.RowHeadersWidth = 51;
            this.isa.RowTemplate.Height = 24;
            this.isa.Size = new System.Drawing.Size(815, 385);
            this.isa.TabIndex = 1;
            // 
            // isapre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 537);
            this.Controls.Add(this.isa);
            this.Controls.Add(this.label1);
            this.Name = "isapre";
            this.Text = "isapre";
            this.Load += new System.EventHandler(this.isapre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.isa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView isa;
    }
}