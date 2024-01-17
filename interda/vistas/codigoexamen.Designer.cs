namespace interda.vistas
{
    partial class codigoexamen
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
            this.exam = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.exam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(110, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo del examen";
            // 
            // exam
            // 
            this.exam.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.exam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exam.Location = new System.Drawing.Point(115, 96);
            this.exam.Name = "exam";
            this.exam.RowHeadersWidth = 51;
            this.exam.RowTemplate.Height = 24;
            this.exam.Size = new System.Drawing.Size(679, 234);
            this.exam.TabIndex = 1;
            // 
            // codigoexamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 538);
            this.Controls.Add(this.exam);
            this.Controls.Add(this.label1);
            this.Name = "codigoexamen";
            this.Text = "codigoexamen";
            this.Load += new System.EventHandler(this.codigoexamen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView exam;
    }
}