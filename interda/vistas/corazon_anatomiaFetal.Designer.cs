namespace interda.vistas
{
    partial class corazon_anatomiaFetal
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
            this.corazon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.corazon)).BeginInit();
            this.SuspendLayout();
            // 
            // corazon
            // 
            this.corazon.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.corazon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.corazon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.corazon.Location = new System.Drawing.Point(12, 49);
            this.corazon.Name = "corazon";
            this.corazon.RowHeadersWidth = 51;
            this.corazon.RowTemplate.Height = 24;
            this.corazon.Size = new System.Drawing.Size(776, 384);
            this.corazon.TabIndex = 9;
            this.corazon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.corazon_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Corazón";
            // 
            // corazon_anatomiaFetal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.corazon);
            this.Controls.Add(this.label1);
            this.Name = "corazon_anatomiaFetal";
            this.Text = "corazon_anatomiaFetal";
            ((System.ComponentModel.ISupportInitialize)(this.corazon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView corazon;
        private System.Windows.Forms.Label label1;
    }
}