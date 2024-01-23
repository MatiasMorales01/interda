namespace interda.vistas
{
    partial class conclu
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
            this.con = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.con)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(81, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conclusión";
            // 
            // con
            // 
            this.con.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.con.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.con.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.con.Location = new System.Drawing.Point(86, 117);
            this.con.Name = "con";
            this.con.RowHeadersWidth = 51;
            this.con.RowTemplate.Height = 24;
            this.con.Size = new System.Drawing.Size(909, 394);
            this.con.TabIndex = 1;
            // 
            // conclu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 536);
            this.Controls.Add(this.con);
            this.Controls.Add(this.label1);
            this.Name = "conclu";
            this.Text = "conclu";
            this.Load += new System.EventHandler(this.conclu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.con)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView con;
    }
}