using HardkorowyKodsu.UI.Dto.Query;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HardkorowyKodsu.UI.Services
{
    public class DatabaseInfoApi
    {
        private string _url;
        private string _urlGetVersion;
        private string _urlGetAllTables;
        private string _urlGetAllColumns;

        private HttpClient httpClient;

        public DatabaseInfoApi(string url, string urlGetVersion, string urlGetAllTables, string urlGetAllColumns)
        {
            _url = url;
            _urlGetVersion = urlGetVersion;
            _urlGetAllTables = urlGetAllTables;
            _urlGetAllColumns = urlGetAllColumns;

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
