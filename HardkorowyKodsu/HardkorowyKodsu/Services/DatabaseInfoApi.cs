using HardkorowyKodsu.Dto.Query;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HardkorowyKodsu.Services
{
    public class DatabaseInfoApi
    {
        private string _url = @"http://localhost:5163/";
        private string _urlGetVersion = @"api/System/GetVersion/";
        private string _urlGetAllTables = @"api/DatabaseInfo/GetAllTables/";
        private string _urlGetAllColumns = @"api/DatabaseInfo/GetAllColumns/";

        private HttpClient httpClient;

        public DatabaseInfoApi()
        {
            httpClient = new HttpClient();
        }

        public async Task<List<TableDetailsInputDto>> GetAllTablesAsync(string databaseName = "")
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"{_url}{_urlGetAllTables}{databaseName}"))
            {
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                var tableList = JsonConvert.DeserializeObject<List<TableDetailsInputDto>>(responseBody);

                return tableList;
            }
        }

        public async Task<List<ColumnDetailsInputDto>> GetAllColumnsAsync(string tableName = "")
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"{_url}{_urlGetAllColumns}{tableName}"))
            {
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                var columns = JsonConvert.DeserializeObject<List<ColumnDetailsInputDto>>(responseBody);

                return columns;
            }
        }

        public async Task<string> GetVersion()
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"{_url}{_urlGetVersion}"))
            {
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                //var columns = JsonConvert.DeserializeObject<List<ColumnDetailsInputDto>>(responseBody);

                return responseBody;
            }
        }
    }
}
