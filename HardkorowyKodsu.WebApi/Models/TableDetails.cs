using System.ComponentModel.DataAnnotations.Schema;

namespace HardkorowyKodsu.WebApi.Models
{
    public class TableDetails
    {        
        public string Table_Catalog { get; set; }
        public string Table_Schema { get; set; }
        public string Table_Name { get; set; }
        public string Table_Type { get; set; }
    }
}