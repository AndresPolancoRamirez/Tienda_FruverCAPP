namespace AplicationLayer
{
    partial class frmBuscarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFin = new System.Windows.Forms.Button();
            this.dgvRegistroCliente = new System.Windows.Forms.DataGridView();
            this.clmTipo_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumero_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrimer_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSegundo_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrimer_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSegundo_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNumero_Documento = new System.Windows.Forms.TextBox();
            this.cmbTipo_Documento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFin);
            this.groupBox1.Controls.Add(this.dgvRegistroCliente);
            this.groupBox1.Controls.Add(this.txtNumero_Documento);
            this.groupBox1.Controls.Add(this.cmbTipo_Documento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1526, 805);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnFin
            // 
            this.btnFin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnFin.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFin.Image = ((System.Drawing.Image)(resources.GetObject("btnFin.Image")));
            this.btnFin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFin.Location = new System.Drawing.Point(975, 230);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(121, 66);
            this.btnFin.TabIndex = 31;
            this.btnFin.Text = "Buscar";
            this.btnFin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFin.UseVisualStyleBackColor = false;
            // 
            // dgvRegistroCliente
            // 
            this.dgvRegistroCliente.AllowUserToAddRows = false;
            this.dgvRegistroCliente.AllowUserToDeleteRows = false;
            this.dgvRegistroCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistroCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegistroCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTipo_Documento,
            this.clmNumero_Documento,
            this.clmPrimer_Nombre,
            this.clmSegundo_Nombre,
            this.clmPrimer_Apellido,
            this.clmSegundo_Apellido,
            this.clmEmail,
            this.clmTelefono,
            this.clmDireccion});
            this.dgvRegistroCliente.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvRegistroCliente.Location = new System.Drawing.Point(101, 473);
            this.dgvRegistroCliente.Name = "dgvRegistroCliente";
            this.dgvRegistroCliente.ReadOnly = true;
            this.dgvRegistroCliente.Size = new System.Drawing.Size(1344, 146);
            this.dgvRegistroCliente.TabIndex = 24;
            // 
            // clmTipo_Documento
            // 
            this.clmTipo_Documento.DataPropertyName = "tipo_documento";
            this.clmTipo_Documento.HeaderText = "Tipo Documento";
            this.clmTipo_Documento.Name = "clmTipo_Documento";
            this.clmTipo_Documento.ReadOnly = true;
            this.clmTipo_Documento.Width = 150;
            // 
            // clmNumero_Documento
            // 
            this.clmNumero_Documento.DataPropertyName = "numero_documento";
            this.clmNumero_Documento.HeaderText = "Numero Documento";
            this.clmNumero_Documento.Name = "clmNumero_Documento";
            this.clmNumero_Documento.ReadOnly = true;
            this.clmNumero_Documento.Width = 150;
            // 
            // clmPrimer_Nombre
            // 
            this.clmPrimer_Nombre.DataPropertyName = "primer_nombre";
            this.clmPrimer_Nombre.HeaderText = "Primer Nombre";
            this.clmPrimer_Nombre.Name = "clmPrimer_Nombre";
            this.clmPrimer_Nombre.ReadOnly = true;
            this.clmPrimer_Nombre.Width = 150;
            // 
            // clmSegundo_Nombre
            // 
            this.clmSegundo_Nombre.DataPropertyName = "segundo_nombre";
            this.clmSegundo_Nombre.HeaderText = "Segundo Nombre";
            this.clmSegundo_Nombre.Name = "clmSegundo_Nombre";
            this.clmSegundo_Nombre.ReadOnly = true;
            this.clmSegundo_Nombre.Width = 150;
            // 
            // clmPrimer_Apellido
            // 
            this.clmPrimer_Apellido.DataPropertyName = "primer_apellido";
            this.clmPrimer_Apellido.HeaderText = "Primer Apellido";
            this.clmPrimer_Apellido.Name = "clmPrimer_Apellido";
            this.clmPrimer_Apellido.ReadOnly = true;
            this.clmPrimer_Apellido.Width = 150;
            // 
            // clmSegundo_Apellido
            // 
            this.clmSegundo_Apellido.DataPropertyName = "segundo_apellido";
            this.clmSegundo_Apellido.HeaderText = "Segundo Apellido";
            this.clmSegundo_Apellido.Name = "clmSegundo_Apellido";
            this.clmSegundo_Apellido.ReadOnly = true;
            this.clmSegundo_Apellido.Width = 150;
            // 
            // clmEmail
            // 
            this.clmEmail.DataPropertyName = "email";
            this.clmEmail.HeaderText = "Correo Electronico";
            this.clmEmail.Name = "clmEmail";
            this.clmEmail.ReadOnly = true;
            this.clmEmail.Width = 150;
            // 
            // clmTelefono
            // 
            this.clmTelefono.DataPropertyName = "telefono";
            this.clmTelefono.HeaderText = "Telefono";
            this.clmTelefono.Name = "clmTelefono";
            this.clmTelefono.ReadOnly = true;
            // 
            // clmDireccion
            // 
            this.clmDireccion.DataPropertyName = "direccion";
            this.clmDireccion.HeaderText = "Direccion";
            this.clmDireccion.Name = "clmDireccion";
            this.clmDireccion.ReadOnly = true;
            this.clmDireccion.Width = 150;
            // 
            // txtNumero_Documento
            // 
            this.txtNumero_Documento.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero_Documento.Location = new System.Drawing.Point(700, 263);
            this.txtNumero_Documento.Name = "txtNumero_Documento";
            this.txtNumero_Documento.Size = new System.Drawing.Size(190, 33);
            this.txtNumero_Documento.TabIndex = 17;
            // 
            // cmbTipo_Documento
            // 
            this.cmbTipo_Documento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmbTipo_Documento.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo_Documento.FormattingEnabled = true;
            this.cmbTipo_Documento.Items.AddRange(new object[] {
            "Buscar Por Numero C.C",
            "Buscar Por Nombre",
            "Buscar Por Apellido"});
            this.cmbTipo_Documento.Location = new System.Drawing.Point(317, 263);
            this.cmbTipo_Documento.Name = "cmbTipo_Documento";
            this.cmbTipo_Documento.Size = new System.Drawing.Size(279, 33);
            this.cmbTipo_Documento.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1520, 72);
            this.label2.TabIndex = 15;
            this.label2.Text = "Buscar Clientes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBuscarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 829);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBuscarClientes";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipo_Documento;
        private System.Windows.Forms.TextBox txtNumero_Documento;
        private System.Windows.Forms.DataGridView dgvRegistroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipo_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumero_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrimer_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSegundo_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrimer_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSegundo_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDireccion;
        private System.Windows.Forms.Button btnFin;
    }
}