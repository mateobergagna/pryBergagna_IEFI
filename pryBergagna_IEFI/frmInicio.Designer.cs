namespace pryBergagna_IEFI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.menuInicio = new System.Windows.Forms.MenuStrip();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTareas = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAuditoria = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarInicio = new System.Windows.Forms.StatusStrip();
            this.lblUsuarioActivo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTiempo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFechaInicio = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuInicio.SuspendLayout();
            this.statusBarInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuInicio
            // 
            this.menuInicio.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuInicio.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuInicio.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHome,
            this.mnuTareas,
            this.mnuAdmin});
            this.menuInicio.Location = new System.Drawing.Point(0, 0);
            this.menuInicio.Name = "menuInicio";
            this.menuInicio.Size = new System.Drawing.Size(1017, 33);
            this.menuInicio.TabIndex = 2;
            this.menuInicio.Text = "menuStrip1";
            // 
            // mnuHome
            // 
            this.mnuHome.BackgroundImage = global::pryBergagna_IEFI.Properties.Resources.cerrar;
            this.mnuHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mnuHome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.mnuHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Size = new System.Drawing.Size(14, 29);
            // 
            // mnuSalir
            // 
            this.mnuSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(209, 30);
            this.mnuSalir.Text = "Cerrar Sesión";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // mnuTareas
            // 
            this.mnuTareas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosTareasToolStripMenuItem,
            this.tareasToolStripMenuItem});
            this.mnuTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mnuTareas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuTareas.Name = "mnuTareas";
            this.mnuTareas.Size = new System.Drawing.Size(77, 29);
            this.mnuTareas.Text = "Tareas";
            // 
            // registrosTareasToolStripMenuItem
            // 
            this.registrosTareasToolStripMenuItem.Name = "registrosTareasToolStripMenuItem";
            this.registrosTareasToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.registrosTareasToolStripMenuItem.Text = "Registros Tareas";
            this.registrosTareasToolStripMenuItem.Click += new System.EventHandler(this.registrosTareasToolStripMenuItem_Click);
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.tareasToolStripMenuItem.Text = "Tareas";
            this.tareasToolStripMenuItem.Click += new System.EventHandler(this.tareasToolStripMenuItem_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuarios,
            this.mnuAuditoria});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(152, 29);
            this.mnuAdmin.Text = "Administración";
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(176, 30);
            this.mnuUsuarios.Text = "Usuarios";
            this.mnuUsuarios.Click += new System.EventHandler(this.mnuUsuarios_Click);
            // 
            // mnuAuditoria
            // 
            this.mnuAuditoria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuAuditoria.Name = "mnuAuditoria";
            this.mnuAuditoria.Size = new System.Drawing.Size(176, 30);
            this.mnuAuditoria.Text = "Auditoria";
            this.mnuAuditoria.Click += new System.EventHandler(this.mnuAuditoria_Click);
            // 
            // statusBarInicio
            // 
            this.statusBarInicio.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBarInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuarioActivo,
            this.lblTiempo,
            this.lblFechaInicio,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusBarInicio.Location = new System.Drawing.Point(0, 479);
            this.statusBarInicio.Name = "statusBarInicio";
            this.statusBarInicio.Size = new System.Drawing.Size(1017, 26);
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
            // lblTiempo
            // 
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(840, 20);
            this.lblTiempo.Spring = true;
            this.lblTiempo.Text = "Tiempo";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(47, 20);
            this.lblFechaInicio.Text = "Fecha";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 20);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1017, 505);
            this.Controls.Add(this.statusBarInicio);
            this.Controls.Add(this.menuInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInicio_FormClosing);
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
        private System.Windows.Forms.ToolStripStatusLabel lblTiempo;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaInicio;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem registrosTareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
    }
}