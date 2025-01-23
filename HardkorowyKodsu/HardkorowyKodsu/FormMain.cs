using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardkorowyKodsu
{
    public partial class FormMain : Form
    {
        private string _url = @"http://localhost:5163/";
        private string _urlGetVersion = @"api/System/GetVersion/";
        private string _urlGetAllTables = @"api/DatabaseInfo/GetAllTables/";
        private string _urlGetAllColumns = @"api/DatabaseInfo/GetAllColumns/";
        

        private readonly HttpClient httpClient = new HttpClient();

        public FormMain()
        {
            InitializeComponent();
        }

        private async void btnProccess_ClickAsync(object sender, EventArgs e)
        {
            rtxData.Clear();

            try
            {
                using (HttpResponseMessage response = await httpClient.GetAsync($"{_url}{_urlGetVersion}"))
                {
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();

                    rtxData.Text = responseBody;
                }
            }
            catch (Exception exc)
            {
                rtxData.Text = exc.Message;
            }
        }

        private async void btnProcess1_Click(object sender, EventArgs e)
        {
            string databaseName = rtxTableName.Text;

            rtxData.Clear();

            try
            {
                using (HttpResponseMessage response = await httpClient.GetAsync($"{_url}{_urlGetAllTables}{databaseName}"))
                {
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();

                    rtxData.Text = responseBody;
                }
            }
            catch (Exception exc)
            {
                rtxData.Text = exc.Message;
            }
        }

        private async void btnProcess2_Click(object sender, EventArgs e)
        {
            string databaseName = rtxTableName.Text;

            rtxData.Clear();

            try
            {
                using (HttpResponseMessage response = await httpClient.GetAsync($"{_url}{_urlGetAllColumns}{databaseName}"))
                {
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();

                    rtxData.Text = responseBody;
                }
            }
            catch (Exception exc)
            {
                rtxData.Text = exc.Message;
            }
        }
    }
}
