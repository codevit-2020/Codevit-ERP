using Modelo;
using Modelo.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
	public class Registro_Ctl
	{

		#region "Variables"

		Registro registro = new Registro();

		#endregion

		public List<Registro_Mdl> Registros(string lic)
		{
			return registro.Registros(lic);
		}
	}
}
