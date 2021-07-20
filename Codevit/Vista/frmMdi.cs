using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Ayuda;
using Vista.Inicio;

namespace Vista
{
	public partial class frmMdi : Form
	{
		public frmMdi()
		{
			InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
		}

		private void FrmMdi_Load(object sender, EventArgs e)
		{
			if (Registro() != true)
			{
				CreaRegistro();
				frmIniciaAyuda frminiciaayuda = new frmIniciaAyuda();
				if (frminiciaayuda.ShowDialog() == DialogResult.OK)
				{
					if(VariablesGlobales.licencia == "")
					{
						frmClaveProducto frmclaveproducto = new frmClaveProducto();
						if (frmclaveproducto.ShowDialog() == DialogResult.OK)
						{

						}
					}
					else
					{

					}
				}
			}
			else
			{

			}
		}

		#region "Funciones"

		private Boolean Registro()
		{
			Boolean resp = false;
			//Manejo del Registro, verifica que exista el registro del software en el equipo
			RegistryKey equipoLocal = Registry.CurrentUser;
			equipoLocal = equipoLocal.OpenSubKey(@"Software\\Codevit", true);
			if (equipoLocal == null)
			{
				resp = false;
			}
			else
			{
				resp = true;
			}
			return resp;
		}

		private void CreaRegistro()
		{
			RegistryKey equipoLocal = Registry.CurrentUser;
			equipoLocal = Registry.CurrentUser;
			equipoLocal = equipoLocal.OpenSubKey(@"Software", true);
			RegistryKey Codevit = equipoLocal.CreateSubKey("Codevit");
			Codevit.SetValue("Licencia", "", RegistryValueKind.String);
			Codevit.SetValue("Equipo", "", RegistryValueKind.String);
			Codevit.SetValue("Fecha", "", RegistryValueKind.String);
			Codevit.SetValue("Servidor", "", RegistryValueKind.String);
			Codevit.SetValue("Producto", "", RegistryValueKind.String);
			Codevit.SetValue("Tipo", "", RegistryValueKind.String);
			Codevit.SetValue("Version", "", RegistryValueKind.String);
			Codevit.SetValue("Llave", "", RegistryValueKind.String);

			VariablesGlobales.licencia = Codevit.GetValue("Licencia").ToString();
			VariablesGlobales.equipo = Codevit.GetValue("Equipo").ToString();
			VariablesGlobales.servidor = Codevit.GetValue("Servidor").ToString();
			VariablesGlobales.producto = Codevit.GetValue("Producto").ToString();
			VariablesGlobales.tipo = Codevit.GetValue("Tipo").ToString();
			VariablesGlobales.version = Codevit.GetValue("Version").ToString();
			VariablesGlobales.llave = Codevit.GetValue("Llave").ToString();
		}

		#endregion
	}
}
