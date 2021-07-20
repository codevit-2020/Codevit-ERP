using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Ayuda
{
	public partial class frmIniciaAyuda : Form
	{
		public frmIniciaAyuda()
		{
			InitializeComponent();
			txtBienvenida.Text = Bienvenida();
		}

		private string Bienvenida()
		{
			string bienvenida = "";
			bienvenida += "Su sistema administrativo y contable que le permite ";
			bienvenida += "controlar todos los procesos de negocio de su empresa, ";
			bienvenida += "logrando que todas las áreas interactúen con una sola ";
			bienvenida += "herramienta, con el objetivo de organizar y optimizar ";
			bienvenida += "la totalidad de sus recursos para aumentar la ";
			bienvenida += "productividad, rentabilidad y competitividad. ";

			return bienvenida;
		}

		private void BtnSiguiente_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
