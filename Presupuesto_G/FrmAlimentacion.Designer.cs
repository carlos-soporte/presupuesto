﻿namespace Presupuesto_G
{
    partial class FrmAlimentacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlimentacion));
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtV_oficial = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTipoItem = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPresupuestoTotalOficial = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtV_ofertado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalOfertado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPorcentajeGanancias = new System.Windows.Forms.TextBox();
            this.txtGanancias = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPorcentajeEjecutado = new System.Windows.Forms.TextBox();
            this.txtC_entrega = new System.Windows.Forms.TextBox();
            this.txtC_restante = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItem
            // 
            this.txtItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtItem.Location = new System.Drawing.Point(27, 160);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(276, 29);
            this.txtItem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtCantidad.Location = new System.Drawing.Point(364, 160);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(80, 29);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "valor oficial";
            // 
            // txtV_oficial
            // 
            this.txtV_oficial.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtV_oficial.Location = new System.Drawing.Point(469, 160);
            this.txtV_oficial.Name = "txtV_oficial";
            this.txtV_oficial.Size = new System.Drawing.Size(164, 29);
            this.txtV_oficial.TabIndex = 2;
            this.txtV_oficial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtV_oficial_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(27, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1013, 286);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblTipoItem
            // 
            this.lblTipoItem.AutoSize = true;
            this.lblTipoItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTipoItem.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTipoItem.Location = new System.Drawing.Point(506, 23);
            this.lblTipoItem.Name = "lblTipoItem";
            this.lblTipoItem.Size = new System.Drawing.Size(157, 24);
            this.lblTipoItem.TabIndex = 13;
            this.lblTipoItem.Text = "ALIMENTACION";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Enabled = false;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(1055, 224);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(126, 44);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(1055, 274);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(126, 44);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 22);
            this.label5.TabIndex = 16;
            // 
            // txtPresupuestoTotalOficial
            // 
            this.txtPresupuestoTotalOficial.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtPresupuestoTotalOficial.Location = new System.Drawing.Point(221, 66);
            this.txtPresupuestoTotalOficial.Name = "txtPresupuestoTotalOficial";
            this.txtPresupuestoTotalOficial.Size = new System.Drawing.Size(172, 29);
            this.txtPresupuestoTotalOficial.TabIndex = 17;
            this.txtPresupuestoTotalOficial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPresupuestoTotalOficial_KeyPress);
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.DarkGray;
            this.btnAsignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnAsignar.FlatAppearance.BorderSize = 0;
            this.btnAsignar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnAsignar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.Location = new System.Drawing.Point(408, 60);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(126, 38);
            this.btnAsignar.TabIndex = 18;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "x";
            // 
            // txtV_ofertado
            // 
            this.txtV_ofertado.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtV_ofertado.Location = new System.Drawing.Point(653, 160);
            this.txtV_ofertado.Name = "txtV_ofertado";
            this.txtV_ofertado.Size = new System.Drawing.Size(164, 29);
            this.txtV_ofertado.TabIndex = 3;
            this.txtV_ofertado.TextChanged += new System.EventHandler(this.txtV_ofertado_TextChanged);
            this.txtV_ofertado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtV_ofertado_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(661, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 22);
            this.label7.TabIndex = 21;
            this.label7.Text = "valor ofertado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 22);
            this.label8.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "Presupuesto Oficial";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 537);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(266, 22);
            this.label10.TabIndex = 24;
            this.label10.Text = "Total Presupuesto Ofertado";
            // 
            // txtTotalOfertado
            // 
            this.txtTotalOfertado.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtTotalOfertado.Location = new System.Drawing.Point(295, 534);
            this.txtTotalOfertado.Name = "txtTotalOfertado";
            this.txtTotalOfertado.ReadOnly = true;
            this.txtTotalOfertado.Size = new System.Drawing.Size(172, 29);
            this.txtTotalOfertado.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(523, 537);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 22);
            this.label11.TabIndex = 26;
            this.label11.Text = "Total ganancias";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(512, 588);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 22);
            this.label12.TabIndex = 27;
            this.label12.Text = "Total % ganancia";
            // 
            // txtPorcentajeGanancias
            // 
            this.txtPorcentajeGanancias.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtPorcentajeGanancias.Location = new System.Drawing.Point(697, 585);
            this.txtPorcentajeGanancias.Name = "txtPorcentajeGanancias";
            this.txtPorcentajeGanancias.ReadOnly = true;
            this.txtPorcentajeGanancias.Size = new System.Drawing.Size(172, 29);
            this.txtPorcentajeGanancias.TabIndex = 28;
            // 
            // txtGanancias
            // 
            this.txtGanancias.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtGanancias.Location = new System.Drawing.Point(697, 534);
            this.txtGanancias.Name = "txtGanancias";
            this.txtGanancias.ReadOnly = true;
            this.txtGanancias.Size = new System.Drawing.Size(172, 29);
            this.txtGanancias.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(115, 588);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 22);
            this.label13.TabIndex = 30;
            this.label13.Text = "Total % ejecutado";
            // 
            // txtPorcentajeEjecutado
            // 
            this.txtPorcentajeEjecutado.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtPorcentajeEjecutado.Location = new System.Drawing.Point(295, 588);
            this.txtPorcentajeEjecutado.Name = "txtPorcentajeEjecutado";
            this.txtPorcentajeEjecutado.ReadOnly = true;
            this.txtPorcentajeEjecutado.Size = new System.Drawing.Size(172, 29);
            this.txtPorcentajeEjecutado.TabIndex = 31;
            // 
            // txtC_entrega
            // 
            this.txtC_entrega.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtC_entrega.Location = new System.Drawing.Point(835, 160);
            this.txtC_entrega.Name = "txtC_entrega";
            this.txtC_entrega.Size = new System.Drawing.Size(80, 29);
            this.txtC_entrega.TabIndex = 4;
            this.txtC_entrega.TextChanged += new System.EventHandler(this.txtC_entrega_TextChanged);
            this.txtC_entrega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC_entrega_KeyPress);
            // 
            // txtC_restante
            // 
            this.txtC_restante.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtC_restante.Location = new System.Drawing.Point(960, 160);
            this.txtC_restante.Name = "txtC_restante";
            this.txtC_restante.ReadOnly = true;
            this.txtC_restante.Size = new System.Drawing.Size(80, 29);
            this.txtC_restante.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(950, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 22);
            this.label14.TabIndex = 34;
            this.label14.Text = "C.Restante";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(819, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 22);
            this.label15.TabIndex = 35;
            this.label15.Text = "C.Entregada";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(1055, 151);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 44);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.DarkGray;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(1, -1);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(113, 35);
            this.btnMenu.TabIndex = 38;
            this.btnMenu.Text = "Menù";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnItem
            // 
            this.btnItem.BackColor = System.Drawing.Color.DarkGray;
            this.btnItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItem.FlatAppearance.BorderSize = 0;
            this.btnItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItem.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItem.Location = new System.Drawing.Point(130, -1);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(126, 35);
            this.btnItem.TabIndex = 39;
            this.btnItem.Text = "Items";
            this.btnItem.UseVisualStyleBackColor = false;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // FrmAlimentacion
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1205, 642);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtC_restante);
            this.Controls.Add(this.txtC_entrega);
            this.Controls.Add(this.txtPorcentajeEjecutado);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtGanancias);
            this.Controls.Add(this.txtPorcentajeGanancias);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotalOfertado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtV_ofertado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.txtPresupuestoTotalOficial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblTipoItem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtV_oficial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItem);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmAlimentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAlimentacion";
            this.Load += new System.EventHandler(this.FrmAlimentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtV_oficial;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTipoItem;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPresupuestoTotalOficial;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtV_ofertado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalOfertado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPorcentajeGanancias;
        private System.Windows.Forms.TextBox txtGanancias;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPorcentajeEjecutado;
        private System.Windows.Forms.TextBox txtC_entrega;
        private System.Windows.Forms.TextBox txtC_restante;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnItem;
    }
}