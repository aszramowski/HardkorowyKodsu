using HardkorowyKodsu.Services;
using System;
using System.Windows.Forms;

namespace HardkorowyKodsu
{
    public partial class FormMain : Form
    {                        
        private DatabaseInfoApi databaseInfoApi;

        public FormMain()
        {
            InitializeComponent();

            databaseInfoApi = new DatabaseInfoApi();
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
            try
            {
                grvColumns.DataSource = await databaseInfoApi.GetAllColumnsAsync();

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
