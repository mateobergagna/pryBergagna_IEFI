﻿namespace pryBergagna_IEFI
{
    partial class frmInicio
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
            this.menuInicio = new System.Windows.Forms.MenuStrip();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTareas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAuditoria = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarInicio = new System.Windows.Forms.StatusStrip();
            this.lblUsuarioActivo = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblTiempo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFechaInicio = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuInicio.SuspendLayout();
            this.statusBarInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuInicio
            // 
            this.menuInicio.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHome,
            this.mnuTareas,
            this.mnuAdmin});
            this.menuInicio.Location = new System.Drawing.Point(0, 0);
            this.menuInicio.Name = "menuInicio";
            this.menuInicio.Size = new System.Drawing.Size(800, 28);
            this.menuInicio.TabIndex = 2;
            this.menuInicio.Text = "menuStrip1";
            // 
            // mnuHome
            // 
            this.mnuHome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.mnuHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Size = new System.Drawing.Size(14, 24);
            // 
            // mnuSalir
            // 
            this.mnuSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(179, 26);
            this.mnuSalir.Text = "Cerrar Sesión";
            // 
            // mnuTareas
            // 
            this.mnuTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mnuTareas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuTareas.Name = "mnuTareas";
            this.mnuTareas.Size = new System.Drawing.Size(64, 24);
            this.mnuTareas.Text = "Tareas";
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuarios,
            this.mnuAuditoria});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(123, 24);
            this.mnuAdmin.Text = "Administración";
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(154, 26);
            this.mnuUsuarios.Text = "Usuarios";
            // 
            // mnuAuditoria
            // 
            this.mnuAuditoria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuAuditoria.Name = "mnuAuditoria";
            this.mnuAuditoria.Size = new System.Drawing.Size(154, 26);
            this.mnuAuditoria.Text = "Auditoria";
            // 
            // statusBarInicio
            // 
            this.statusBarInicio.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBarInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuarioActivo,
            this.LblTiempo,
            this.lblFechaInicio});
            this.statusBarInicio.Location = new System.Drawing.Point(0, 424);
            this.statusBarInicio.Name = "statusBarInicio";
            this.statusBarInicio.Size = new System.Drawing.Size(800, 26);
            this.statusBarInicio.TabIndex = 3;
            this.statusBarInicio.Text = "statusStrip1";
            // 
            // lblUsuarioActivo
            // 
            this.lblUsuarioActivo.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioActivo.Name = "lblUsuarioActivo";
            this.lblUsuarioActivo.Size = new System.Drawing.Size(115, 20);
            this.lblUsuarioActivo.Text = "Usuario Activo";
            // 
            // LblTiempo
            // 
            this.LblTiempo.Name = "LblTiempo";
            this.LblTiempo.Size = new System.Drawing.Size(623, 20);
            this.LblTiempo.Spring = true;
            this.LblTiempo.Text = "Tiempo";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(47, 20);
            this.lblFechaInicio.Text = "Fecha";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusBarInicio);
            this.Controls.Add(this.menuInicio);
            this.Name = "frmInicio";
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menuInicio.ResumeLayout(false);
            this.menuInicio.PerformLayout();
            this.statusBarInicio.ResumeLayout(false);
            this.statusBarInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuInicio;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuTareas;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuAuditoria;
        private System.Windows.Forms.StatusStrip statusBarInicio;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioActivo;
        private System.Windows.Forms.ToolStripStatusLabel LblTiempo;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaInicio;
    }
}