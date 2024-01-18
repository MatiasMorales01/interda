namespace interda.vistas
{
    partial class tratante
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
            this.tra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(60, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tratante";
            // 
            // tra
            // 
            this.tra.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tra.Location = new System.Drawing.Point(65, 99);
            this.tra.Name = "tra";
            this.tra.RowHeadersWidth = 51;
            this.tra.RowTemplate.Height = 24;
            this.tra.Size = new System.Drawing.Size(898, 387);
            this.tra.TabIndex = 1;
            this.tra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tra_CellContentClick);
            // 
            // tratante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 535);
            this.Controls.Add(this.tra);
            this.Controls.Add(this.label1);
            this.Name = "tratante";
            this.Text = "tratante";
            ((System.ComponentModel.ISupportInitialize)(this.tra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tra;
    }
}