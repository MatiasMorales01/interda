﻿namespace interda.vistas
{
    partial class ecografistas
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
            this.eco = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eco)).BeginInit();
            this.SuspendLayout();
            // 
            // eco
            // 
            this.eco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eco.Location = new System.Drawing.Point(42, 89);
            this.eco.Name = "eco";
            this.eco.RowHeadersWidth = 51;
            this.eco.RowTemplate.Height = 24;
            this.eco.Size = new System.Drawing.Size(943, 417);
            this.eco.TabIndex = 0;
            this.eco.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eco_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ecografistas";
            // 
            // ecografistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 537);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eco);
            this.Name = "ecografistas";
            this.Text = "ecografistas";
            this.Load += new System.EventHandler(this.ecografistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView eco;
        private System.Windows.Forms.Label label1;
    }
}