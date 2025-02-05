using HardkorowyKodsu.Contract.Dto.Query;
using HardkorowyKodsu.WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardkorowyKodsu.Tests.Utilities
{
    public class FakeDatabaseInfoRepository : IDatabaseInfoRepository
    {
        public Task<List<ColumnDetailsOutputDto>> GetAllColumns(string tableName = "")
        {
            var columnList = new List<ColumnDetailsOutputDto>
            {
                new ColumnDetailsOutputDto("tableCatalog1", "tableSchema1", "tableName1", "columnName1", "isNullable1", "dataType1"),
                new ColumnDetailsOutputDto("tableCatalog2", "tableSchema2", "tableName2", "columnName2", "isNullable2", "dataType2"),
                new ColumnDetailsOutputDto("tableCatalog3", "tableSchema3", "tableName3", "columnName3", "isNullable3", "dataType3")
            };

            return Task.FromResult(columnList);
        }

        public Task<List<TableDetailsOutputDto>> GetAllTablesAndViews(string databaseName = "")
        {
            var tableList = new List<TableDetailsOutputDto> 
            {  
                new TableDetailsOutputDto("tableName1", "tableType1", "tableSchema1", "tableCatalog1"),
                new TableDetailsOutputDto("tableName2", "tableType2", "tableSchema2", "tableCatalog2"),
                new TableDetailsOutputDto("tableName3", "tableType3", "tableSchema3", "tableCatalog3")
            };

            return Task.FromResult(tableList);
        }
    }
}
