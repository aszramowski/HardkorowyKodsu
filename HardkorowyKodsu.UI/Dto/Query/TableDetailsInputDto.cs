using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardkorowyKodsu.UI.Dto.Query
{
    public class TableDetailsInputDto
    {
        public string TableName { get; set; }
        public string TableType { get; set; }
        public string TableSchema { get; set; }
        public string TableCatalog { get; set; }
    }
}
