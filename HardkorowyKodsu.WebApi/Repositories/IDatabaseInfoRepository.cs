using HardkorowyKodsu.WebApi.Dto.Query;
using HardkorowyKodsu.WebApi.Models;

namespace HardkorowyKodsu.WebApi.Repositories
{
    public interface IDatabaseInfoRepository
    {
        public Task<List<TableDetailsOutputDto>> GetAllTablesAndViews(string databaseName);
        public Task<List<ColumnDetailsOutputDto>> GetAllColumns(string tableName);
    }
}
