namespace Vista.Ayuda
{
	partial class frmIniciaAyuda
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIniciaAyuda));
			this.tsMenu = new System.Windows.Forms.ToolStrip();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSiguiente = new System.Windows.Forms.Button();
			this.txtBienvenida = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tsMenu
			// 
			this.tsMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsMenu.BackgroundImage")));
			this.tsMenu.Location = new System.Drawing.Point(0, 0);
			this.tsMenu.Name = "tsMenu";
			this.tsMenu.Size = new System.Drawing.Size(472, 25);
			this.tsMenu.TabIndex = 0;
			this.tsMenu.Text = "toolStrip1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnSiguiente);
			this.panel1.Controls.Add(this.txtBienvenida);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 28);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(468, 288);
			this.panel1.TabIndex = 1;
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
			this.btnSiguiente.Location = new System.Drawing.Point(411, 242);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(49, 43);
			this.btnSiguiente.TabIndex = 0;
			this.btnSiguiente.UseVisualStyleBackColor = true;
			this.btnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
			// 
			// txtBienvenida
			// 
			this.txtBienvenida.BackColor = System.Drawing.SystemColors.Menu;
			this.txtBienvenida.Enabled = false;
			this.txtBienvenida.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBienvenida.Location = new System.Drawing.Point(12, 56);
			this.txtBienvenida.Multiline = true;
			this.txtBienvenida.Name = "txtBienvenida";
			this.txtBienvenida.Size = new System.Drawing.Size(448, 180);
			this.txtBienvenida.TabIndex = 1;
			this.txtBienvenida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(450, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Le damos la bienvenida a su sistemas CODEVIT-ERP";
			// 
			// frmIniciaAyuda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 318);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tsMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmIniciaAyuda";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bienvenidos";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip tsMenu;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtBienvenida;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSiguiente;
	}
}