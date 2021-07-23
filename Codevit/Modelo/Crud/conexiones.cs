using MySql.Data.MySqlClient;

namespace Modelo.Crud
{
	public class conexiones
	{

		public MySqlConnection BaseDatos(string servidor)
		{
			string strCon = "Server='"+ servidor + "';Database=codevit;Uid=codevit;Pwd=C0d3v1tDb;";
			MySqlConnection con = new MySqlConnection();
			con.ConnectionString = strCon;
			try
			{
				con.Open();
				return con;
			}
			catch
			{
				return null;
			}
		}

		public MySqlConnection Codevit()
		{
			string strCon = "Server=www.codevit.com.mx;Database=codevitc_codevit;Uid=codevitc_sistemas;Pwd=C0d3v1t$1st3m@s;";
			MySqlConnection con = new MySqlConnection();
			con.ConnectionString = strCon;
			try
			{
				con.Open();
				return con;
			}
			catch
			{
				return null;
			}
		}

	}
}
