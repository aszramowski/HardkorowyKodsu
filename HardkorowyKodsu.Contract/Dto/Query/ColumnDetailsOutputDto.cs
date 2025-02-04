namespace HardkorowyKodsu.Contract.Dto.Query
{
    public class ColumnDetailsOutputDto
    {
        public string TableCatalog { get; set; }
        public string TableSchema { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string IsNullable { get; set; }
        public string DataType { get; set; }
    }
}
