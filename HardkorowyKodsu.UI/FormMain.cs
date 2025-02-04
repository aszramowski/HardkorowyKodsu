using HardkorowyKodsu.UI.Helpers;
using HardkorowyKodsu.UI.Services;
using System;
using System.Windows.Forms;

namespace HardkorowyKodsu.UI
{
    public partial class FormMain : Form
    {                        
        private DatabaseInfoApi databaseInfoApi;

        public FormMain()
        {
            InitializeComponent();

            databaseInfoApi = new DatabaseInfoApi(
                Setting.Instance.UrlBase,
                Setting.Instance.GetVersionUrl,
                Setting.Instance.GetAllTablesUrl,
                Setting.Instance.GetAllColumnsUrl);
        }

        private async void btnTables_Click(object sender, EventArgs e)
        {
            try
            {
                grvTables.DataSource = await databaseInfoApi.GetAllTablesAsync();

                tbcDatabaseInfo.SelectedIndex = 0;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnColumns_Click(object sender, EventArgs e)
        {
            string selectedTable = "";

            try
            {
                if (grvTables.SelectedRows.Count > 0)
                    selectedTable = grvTables.SelectedRows[0].Cells["TableName"].Value.ToString();

                grvColumns.DataSource = await databaseInfoApi.GetAllColumnsAsync(selectedTable);

                tbcDatabaseInfo.SelectedIndex = 1;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnVersion_Click(object sender, EventArgs e)
        {
            rtxMessage.Clear();

            try
            {
                var version = await databaseInfoApi.GetVersion();

                rtxMessage.Text = $"Api version: {version}";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
