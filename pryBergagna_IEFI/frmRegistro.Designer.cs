namespace pryBergagna_IEFI
{
    partial class frmRegistro
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
            this.mrcRegistro = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkRecibo = new System.Windows.Forms.CheckBox();
            this.chkSalario = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkVacacion = new System.Windows.Forms.CheckBox();
            this.chkEstudio = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkInsumos = new System.Windows.Forms.CheckBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.cmbLugares = new System.Windows.Forms.ComboBox();
            this.cmbTareas = new System.Windows.Forms.ComboBox();
            this.dtpFechaTarea = new System.Windows.Forms.DateTimePicker();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblTarea = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mrcRegistro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcRegistro
            // 
            this.mrcRegistro.Controls.Add(this.btnCancelar);
            this.mrcRegistro.Controls.Add(this.groupBox2);
            this.mrcRegistro.Controls.Add(this.btnAgregar);
            this.mrcRegistro.Controls.Add(this.groupBox1);
            this.mrcRegistro.Controls.Add(this.cmbLugares);
            this.mrcRegistro.Controls.Add(this.cmbTareas);
            this.mrcRegistro.Controls.Add(this.dtpFechaTarea);
            this.mrcRegistro.Controls.Add(this.lblLugar);
            this.mrcRegistro.Controls.Add(this.lblTarea);
            this.mrcRegistro.Controls.Add(this.lblFecha);
            this.mrcRegistro.Location = new System.Drawing.Point(13, 13);
            this.mrcRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.mrcRegistro.Name = "mrcRegistro";
            this.mrcRegistro.Padding = new System.Windows.Forms.Padding(4);
            this.mrcRegistro.Size = new System.Drawing.Size(749, 352);
            this.mrcRegistro.TabIndex = 2;
            this.mrcRegistro.TabStop = false;
            this.mrcRegistro.Text = "Nueva Registro";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(577, 280);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(149, 39);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(577, 235);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(149, 39);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtComentarios);
            this.groupBox2.Location = new System.Drawing.Point(22, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 142);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comentarios";
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(6, 27);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(385, 109);
            this.txtComentarios.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkRecibo);
            this.groupBox1.Controls.Add(this.chkSalario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkVacacion);
            this.groupBox1.Controls.Add(this.chkEstudio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkInsumos);
            this.groupBox1.Controls.Add(this.lbltelefono);
            this.groupBox1.Location = new System.Drawing.Point(332, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 151);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // chkRecibo
            // 
            this.chkRecibo.AutoSize = true;
            this.chkRecibo.Location = new System.Drawing.Point(251, 97);
            this.chkRecibo.Name = "chkRecibo";
            this.chkRecibo.Size = new System.Drawing.Size(73, 20);
            this.chkRecibo.TabIndex = 24;
            this.chkRecibo.Text = "Recibo";
            this.chkRecibo.UseVisualStyleBackColor = true;
            // 
            // chkSalario
            // 
            this.chkSalario.AutoSize = true;
            this.chkSalario.Location = new System.Drawing.Point(251, 59);
            this.chkSalario.Name = "chkSalario";
            this.chkSalario.Size = new System.Drawing.Size(72, 20);
            this.chkSalario.TabIndex = 23;
            this.chkSalario.Text = "Salario";
            this.chkSalario.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Reclamo:";
            // 
            // chkVacacion
            // 
            this.chkVacacion.AutoSize = true;
            this.chkVacacion.Location = new System.Drawing.Point(131, 97);
            this.chkVacacion.Name = "chkVacacion";
            this.chkVacacion.Size = new System.Drawing.Size(86, 20);
            this.chkVacacion.TabIndex = 21;
            this.chkVacacion.Text = "Vacación";
            this.chkVacacion.UseVisualStyleBackColor = true;
            // 
            // chkEstudio
            // 
            this.chkEstudio.AutoSize = true;
            this.chkEstudio.Location = new System.Drawing.Point(131, 59);
            this.chkEstudio.Name = "chkEstudio";
            this.chkEstudio.Size = new System.Drawing.Size(74, 20);
            this.chkEstudio.TabIndex = 20;
            this.chkEstudio.Text = "Estudio";
            this.chkEstudio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Licencia:";
            // 
            // chkInsumos
            // 
            this.chkInsumos.AutoSize = true;
            this.chkInsumos.Location = new System.Drawing.Point(16, 59);
            this.chkInsumos.Name = "chkInsumos";
            this.chkInsumos.Size = new System.Drawing.Size(79, 20);
            this.chkInsumos.TabIndex = 18;
            this.chkInsumos.Text = "Insumos";
            this.chkInsumos.UseVisualStyleBackColor = true;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.Location = new System.Drawing.Point(12, 30);
            this.lbltelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(75, 20);
            this.lbltelefono.TabIndex = 10;
            this.lbltelefono.Text = "Uniforme:";
            // 
            // cmbLugares
            // 
            this.cmbLugares.FormattingEnabled = true;
            this.cmbLugares.Location = new System.Drawing.Point(24, 164);
            this.cmbLugares.Name = "cmbLugares";
            this.cmbLugares.Size = new System.Drawing.Size(263, 24);
            this.cmbLugares.TabIndex = 17;
            // 
            // cmbTareas
            // 
            this.cmbTareas.FormattingEnabled = true;
            this.cmbTareas.Location = new System.Drawing.Point(22, 113);
            this.cmbTareas.Name = "cmbTareas";
            this.cmbTareas.Size = new System.Drawing.Size(265, 24);
            this.cmbTareas.TabIndex = 16;
            // 
            // dtpFechaTarea
            // 
            this.dtpFechaTarea.Location = new System.Drawing.Point(23, 56);
            this.dtpFechaTarea.Name = "dtpFechaTarea";
            this.dtpFechaTarea.Size = new System.Drawing.Size(264, 22);
            this.dtpFechaTarea.TabIndex = 15;
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugar.Location = new System.Drawing.Point(21, 145);
            this.lblLugar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(47, 20);
            this.lblLugar.TabIndex = 11;
            this.lblLugar.Text = "Lugar";
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarea.Location = new System.Drawing.Point(19, 94);
            this.lblTarea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(46, 20);
            this.lblTarea.TabIndex = 4;
            this.lblTarea.Text = "Tarea";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(20, 37);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 372);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(743, 208);
            this.dataGridView1.TabIndex = 3;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 596);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mrcRegistro);
            this.Name = "frmRegistro";
            this.Text = "Registrar Tarea";
            this.mrcRegistro.ResumeLayout(false);
            this.mrcRegistro.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcRegistro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkRecibo;
        private System.Windows.Forms.CheckBox chkSalario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkVacacion;
        private System.Windows.Forms.CheckBox chkEstudio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkInsumos;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.ComboBox cmbLugares;
        private System.Windows.Forms.ComboBox cmbTareas;
        private System.Windows.Forms.DateTimePicker dtpFechaTarea;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}