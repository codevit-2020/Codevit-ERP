namespace Vista
{
	partial class frmMdi
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMdi));
			this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
			this.navNavegador = new C1.Win.C1Command.C1NavBar();
			this.c1NavBarPanel1 = new C1.Win.C1Command.C1NavBarPanel();
			this.msConfiguracion = new System.Windows.Forms.MenuStrip();
			this.tsmiConfigSeguridad = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiConfigSegUsuarios = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiConfigSegPerfiles = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiConfigSegModulos = new System.Windows.Forms.ToolStripMenuItem();
			this.c1NavBarPanel2 = new C1.Win.C1Command.C1NavBarPanel();
			this.msPuntoVenta = new System.Windows.Forms.MenuStrip();
			this.cajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.navNavegador)).BeginInit();
			this.navNavegador.SuspendLayout();
			this.c1NavBarPanel1.SuspendLayout();
			this.msConfiguracion.SuspendLayout();
			this.c1NavBarPanel2.SuspendLayout();
			this.msPuntoVenta.SuspendLayout();
			this.SuspendLayout();
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.Owner = this;
			// 
			// navNavegador
			// 
			this.navNavegador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.navNavegador.Collapsed = false;
			this.navNavegador.Controls.Add(this.c1NavBarPanel1);
			this.navNavegador.Controls.Add(this.c1NavBarPanel2);
			this.navNavegador.Location = new System.Drawing.Point(3, 12);
			this.navNavegador.Name = "navNavegador";
			this.navNavegador.Size = new System.Drawing.Size(160, 413);
			this.navNavegador.Tag = "1";
			this.navNavegador.Visible = false;
			// 
			// c1NavBarPanel1
			// 
			this.c1NavBarPanel1.Button.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
			this.c1NavBarPanel1.Button.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.c1NavBarPanel1.Button.PanelHeader = "Configuracion";
			this.c1NavBarPanel1.Button.SmallImage = ((System.Drawing.Image)(resources.GetObject("resource.SmallImage")));
			this.c1NavBarPanel1.Button.Text = "Configuración";
			this.c1NavBarPanel1.Controls.Add(this.msConfiguracion);
			this.c1NavBarPanel1.ID = 1;
			this.c1NavBarPanel1.Name = "c1NavBarPanel1";
			this.c1NavBarPanel1.Size = new System.Drawing.Size(158, 283);
			// 
			// msConfiguracion
			// 
			this.msConfiguracion.BackColor = System.Drawing.SystemColors.ControlLight;
			this.msConfiguracion.Dock = System.Windows.Forms.DockStyle.Left;
			this.msConfiguracion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConfigSeguridad});
			this.msConfiguracion.Location = new System.Drawing.Point(0, 0);
			this.msConfiguracion.Name = "msConfiguracion";
			this.msConfiguracion.Size = new System.Drawing.Size(94, 283);
			this.msConfiguracion.TabIndex = 1;
			this.msConfiguracion.Text = "menuStrip1";
			// 
			// tsmiConfigSeguridad
			// 
			this.tsmiConfigSeguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConfigSegUsuarios,
            this.tsmiConfigSegPerfiles,
            this.tsmiConfigSegModulos});
			this.tsmiConfigSeguridad.Image = ((System.Drawing.Image)(resources.GetObject("tsmiConfigSeguridad.Image")));
			this.tsmiConfigSeguridad.Name = "tsmiConfigSeguridad";
			this.tsmiConfigSeguridad.Size = new System.Drawing.Size(81, 20);
			this.tsmiConfigSeguridad.Tag = "10";
			this.tsmiConfigSeguridad.Text = "Seguridad";
			// 
			// tsmiConfigSegUsuarios
			// 
			this.tsmiConfigSegUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("tsmiConfigSegUsuarios.Image")));
			this.tsmiConfigSegUsuarios.Name = "tsmiConfigSegUsuarios";
			this.tsmiConfigSegUsuarios.Size = new System.Drawing.Size(121, 22);
			this.tsmiConfigSegUsuarios.Tag = "10";
			this.tsmiConfigSegUsuarios.Text = "Usuarios";
			// 
			// tsmiConfigSegPerfiles
			// 
			this.tsmiConfigSegPerfiles.Image = ((System.Drawing.Image)(resources.GetObject("tsmiConfigSegPerfiles.Image")));
			this.tsmiConfigSegPerfiles.Name = "tsmiConfigSegPerfiles";
			this.tsmiConfigSegPerfiles.Size = new System.Drawing.Size(121, 22);
			this.tsmiConfigSegPerfiles.Tag = "20";
			this.tsmiConfigSegPerfiles.Text = "Perfiles";
			// 
			// tsmiConfigSegModulos
			// 
			this.tsmiConfigSegModulos.Image = ((System.Drawing.Image)(resources.GetObject("tsmiConfigSegModulos.Image")));
			this.tsmiConfigSegModulos.Name = "tsmiConfigSegModulos";
			this.tsmiConfigSegModulos.Size = new System.Drawing.Size(121, 22);
			this.tsmiConfigSegModulos.Tag = "30";
			this.tsmiConfigSegModulos.Text = "Modulos";
			// 
			// c1NavBarPanel2
			// 
			this.c1NavBarPanel2.Button.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
			this.c1NavBarPanel2.Button.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.c1NavBarPanel2.Button.PanelHeader = "Punto de Venta";
			this.c1NavBarPanel2.Button.SmallImage = ((System.Drawing.Image)(resources.GetObject("resource.SmallImage1")));
			this.c1NavBarPanel2.Button.Text = "Punto de Venta";
			this.c1NavBarPanel2.Controls.Add(this.msPuntoVenta);
			this.c1NavBarPanel2.ID = 2;
			this.c1NavBarPanel2.Name = "c1NavBarPanel2";
			this.c1NavBarPanel2.Size = new System.Drawing.Size(158, 283);
			// 
			// msPuntoVenta
			// 
			this.msPuntoVenta.BackColor = System.Drawing.SystemColors.ControlLight;
			this.msPuntoVenta.Dock = System.Windows.Forms.DockStyle.Left;
			this.msPuntoVenta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cajaToolStripMenuItem});
			this.msPuntoVenta.Location = new System.Drawing.Point(0, 0);
			this.msPuntoVenta.Name = "msPuntoVenta";
			this.msPuntoVenta.Size = new System.Drawing.Size(48, 283);
			this.msPuntoVenta.TabIndex = 0;
			this.msPuntoVenta.Tag = "2";
			this.msPuntoVenta.Text = "menuStrip1";
			// 
			// cajaToolStripMenuItem
			// 
			this.cajaToolStripMenuItem.Name = "cajaToolStripMenuItem";
			this.cajaToolStripMenuItem.Size = new System.Drawing.Size(35, 19);
			this.cajaToolStripMenuItem.Text = "Caja";
			// 
			// frmMdi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.navNavegador);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.msConfiguracion;
			this.MaximizeBox = false;
			this.Name = "frmMdi";
			this.Text = "Codevit ERP";
			this.Load += new System.EventHandler(this.FrmMdi_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.navNavegador)).EndInit();
			this.navNavegador.ResumeLayout(false);
			this.c1NavBarPanel1.ResumeLayout(false);
			this.c1NavBarPanel1.PerformLayout();
			this.msConfiguracion.ResumeLayout(false);
			this.msConfiguracion.PerformLayout();
			this.c1NavBarPanel2.ResumeLayout(false);
			this.c1NavBarPanel2.PerformLayout();
			this.msPuntoVenta.ResumeLayout(false);
			this.msPuntoVenta.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
		private C1.Win.C1Command.C1NavBar navNavegador;
		private C1.Win.C1Command.C1NavBarPanel c1NavBarPanel1;
		private System.Windows.Forms.MenuStrip msConfiguracion;
		private System.Windows.Forms.ToolStripMenuItem tsmiConfigSeguridad;
		private System.Windows.Forms.ToolStripMenuItem tsmiConfigSegUsuarios;
		private System.Windows.Forms.ToolStripMenuItem tsmiConfigSegPerfiles;
		private C1.Win.C1Command.C1NavBarPanel c1NavBarPanel2;
		private System.Windows.Forms.MenuStrip msPuntoVenta;
		private System.Windows.Forms.ToolStripMenuItem cajaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiConfigSegModulos;
	}
}

