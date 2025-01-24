using AutoMapper;
using Dapper;
using HardkorowyKodsu.WebApi.Dto.Query;
using HardkorowyKodsu.WebApi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System.Text.RegularExpressions;

namespace HardkorowyKodsu.WebApi.Repositories
{
    public class DatabaseInfoRepository : IDatabaseInfoRepository
    {
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private static string _connectionString = "";

        public DatabaseInfoRepository(IConfiguration configuration, IMapper mapper)
        {
            _configuration = configuration;
            _mapper = mapper;
        }

        public async Task<List<ColumnDetailsOutputDto>> GetAllColumns(string tableName = "")
        {
            IEnumerable<ColumnDetails> columns;

            using var connection = GetConnection();

            if (tableName == "")
            {
                columns = await connection.QueryAsync<ColumnDetails>(
                    "SELECT * " +
                    "FROM INFORMATION_SCHEMA.COLUMNS");
            } 
            else
            {
                columns = await connection.QueryAsync<ColumnDetails>(
                    "SELECT * " +
                    "FROM INFORMATION_SCHEMA.COLUMNS " +
                    "WHERE TABLE_NAME = @TableName", new { TableName = tableName });
            }

            return _mapper.Map<List<ColumnDetailsOutputDto>>(columns.ToList());
        }

        public async Task<List<TableDetailsOutputDto>> GetAllTablesAndViews(string databaseName = "")
        {
            using var connection = GetConnection(databaseName);

            var tables = await connection.QueryAsync<TableDetails>(
                "SELECT * " +
                "FROM INFORMATION_SCHEMA.TABLES");

            return _mapper.Map<List<TableDetailsOutputDto>>(tables.ToList());
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
