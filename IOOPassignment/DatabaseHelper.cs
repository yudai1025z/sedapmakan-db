using System;
using System.Configuration;

public static class DatabaseHelper
{
	public static string ConnStr => ConfigurationManager.ConnectionStrings["UsersData"].ConnectionString;
}
