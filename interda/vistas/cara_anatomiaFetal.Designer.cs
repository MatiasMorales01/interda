namespace interda.vistas
{
    partial class cara_anatomiaFetal
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
            this.cara = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cara)).BeginInit();
            this.SuspendLayout();
            // 
            // cara
            // 
            this.cara.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.cara.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cara.Location = new System.Drawing.Point(12, 49);
            this.cara.Name = "cara";
            this.cara.RowHeadersWidth = 51;
            this.cara.RowTemplate.Height = 24;
            this.cara.Size = new System.Drawing.Size(776, 384);
            this.cara.TabIndex = 5;
            this.cara.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cara_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cara";
            // 
            // cara_anatomiaFetal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cara);
            this.Controls.Add(this.label1);
            this.Name = "cara_anatomiaFetal";
            this.Text = "cara_anatomiaFetal";
            ((System.ComponentModel.ISupportInitialize)(this.cara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cara;
        private System.Windows.Forms.Label label1;
    }
}