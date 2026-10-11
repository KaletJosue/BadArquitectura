using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Infrastructure.Data;


public static class BadDb
{

    public static string ConnectionString { get; set; } =
        Environment.GetEnvironmentVariable("BADDB_CONNECTION_STRING")
        ?? throw new InvalidOperationException(
            "No se ha configurado la cadena de conexion.");


    public static int ExecuteNonQueryUnsafe(string sql)
    {
        var conn = new SqlConnection(ConnectionString);
        var cmd = new SqlCommand(sql, conn);
        conn.Open();
        return cmd.ExecuteNonQuery();
    }

    public static IDataReader ExecuteReaderUnsafe(string sql)
    {
        var conn = new SqlConnection(ConnectionString);
        var cmd = new SqlCommand(sql, conn);
        conn.Open();
        return cmd.ExecuteReader();
    }
}
