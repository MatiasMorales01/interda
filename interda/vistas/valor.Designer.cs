namespace interda.vistas
{
    partial class valor
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
            this.val = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.val)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(68, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor examen";
            // 
            // val
            // 
            this.val.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.val.Location = new System.Drawing.Point(73, 105);
            this.val.Name = "val";
            this.val.RowHeadersWidth = 51;
            this.val.RowTemplate.Height = 24;
            this.val.Size = new System.Drawing.Size(861, 381);
            this.val.TabIndex = 1;
            // 
            // valor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 532);
            this.Controls.Add(this.val);
            this.Controls.Add(this.label1);
            this.Name = "valor";
            this.Text = "valor";
            this.Load += new System.EventHandler(this.valor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.val)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView val;
    }
}