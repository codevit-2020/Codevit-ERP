using Modelo;
using Controlador;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Vista.Ayuda;
using Microsoft.Win32;

namespace Vista.Inicio
{
	public partial class frmClaveProducto : Form
	{
		public frmClaveProducto()
		{
			InitializeComponent();
		}

		#region "Variables"

		string clave = "";

		#endregion

		#region "Funciones"



		#endregion

		#region "Formulario"

		private void TxtLlave1_TextChanged(object sender, EventArgs e)
		{
			if (txtLlave1.TextLength == 4)
			{
				txtLlave1.ReadOnly = true;
				txtLlave2.Focus();
			}
		}

		private void TxtLlave2_TextChanged(object sender, EventArgs e)
		{
			if (txtLlave2.TextLength == 4)
			{
				txtLlave2.ReadOnly = true;
				txtLlave3.Focus();
			}
		}

		private void TxtLlave2_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Back)
			{
				if (txtLlave2.TextLength == 0)
				{
					txtLlave1.ReadOnly = false;
					txtLlave1.Focus();
				}
			}
		}

		private void TxtLlave3_TextChanged(object sender, EventArgs e)
		{
			if (txtLlave3.TextLength == 4)
			{
				txtLlave3.ReadOnly = true;
				txtLlave4.Focus();
			}
		}

		private void TxtLlave3_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Back)
			{
				if (txtLlave3.TextLength == 0)
				{
					txtLlave2.ReadOnly = false;
					txtLlave2.Focus();
				}
			}
		}

		private void TxtLlave4_TextChanged(object sender, EventArgs e)
		{
			btnSiguiente.Enabled = true;
		}

		private void TxtLlave4_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Back)
			{
				if (txtLlave4.TextLength == 0)
				{
					txtLlave3.ReadOnly = false;
					btnSiguiente.Enabled = false;
					txtLlave3.Focus();
				}
			}
		}

		private void TsbCerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BtnSiguiente_Click(object sender, EventArgs e)
		{
			clave = txtLlave1.Text + txtLlave2.Text + txtLlave3.Text + txtLlave4.Text;
			List<Registro_Mdl> registro = new List<Registro_Mdl>();
			Registro_Ctl objRegistro = new Registro_Ctl();
			registro = objRegistro.Registros(clave);
			foreach (var reg in registro)
			{
				if (clave == reg.clave)
				{
					MessageBox.Show("Producto Registrado Correctamente", "Registro de Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
					VariablesGlobales.licencia = reg.clave;

					RegistryKey equipoLocal = Registry.CurrentUser;
					equipoLocal = equipoLocal.OpenSubKey(@"Software\\Codevit", true);

					equipoLocal.SetValue("Licencia", reg.clave, RegistryValueKind.String);

					this.DialogResult = DialogResult.OK;
					this.Close();
				}
				else
				{
					MessageBox.Show("Clave del producto erronea", "Registro de Producto",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
		}

		#endregion

	}
}
