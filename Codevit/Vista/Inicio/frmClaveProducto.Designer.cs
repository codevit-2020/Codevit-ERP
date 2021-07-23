namespace Vista.Inicio
{
	partial class frmClaveProducto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClaveProducto));
			this.tsMenu = new System.Windows.Forms.ToolStrip();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblIngrese = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtLlave1 = new System.Windows.Forms.TextBox();
			this.txtLlave2 = new System.Windows.Forms.TextBox();
			this.txtLlave3 = new System.Windows.Forms.TextBox();
			this.txtLlave4 = new System.Windows.Forms.TextBox();
			this.btnSiguiente = new System.Windows.Forms.Button();
			this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
			this.tsMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tsMenu
			// 
			this.tsMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsMenu.BackgroundImage")));
			this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCerrar});
			this.tsMenu.Location = new System.Drawing.Point(0, 0);
			this.tsMenu.Name = "tsMenu";
			this.tsMenu.Size = new System.Drawing.Size(373, 25);
			this.tsMenu.TabIndex = 0;
			this.tsMenu.Text = "toolStrip1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(6, 57);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(60, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// lblIngrese
			// 
			this.lblIngrese.AutoSize = true;
			this.lblIngrese.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIngrese.Location = new System.Drawing.Point(98, 29);
			this.lblIngrese.Name = "lblIngrese";
			this.lblIngrese.Size = new System.Drawing.Size(231, 19);
			this.lblIngrese.TabIndex = 2;
			this.lblIngrese.Text = "Ingrese la licencia de su producto";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(67, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "Licencia:";
			// 
			// txtLlave1
			// 
			this.txtLlave1.Location = new System.Drawing.Point(143, 59);
			this.txtLlave1.Name = "txtLlave1";
			this.txtLlave1.Size = new System.Drawing.Size(50, 20);
			this.txtLlave1.TabIndex = 4;
			// 
			// txtLlave2
			// 
			this.txtLlave2.Location = new System.Drawing.Point(199, 58);
			this.txtLlave2.Name = "txtLlave2";
			this.txtLlave2.Size = new System.Drawing.Size(50, 20);
			this.txtLlave2.TabIndex = 5;
			// 
			// txtLlave3
			// 
			this.txtLlave3.Location = new System.Drawing.Point(255, 57);
			this.txtLlave3.Name = "txtLlave3";
			this.txtLlave3.Size = new System.Drawing.Size(50, 20);
			this.txtLlave3.TabIndex = 6;
			// 
			// txtLlave4
			// 
			this.txtLlave4.Location = new System.Drawing.Point(311, 57);
			this.txtLlave4.Name = "txtLlave4";
			this.txtLlave4.Size = new System.Drawing.Size(50, 20);
			this.txtLlave4.TabIndex = 7;
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
			this.btnSiguiente.Location = new System.Drawing.Point(311, 83);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(49, 46);
			this.btnSiguiente.TabIndex = 8;
			this.btnSiguiente.UseVisualStyleBackColor = true;
			this.btnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
			// 
			// tsbCerrar
			// 
			this.tsbCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tsbCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCerrar.Image")));
			this.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbCerrar.Name = "tsbCerrar";
			this.tsbCerrar.Size = new System.Drawing.Size(23, 22);
			this.tsbCerrar.Text = "toolStripButton1";
			this.tsbCerrar.Click += new System.EventHandler(this.TsbCerrar_Click);
			// 
			// frmClaveProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(373, 133);
			this.Controls.Add(this.btnSiguiente);
			this.Controls.Add(this.txtLlave4);
			this.Controls.Add(this.txtLlave3);
			this.Controls.Add(this.txtLlave2);
			this.Controls.Add(this.txtLlave1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblIngrese);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.tsMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmClaveProducto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Clave del Producto";
			this.tsMenu.ResumeLayout(false);
			this.tsMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip tsMenu;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblIngrese;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtLlave1;
		private System.Windows.Forms.TextBox txtLlave2;
		private System.Windows.Forms.TextBox txtLlave3;
		private System.Windows.Forms.TextBox txtLlave4;
		private System.Windows.Forms.Button btnSiguiente;
		private System.Windows.Forms.ToolStripButton tsbCerrar;
	}
}