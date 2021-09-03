using System;
using System.Data;
using System.Data.SqlClient;
using UnityEngine;
public class DBConnection : MonoBehaviour
	{
		public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-L6604F4\SQLEXPRESS; Initial Catalog=SingUpForm; Integrated Security=true");
	SqlCommand cmd = new SqlCommand();
	public void dataClose()
	{
		try
		{
			if (sqlcon.State == ConnectionState.Open)
			{
				sqlcon.Close();
			}
		}
		catch (Exception e)
		{
			
		}
	}

	public void ExicuteQue(string que)
	{
		cmd = new SqlCommand(que, sqlcon);
		cmd.ExecuteScalar();
	}
	public void dataConnect()
	{
		try
		{
			if (sqlcon.State == ConnectionState.Closed)
			{
				sqlcon.Open();
			}
		}
		catch (Exception e)
		{
			
		}
	}
}

