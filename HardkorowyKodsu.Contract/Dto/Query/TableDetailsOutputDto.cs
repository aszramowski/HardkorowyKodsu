namespace HardkorowyKodsu.Contract.Dto.Query
{
    public class TableDetailsOutputDto
    {
        public TableDetailsOutputDto(string tableName, string tableType, string tableSchema, string tableCatalog)
        {
            TableName = tableName;
            TableType = tableType;
            TableSchema = tableSchema;
            TableCatalog = tableCatalog;
        }

        public string TableName { get; set; }
        public string TableType { get; set; }
        public string TableSchema { get; set; }
        public string TableCatalog { get; set; }
    }
}
