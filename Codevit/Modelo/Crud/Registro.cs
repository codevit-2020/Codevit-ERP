using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;


namespace Modelo.Crud
{
	public class Registro
	{

		#region "Variables"

		conexiones conectar = new conexiones();

		#endregion

		#region "Registro"

		public List<Registro_Mdl> Registros(string lic)
		{
			List<Registro_Mdl> listaRegistro = new List<Registro_Mdl>();

			MySqlConnection cnObj = new MySqlConnection();
			cnObj = conectar.Codevit();
			if(cnObj != null)
			{
				using (cnObj)
				{
					MySqlCommand cmdObj = new MySqlCommand();
					cmdObj.Connection = cnObj;
					cmdObj.CommandTimeout = 0;

					string strSql = "";
					strSql = "SELECT ";
					strSql += "pro.producto, ";
					strSql += "pro.tipo, ";
					strSql += "pro.version, ";
					strSql += "cli.razonSocial, ";
					strSql += "li.clave, ";
					strSql += "li.fecha ";
					strSql += "FROM ";
					strSql += "licencias li LEFT OUTER JOIN productos pro ON ";
					strSql += "li.idProducto = pro.idProducto LEFT OUTER JOIN licenciaCliente lic ON ";
					strSql += "li.idLicencia = lic.idLicencia LEFT OUTER JOIN clientes cli ON ";
					strSql += "lic.idCliente = cli.idCliente ";
					strSql += "WHERE ";
					strSql += "li.clave = '" + lic + "'";

					cmdObj.CommandText = strSql;
					MySqlDataReader rdrObj = cmdObj.ExecuteReader();
					while (rdrObj.Read())
					{
						Registro_Mdl registro = new Registro_Mdl();
						registro.producto = rdrObj[0].ToString();
						registro.tipo = rdrObj[1].ToString();
						registro.version = rdrObj[2].ToString();
						registro.cliente = rdrObj[3].ToString();
						registro.clave = rdrObj[4].ToString();
						registro.fecha = DateTime.Parse(rdrObj[5].ToString());

						listaRegistro.Add(registro);
					}
					rdrObj.Close();
				}
			}
			return listaRegistro;
		}

		#endregion

	}
}
