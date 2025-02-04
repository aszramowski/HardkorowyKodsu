﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardkorowyKodsu.Contract.Dto.Query
{
    public class ColumnDetailsInputDto
    {
        public string TableCatalog { get; set; }
        public string TableSchema { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string IsNullable { get; set; }
        public string DataType { get; set; }
    }
}
