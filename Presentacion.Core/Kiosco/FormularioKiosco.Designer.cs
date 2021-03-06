﻿namespace Presentacion.Core.Kiosco
{
    partial class FormularioKiosco
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
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.nudDescuento = new System.Windows.Forms.NumericUpDown();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.nudSubTotal = new System.Windows.Forms.NumericUpDown();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCheque = new System.Windows.Forms.RadioButton();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.rbCtaCte = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.groupBoxEmpleado = new System.Windows.Forms.GroupBox();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUsuarioEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.gbTarjeta = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtClaveTarjeta = new System.Windows.Forms.TextBox();
            this.cbPlan = new System.Windows.Forms.ComboBox();
            this.cbTarjeta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.nudCantidadArticulo = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.gbCheque = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtFechaCheque = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.nudDiasCheque = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNumeroCheque = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEnteCheque = new System.Windows.Forms.TextBox();
            this.cbBanco = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.groupBoxEmpleado.SuspendLayout();
            this.gbTarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadArticulo)).BeginInit();
            this.gbCheque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasCheque)).BeginInit();
            this.SuspendLayout();
            // 
            // nudTotal
            // 
            this.nudTotal.DecimalPlaces = 2;
            this.nudTotal.Enabled = false;
            this.nudTotal.InterceptArrowKeys = false;
            this.nudTotal.Location = new System.Drawing.Point(798, 626);
            this.nudTotal.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudTotal.Name = "nudTotal";
            this.nudTotal.ReadOnly = true;
            this.nudTotal.Size = new System.Drawing.Size(70, 20);
            this.nudTotal.TabIndex = 39;
            this.nudTotal.ThousandsSeparator = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(696, 621);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(85, 25);
            this.lblTotal.TabIndex = 38;
            this.lblTotal.Text = "TOTAL";
            // 
            // nudDescuento
            // 
            this.nudDescuento.Location = new System.Drawing.Point(799, 588);
            this.nudDescuento.Name = "nudDescuento";
            this.nudDescuento.Size = new System.Drawing.Size(70, 20);
            this.nudDescuento.TabIndex = 37;
            this.nudDescuento.ValueChanged += new System.EventHandler(this.NudDescuento_ValueChanged);
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(617, 583);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(165, 25);
            this.lblDescuento.TabIndex = 36;
            this.lblDescuento.Text = "Descuento [%]";
            // 
            // nudSubTotal
            // 
            this.nudSubTotal.DecimalPlaces = 2;
            this.nudSubTotal.Enabled = false;
            this.nudSubTotal.InterceptArrowKeys = false;
            this.nudSubTotal.Location = new System.Drawing.Point(798, 554);
            this.nudSubTotal.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudSubTotal.Name = "nudSubTotal";
            this.nudSubTotal.ReadOnly = true;
            this.nudSubTotal.Size = new System.Drawing.Size(70, 20);
            this.nudSubTotal.TabIndex = 35;
            this.nudSubTotal.ThousandsSeparator = true;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(667, 549);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(114, 25);
            this.lblSubTotal.TabIndex = 34;
            this.lblSubTotal.Text = "Sub-Total";
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(27, 67);
            this.dgvGrilla.MultiSelect = false;
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrilla.Size = new System.Drawing.Size(845, 253);
            this.dgvGrilla.TabIndex = 24;
            this.dgvGrilla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGrilla_CellDoubleClick);
            this.dgvGrilla.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGrilla_CellValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCheque);
            this.groupBox1.Controls.Add(this.rbTarjeta);
            this.groupBox1.Controls.Add(this.rbCtaCte);
            this.groupBox1.Controls.Add(this.rbEfectivo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(619, 328);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(249, 169);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO PAGO";
            // 
            // rbCheque
            // 
            this.rbCheque.AutoSize = true;
            this.rbCheque.Location = new System.Drawing.Point(20, 130);
            this.rbCheque.Name = "rbCheque";
            this.rbCheque.Size = new System.Drawing.Size(89, 24);
            this.rbCheque.TabIndex = 35;
            this.rbCheque.TabStop = true;
            this.rbCheque.Text = "Cheque";
            this.rbCheque.UseVisualStyleBackColor = true;
            this.rbCheque.CheckedChanged += new System.EventHandler(this.rbCheque_CheckedChanged);
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.Location = new System.Drawing.Point(20, 97);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(83, 24);
            this.rbTarjeta.TabIndex = 34;
            this.rbTarjeta.TabStop = true;
            this.rbTarjeta.Text = "Tarjeta";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbCtaCte
            // 
            this.rbCtaCte.AutoSize = true;
            this.rbCtaCte.Location = new System.Drawing.Point(20, 62);
            this.rbCtaCte.Name = "rbCtaCte";
            this.rbCtaCte.Size = new System.Drawing.Size(164, 24);
            this.rbCtaCte.TabIndex = 33;
            this.rbCtaCte.TabStop = true;
            this.rbCtaCte.Text = "Cuenta Corriente";
            this.rbCtaCte.UseVisualStyleBackColor = true;
            this.rbCtaCte.CheckedChanged += new System.EventHandler(this.RbCtaCte_CheckedChanged);
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Checked = true;
            this.rbEfectivo.Location = new System.Drawing.Point(20, 31);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(92, 24);
            this.rbEfectivo.TabIndex = 32;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            this.rbEfectivo.CheckedChanged += new System.EventHandler(this.RbEfectivo_CheckedChanged);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.txtNombreCliente);
            this.gbCliente.Controls.Add(this.label5);
            this.gbCliente.Controls.Add(this.txtApellidoCliente);
            this.gbCliente.Controls.Add(this.btnBuscarCliente);
            this.gbCliente.Controls.Add(this.label4);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Controls.Add(this.txtDniCliente);
            this.gbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbCliente.Location = new System.Drawing.Point(319, 328);
            this.gbCliente.Margin = new System.Windows.Forms.Padding(2);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Padding = new System.Windows.Forms.Padding(2);
            this.gbCliente.Size = new System.Drawing.Size(289, 172);
            this.gbCliente.TabIndex = 41;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "CLIENTE";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(104, 95);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(181, 26);
            this.txtNombreCliente.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(104, 63);
            this.txtApellidoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.ReadOnly = true;
            this.txtApellidoCliente.Size = new System.Drawing.Size(181, 26);
            this.txtApellidoCliente.TabIndex = 7;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnBuscarCliente.Location = new System.Drawing.Point(104, 132);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(180, 23);
            this.btnBuscarCliente.TabIndex = 45;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dni";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido";
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(104, 29);
            this.txtDniCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.ReadOnly = true;
            this.txtDniCliente.Size = new System.Drawing.Size(181, 26);
            this.txtDniCliente.TabIndex = 5;
            // 
            // groupBoxEmpleado
            // 
            this.groupBoxEmpleado.Controls.Add(this.txtApellidoEmpleado);
            this.groupBoxEmpleado.Controls.Add(this.btnBuscarEmpleado);
            this.groupBoxEmpleado.Controls.Add(this.label9);
            this.groupBoxEmpleado.Controls.Add(this.txtUsuarioEmpleado);
            this.groupBoxEmpleado.Controls.Add(this.label2);
            this.groupBoxEmpleado.Controls.Add(this.txtNombreEmpleado);
            this.groupBoxEmpleado.Controls.Add(this.label6);
            this.groupBoxEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxEmpleado.Location = new System.Drawing.Point(26, 325);
            this.groupBoxEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxEmpleado.Name = "groupBoxEmpleado";
            this.groupBoxEmpleado.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxEmpleado.Size = new System.Drawing.Size(278, 172);
            this.groupBoxEmpleado.TabIndex = 40;
            this.groupBoxEmpleado.TabStop = false;
            this.groupBoxEmpleado.Text = "VENDEDOR";
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.Enabled = false;
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(84, 69);
            this.txtApellidoEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.ReadOnly = true;
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(189, 26);
            this.txtApellidoEmpleado.TabIndex = 11;
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Enabled = false;
            this.btnBuscarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(84, 144);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(189, 23);
            this.btnBuscarEmpleado.TabIndex = 46;
            this.btnBuscarEmpleado.Text = "Buscar Empleado";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 69);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Apellido";
            // 
            // txtUsuarioEmpleado
            // 
            this.txtUsuarioEmpleado.Enabled = false;
            this.txtUsuarioEmpleado.Location = new System.Drawing.Point(84, 31);
            this.txtUsuarioEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuarioEmpleado.Name = "txtUsuarioEmpleado";
            this.txtUsuarioEmpleado.ReadOnly = true;
            this.txtUsuarioEmpleado.Size = new System.Drawing.Size(189, 26);
            this.txtUsuarioEmpleado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Enabled = false;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(84, 106);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.ReadOnly = true;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(189, 26);
            this.txtNombreEmpleado.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Usuario";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnFacturar.Location = new System.Drawing.Point(629, 655);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(244, 36);
            this.btnFacturar.TabIndex = 43;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.BtnFacturar_Click);
            // 
            // gbTarjeta
            // 
            this.gbTarjeta.Controls.Add(this.label11);
            this.gbTarjeta.Controls.Add(this.txtNumeroTarjeta);
            this.gbTarjeta.Controls.Add(this.label10);
            this.gbTarjeta.Controls.Add(this.txtClaveTarjeta);
            this.gbTarjeta.Controls.Add(this.cbPlan);
            this.gbTarjeta.Controls.Add(this.cbTarjeta);
            this.gbTarjeta.Controls.Add(this.label7);
            this.gbTarjeta.Controls.Add(this.label8);
            this.gbTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbTarjeta.Location = new System.Drawing.Point(27, 501);
            this.gbTarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.gbTarjeta.Name = "gbTarjeta";
            this.gbTarjeta.Padding = new System.Windows.Forms.Padding(2);
            this.gbTarjeta.Size = new System.Drawing.Size(277, 187);
            this.gbTarjeta.TabIndex = 41;
            this.gbTarjeta.TabStop = false;
            this.gbTarjeta.Text = "TARJETA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 157);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "Número";
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(74, 157);
            this.txtNumeroTarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(198, 26);
            this.txtNumeroTarjeta.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 121);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 46;
            this.label10.Text = "Clave";
            // 
            // txtClaveTarjeta
            // 
            this.txtClaveTarjeta.Location = new System.Drawing.Point(74, 121);
            this.txtClaveTarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.txtClaveTarjeta.Name = "txtClaveTarjeta";
            this.txtClaveTarjeta.Size = new System.Drawing.Size(198, 26);
            this.txtClaveTarjeta.TabIndex = 47;
            // 
            // cbPlan
            // 
            this.cbPlan.Enabled = false;
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.Location = new System.Drawing.Point(74, 73);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(198, 28);
            this.cbPlan.TabIndex = 4;
            // 
            // cbTarjeta
            // 
            this.cbTarjeta.Enabled = false;
            this.cbTarjeta.FormattingEnabled = true;
            this.cbTarjeta.Location = new System.Drawing.Point(74, 26);
            this.cbTarjeta.Name = "cbTarjeta";
            this.cbTarjeta.Size = new System.Drawing.Size(198, 28);
            this.cbTarjeta.TabIndex = 3;
            this.cbTarjeta.SelectedIndexChanged += new System.EventHandler(this.cbTarjeta_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Plan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tarjeta";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.Location = new System.Drawing.Point(513, 7);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(59, 20);
            this.lblPrecioUnitario.TabIndex = 58;
            this.lblPrecioUnitario.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(517, 34);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(96, 20);
            this.txtPrecio.TabIndex = 57;
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Location = new System.Drawing.Point(798, 28);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(74, 25);
            this.btnBuscarArticulo.TabIndex = 56;
            this.btnBuscarArticulo.Text = "Buscar";
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(718, 28);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(74, 27);
            this.btnAgregar.TabIndex = 55;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // nudCantidadArticulo
            // 
            this.nudCantidadArticulo.AllowDrop = true;
            this.nudCantidadArticulo.DecimalPlaces = 2;
            this.nudCantidadArticulo.Location = new System.Drawing.Point(619, 34);
            this.nudCantidadArticulo.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudCantidadArticulo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadArticulo.Name = "nudCantidadArticulo";
            this.nudCantidadArticulo.Size = new System.Drawing.Size(92, 20);
            this.nudCantidadArticulo.TabIndex = 54;
            this.nudCantidadArticulo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(616, 9);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(74, 18);
            this.lblCantidad.TabIndex = 53;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(152, 8);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(103, 20);
            this.lblDescripcion.TabIndex = 52;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(156, 35);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(355, 20);
            this.txtDescripcion.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Codigo Barras";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(26, 34);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(120, 20);
            this.txtCodigoBarras.TabIndex = 49;
            this.txtCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarras_KeyPress);
            // 
            // gbCheque
            // 
            this.gbCheque.Controls.Add(this.label16);
            this.gbCheque.Controls.Add(this.dtFechaCheque);
            this.gbCheque.Controls.Add(this.label14);
            this.gbCheque.Controls.Add(this.nudDiasCheque);
            this.gbCheque.Controls.Add(this.label12);
            this.gbCheque.Controls.Add(this.txtNumeroCheque);
            this.gbCheque.Controls.Add(this.label13);
            this.gbCheque.Controls.Add(this.txtEnteCheque);
            this.gbCheque.Controls.Add(this.cbBanco);
            this.gbCheque.Controls.Add(this.label15);
            this.gbCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbCheque.Location = new System.Drawing.Point(319, 504);
            this.gbCheque.Margin = new System.Windows.Forms.Padding(2);
            this.gbCheque.Name = "gbCheque";
            this.gbCheque.Padding = new System.Windows.Forms.Padding(2);
            this.gbCheque.Size = new System.Drawing.Size(289, 196);
            this.gbCheque.TabIndex = 50;
            this.gbCheque.TabStop = false;
            this.gbCheque.Text = "CHEQUE";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 65);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 20);
            this.label16.TabIndex = 62;
            this.label16.Text = "Fecha";
            // 
            // dtFechaCheque
            // 
            this.dtFechaCheque.Enabled = false;
            this.dtFechaCheque.Location = new System.Drawing.Point(82, 60);
            this.dtFechaCheque.MaxDate = new System.DateTime(2020, 7, 30, 0, 0, 0, 0);
            this.dtFechaCheque.Name = "dtFechaCheque";
            this.dtFechaCheque.Size = new System.Drawing.Size(202, 26);
            this.dtFechaCheque.TabIndex = 61;
            this.dtFechaCheque.Value = new System.DateTime(2020, 7, 30, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 171);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 20);
            this.label14.TabIndex = 60;
            this.label14.Text = "Días";
            // 
            // nudDiasCheque
            // 
            this.nudDiasCheque.Enabled = false;
            this.nudDiasCheque.Location = new System.Drawing.Point(82, 165);
            this.nudDiasCheque.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDiasCheque.Name = "nudDiasCheque";
            this.nudDiasCheque.Size = new System.Drawing.Size(202, 26);
            this.nudDiasCheque.TabIndex = 59;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 137);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 48;
            this.label12.Text = "Número";
            // 
            // txtNumeroCheque
            // 
            this.txtNumeroCheque.Enabled = false;
            this.txtNumeroCheque.Location = new System.Drawing.Point(82, 134);
            this.txtNumeroCheque.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroCheque.Name = "txtNumeroCheque";
            this.txtNumeroCheque.Size = new System.Drawing.Size(202, 26);
            this.txtNumeroCheque.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(0, 99);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 20);
            this.label13.TabIndex = 46;
            this.label13.Text = "Ente Em";
            // 
            // txtEnteCheque
            // 
            this.txtEnteCheque.Enabled = false;
            this.txtEnteCheque.Location = new System.Drawing.Point(82, 98);
            this.txtEnteCheque.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnteCheque.Name = "txtEnteCheque";
            this.txtEnteCheque.Size = new System.Drawing.Size(202, 26);
            this.txtEnteCheque.TabIndex = 47;
            // 
            // cbBanco
            // 
            this.cbBanco.Enabled = false;
            this.cbBanco.FormattingEnabled = true;
            this.cbBanco.Location = new System.Drawing.Point(82, 26);
            this.cbBanco.Name = "cbBanco";
            this.cbBanco.Size = new System.Drawing.Size(202, 28);
            this.cbBanco.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 34);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Banco";
            // 
            // FormularioKiosco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 699);
            this.Controls.Add(this.gbCheque);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.gbTarjeta);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnBuscarArticulo);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nudCantidadArticulo);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.groupBoxEmpleado);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.nudTotal);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.nudDescuento);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.nudSubTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.dgvGrilla);
            this.MaximumSize = new System.Drawing.Size(900, 800);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "FormularioKiosco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioKiosco";
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.groupBoxEmpleado.ResumeLayout(false);
            this.groupBoxEmpleado.PerformLayout();
            this.gbTarjeta.ResumeLayout(false);
            this.gbTarjeta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadArticulo)).EndInit();
            this.gbCheque.ResumeLayout(false);
            this.gbCheque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasCheque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.NumericUpDown nudDescuento;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.NumericUpDown nudSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
        protected System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCtaCte;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.GroupBox groupBoxEmpleado;
        private System.Windows.Forms.TextBox txtUsuarioEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.RadioButton rbCheque;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.GroupBox gbTarjeta;
        private System.Windows.Forms.ComboBox cbPlan;
        private System.Windows.Forms.ComboBox cbTarjeta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown nudCantidadArticulo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumeroTarjeta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtClaveTarjeta;
        private System.Windows.Forms.GroupBox gbCheque;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNumeroCheque;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEnteCheque;
        private System.Windows.Forms.ComboBox cbBanco;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudDiasCheque;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtFechaCheque;
    }
}