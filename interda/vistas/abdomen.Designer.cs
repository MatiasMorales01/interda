﻿namespace interda.vistas
{
    partial class abdomen
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
            this.abd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.abd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(77, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abdomen";
            // 
            // abd
            // 
            this.abd.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.abd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.abd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abd.Location = new System.Drawing.Point(82, 107);
            this.abd.Name = "abd";
            this.abd.RowHeadersWidth = 51;
            this.abd.RowTemplate.Height = 24;
            this.abd.Size = new System.Drawing.Size(900, 391);
            this.abd.TabIndex = 1;
            // 
            // abdomen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 535);
            this.Controls.Add(this.abd);
            this.Controls.Add(this.label1);
            this.Name = "abdomen";
            this.Text = "abdomen";
            this.Load += new System.EventHandler(this.abdomen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView abd;
    }
}