namespace interda.vistas
{
    partial class vejiga_anatomiaFetal
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
            this.vejiga = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vejiga)).BeginInit();
            this.SuspendLayout();
            // 
            // vejiga
            // 
            this.vejiga.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.vejiga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vejiga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vejiga.Location = new System.Drawing.Point(12, 80);
            this.vejiga.Name = "vejiga";
            this.vejiga.RowHeadersWidth = 51;
            this.vejiga.RowTemplate.Height = 24;
            this.vejiga.Size = new System.Drawing.Size(776, 353);
            this.vejiga.TabIndex = 6;
            this.vejiga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vejiga_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vejiga";
            // 
            // vejiga_anatomiaFetal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vejiga);
            this.Controls.Add(this.label1);
            this.Name = "vejiga_anatomiaFetal";
            this.Text = "vejiga_anatomiaFetal";
            this.Load += new System.EventHandler(this.vejiga_anatomiaFetal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vejiga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vejiga;
        private System.Windows.Forms.Label label1;
    }
}