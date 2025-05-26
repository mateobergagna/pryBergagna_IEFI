namespace pryBergagna_IEFI
{
    partial class frmUsuarios
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusUsuario = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.mrcUsuarios = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtConUsuario = new System.Windows.Forms.TextBox();
            this.lblContUsuario = new System.Windows.Forms.Label();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.mrcUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(235, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 35);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusUsuario
            // 
            this.txtBusUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusUsuario.Location = new System.Drawing.Point(13, 12);
            this.txtBusUsuario.Multiline = true;
            this.txtBusUsuario.Name = "txtBusUsuario";
            this.txtBusUsuario.Size = new System.Drawing.Size(216, 32);
            this.txtBusUsuario.TabIndex = 14;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(668, 9);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 35);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(575, 9);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(87, 35);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(294, 51);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(464, 304);
            this.dgvUsuarios.TabIndex = 13;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // mrcUsuarios
            // 
            this.mrcUsuarios.Controls.Add(this.btnEliminar);
            this.mrcUsuarios.Controls.Add(this.btnModificar);
            this.mrcUsuarios.Controls.Add(this.btnNuevo);
            this.mrcUsuarios.Controls.Add(this.txtConUsuario);
            this.mrcUsuarios.Controls.Add(this.lblContUsuario);
            this.mrcUsuarios.Controls.Add(this.txtNomUsuario);
            this.mrcUsuarios.Controls.Add(this.lblNomUsuario);
            this.mrcUsuarios.Location = new System.Drawing.Point(13, 51);
            this.mrcUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.mrcUsuarios.Name = "mrcUsuarios";
            this.mrcUsuarios.Padding = new System.Windows.Forms.Padding(4);
            this.mrcUsuarios.Size = new System.Drawing.Size(273, 304);
            this.mrcUsuarios.TabIndex = 12;
            this.mrcUsuarios.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(23, 255);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(216, 39);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(23, 210);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(216, 39);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(23, 165);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(216, 39);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtConUsuario
            // 
            this.txtConUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConUsuario.Location = new System.Drawing.Point(23, 118);
            this.txtConUsuario.Name = "txtConUsuario";
            this.txtConUsuario.Size = new System.Drawing.Size(216, 29);
            this.txtConUsuario.TabIndex = 5;
            // 
            // lblContUsuario
            // 
            this.lblContUsuario.AutoSize = true;
            this.lblContUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContUsuario.Location = new System.Drawing.Point(20, 95);
            this.lblContUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContUsuario.Name = "lblContUsuario";
            this.lblContUsuario.Size = new System.Drawing.Size(85, 20);
            this.lblContUsuario.TabIndex = 4;
            this.lblContUsuario.Text = "Contraseña";
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomUsuario.Location = new System.Drawing.Point(23, 49);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(216, 29);
            this.txtNomUsuario.TabIndex = 3;
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUsuario.Location = new System.Drawing.Point(20, 26);
            this.lblNomUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(60, 20);
            this.lblNomUsuario.TabIndex = 2;
            this.lblNomUsuario.Text = "Usuario";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 373);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.mrcUsuarios);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.mrcUsuarios.ResumeLayout(false);
            this.mrcUsuarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox mrcUsuarios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtConUsuario;
        private System.Windows.Forms.Label lblContUsuario;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.Label lblNomUsuario;
    }
}