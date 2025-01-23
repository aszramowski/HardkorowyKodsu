using Dapper;
using HardkorowyKodsu.WebApi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System.Text.RegularExpressions;

namespace HardkorowyKodsu.WebApi.Repositories
{
    public class DatabaseInfoRepository : IDatabaseInfoRepository
    {
        private readonly IConfiguration _configuration;
        private static string _connectionString = "";

        public DatabaseInfoRepository(IConfiguration configuration)
        {
            _configuration = configuration;            
        }                

        public async Task<List<TableDetails>> GetAllTablesAndViews(string databaseName)
        {
            using var connection = GetConnection(databaseName);

            var tables = await connection.QueryAsync<TableDetails>(
                "SELECT * " +
                "FROM INFORMATION_SCHEMA.TABLES");

            return tables.ToList();
        }

        public async Task<List<ColumnDetails>> GetAllColumns(string tableName)
        {
            using var connection = GetConnection();

            var columns = await connection.QueryAsync<ColumnDetails>(
                "SELECT * " +
                "FROM INFORMATION_SCHEMA.COLUMNS " +
                "WHERE TABLE_NAME = @TableName", new { TableName = tableName });

            return columns.ToList();
        }

        private SqlConnection GetConnection(string databaseName = "")
        {
            string dbNamePattern = "(?<=Database=)[^;]+";

            // initialize connection string
            if (string.IsNullOrEmpty(_connectionString))            
                _connectionString = _configuration.GetConnectionString("DefaultConnection") ?? "";
            
            // update connection string if required
            if (!string.IsNullOrEmpty(databaseName))
            {
                if (Regex.IsMatch(_connectionString, dbNamePattern, RegexOptions.IgnoreCase))
                    _connectionString = Regex.Replace(_connectionString, dbNamePattern, databaseName);
                else
                    _connectionString += $"Database={databaseName}";
            }

            return new SqlConnection(_connectionString);
        }
    }
}
