﻿namespace Help_Desk
{
    partial class FrmZahtjevi
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
            this.btnNatrag = new System.Windows.Forms.Button();
            this.dgvZahtjevi = new System.Windows.Forms.DataGridView();
            this.btnMojiZahtjevi = new System.Windows.Forms.Button();
            this.btnPreuzmiZahtjev = new System.Windows.Forms.Button();
            this.btnKomentar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNatrag
            // 
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.Location = new System.Drawing.Point(12, 12);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(128, 32);
            this.btnNatrag.TabIndex = 1;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // dgvZahtjevi
            // 
            this.dgvZahtjevi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtjevi.Location = new System.Drawing.Point(12, 50);
            this.dgvZahtjevi.Name = "dgvZahtjevi";
            this.dgvZahtjevi.Size = new System.Drawing.Size(820, 320);
            this.dgvZahtjevi.TabIndex = 2;
            // 
            // btnMojiZahtjevi
            // 
            this.btnMojiZahtjevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMojiZahtjevi.Location = new System.Drawing.Point(12, 376);
            this.btnMojiZahtjevi.Name = "btnMojiZahtjevi";
            this.btnMojiZahtjevi.Size = new System.Drawing.Size(169, 32);
            this.btnMojiZahtjevi.TabIndex = 6;
            this.btnMojiZahtjevi.Text = "Prikaži moje zahtjeve";
            this.btnMojiZahtjevi.UseVisualStyleBackColor = true;
            this.btnMojiZahtjevi.Click += new System.EventHandler(this.btnMojiZahtjevi_Click);
            // 
            // btnPreuzmiZahtjev
            // 
            this.btnPreuzmiZahtjev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPreuzmiZahtjev.Location = new System.Drawing.Point(187, 376);
            this.btnPreuzmiZahtjev.Name = "btnPreuzmiZahtjev";
            this.btnPreuzmiZahtjev.Size = new System.Drawing.Size(169, 32);
            this.btnPreuzmiZahtjev.TabIndex = 7;
            this.btnPreuzmiZahtjev.Text = "Promjeni status";
            this.btnPreuzmiZahtjev.UseVisualStyleBackColor = true;
            this.btnPreuzmiZahtjev.Click += new System.EventHandler(this.btnPreuzmiZahtjev_Click);
            // 
            // btnKomentar
            // 
            this.btnKomentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKomentar.Location = new System.Drawing.Point(362, 376);
            this.btnKomentar.Name = "btnKomentar";
            this.btnKomentar.Size = new System.Drawing.Size(169, 32);
            this.btnKomentar.TabIndex = 8;
            this.btnKomentar.Text = "Dodaj komentar";
            this.btnKomentar.UseVisualStyleBackColor = true;
            this.btnKomentar.Click += new System.EventHandler(this.btnKomentar_Click);
            // 
            // FrmZahtjevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(844, 441);
            this.Controls.Add(this.btnKomentar);
            this.Controls.Add(this.btnPreuzmiZahtjev);
            this.Controls.Add(this.btnMojiZahtjevi);
            this.Controls.Add(this.dgvZahtjevi);
            this.Controls.Add(this.btnNatrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmZahtjevi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz Zahtjeva";
            this.Load += new System.EventHandler(this.FrmZahtjevi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.DataGridView dgvZahtjevi;
        private System.Windows.Forms.Button btnMojiZahtjevi;
        private System.Windows.Forms.Button btnPreuzmiZahtjev;
        private System.Windows.Forms.Button btnKomentar;
    }
}