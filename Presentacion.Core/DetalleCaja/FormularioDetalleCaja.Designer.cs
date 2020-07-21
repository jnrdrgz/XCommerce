﻿namespace Presentacion.Core.DetalleCaja
{
    partial class FormularioDetalleCaja
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
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEfectivo = new System.Windows.Forms.CheckBox();
            this.cbCtaCte = new System.Windows.Forms.CheckBox();
            this.cbCheque = new System.Windows.Forms.CheckBox();
            this.cbTarjeta = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGrilla.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(12, 104);
            this.dgvGrilla.MultiSelect = false;
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrilla.Size = new System.Drawing.Size(586, 197);
            this.dgvGrilla.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Liberation Sans", 9.75F);
            this.label2.Location = new System.Drawing.Point(316, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Liberation Sans", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Desde";
            // 
            // dtDesde
            // 
            this.dtDesde.Location = new System.Drawing.Point(62, 14);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(230, 20);
            this.dtDesde.TabIndex = 10;
            // 
            // dtHasta
            // 
            this.dtHasta.Location = new System.Drawing.Point(368, 14);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(230, 20);
            this.dtHasta.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Liberation Sans", 9.75F);
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tipo";
            // 
            // cbEfectivo
            // 
            this.cbEfectivo.AutoSize = true;
            this.cbEfectivo.Location = new System.Drawing.Point(62, 55);
            this.cbEfectivo.Name = "cbEfectivo";
            this.cbEfectivo.Size = new System.Drawing.Size(65, 17);
            this.cbEfectivo.TabIndex = 16;
            this.cbEfectivo.Text = "Efectivo";
            this.cbEfectivo.UseVisualStyleBackColor = true;
            // 
            // cbCtaCte
            // 
            this.cbCtaCte.AutoSize = true;
            this.cbCtaCte.Location = new System.Drawing.Point(148, 55);
            this.cbCtaCte.Name = "cbCtaCte";
            this.cbCtaCte.Size = new System.Drawing.Size(61, 17);
            this.cbCtaCte.TabIndex = 17;
            this.cbCtaCte.Text = "Cta Cte";
            this.cbCtaCte.UseVisualStyleBackColor = true;
            // 
            // cbCheque
            // 
            this.cbCheque.AutoSize = true;
            this.cbCheque.Location = new System.Drawing.Point(234, 55);
            this.cbCheque.Name = "cbCheque";
            this.cbCheque.Size = new System.Drawing.Size(63, 17);
            this.cbCheque.TabIndex = 18;
            this.cbCheque.Text = "Cheque";
            this.cbCheque.UseVisualStyleBackColor = true;
            // 
            // cbTarjeta
            // 
            this.cbTarjeta.AutoSize = true;
            this.cbTarjeta.Location = new System.Drawing.Point(319, 55);
            this.cbTarjeta.Name = "cbTarjeta";
            this.cbTarjeta.Size = new System.Drawing.Size(59, 17);
            this.cbTarjeta.TabIndex = 19;
            this.cbTarjeta.Text = "Tarjeta";
            this.cbTarjeta.UseVisualStyleBackColor = true;
            // 
            // FormularioDetalleCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 313);
            this.Controls.Add(this.cbTarjeta);
            this.Controls.Add(this.cbCheque);
            this.Controls.Add(this.cbCtaCte);
            this.Controls.Add(this.cbEfectivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.dgvGrilla);
            this.Name = "FormularioDetalleCaja";
            this.Text = "FormularioDetalleCaja";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbEfectivo;
        private System.Windows.Forms.CheckBox cbCtaCte;
        private System.Windows.Forms.CheckBox cbCheque;
        private System.Windows.Forms.CheckBox cbTarjeta;
    }
}