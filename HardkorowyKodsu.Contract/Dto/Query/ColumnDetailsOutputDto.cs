namespace HardkorowyKodsu.Contract.Dto.Query
{
    public class ColumnDetailsOutputDto
    {
        public ColumnDetailsOutputDto(string tableCatalog, string tableSchema, string tableName, string columnName, string isNullable, string dataType)
        {
            TableCatalog = tableCatalog;
            TableSchema = tableSchema;
            TableName = tableName;
            ColumnName = columnName;
            IsNullable = isNullable;
            DataType = dataType;
        }

        public string TableCatalog { get; set; }
        public string TableSchema { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string IsNullable { get; set; }
        public string DataType { get; set; }
    }
}
