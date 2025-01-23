using HardkorowyKodsu.WebApi.Models;

namespace HardkorowyKodsu.WebApi.Repositories
{
    public interface IDatabaseInfoRepository
    {
        public Task<List<TableDetails>> GetAllTablesAndViews(string databaseName);
        public Task<List<ColumnDetails>> GetAllColumns(string tableName);
    }
}
