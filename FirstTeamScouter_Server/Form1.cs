using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FirstTeamScouter_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCompetitions();
            LoadData();

            if (Program.TEST_MODE)
            {
                lblTestMode.Text = " **** TEST MODE ****";
            }
        }

        public void LoadCompetitions()
        {
            MySqlConnection connection = new MySqlConnection(Utils.getConnectionString());
            MySqlCommand cmd;
            bool connectionAvailable = Utils.openConnection(connection, lblStatus);

            if (connectionAvailable)
            {
                try
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "SELECT _id, competition_name, competition_location FROM competition_data";
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adap.Fill(ds);
                    cmbCompetitionName.DataSource = ds.Tables[0].DefaultView;
                    cmbCompetitionName.ValueMember = "_id";
                    cmbCompetitionName.DisplayMember = "competition_name";
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    Console.Out.WriteLine("Unable to open MySQL connection - check if the database is installed and running!");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        public void LoadData()
        {
            long compID = Utils.getLongIDFromComboSelectedValue(cmbCompetitionName, lblStatus);

            MySqlConnection connection = new MySqlConnection(Utils.getConnectionString());
            MySqlCommand cmd;
            bool connectionAvailable = Utils.openConnection(connection, lblStatus);

            if (connectionAvailable)
            {
                try
                {
                    cmd = connection.CreateCommand();
                    
                    string query = "SELECT match_number AS 'Match Number'," +
		            " match_time AS 'Match Time'," +
                    " match_type AS 'Match Type'," +
                    " match_location AS 'Match Location'," +
                    " (SELECT team_data.team_number FROM team_data WHERE team_data._id = match_data.blue_team_one_id) AS 'Blue One'," +
                    " (SELECT team_data.team_number FROM team_data WHERE team_data._id = match_data.blue_team_two_id) AS 'Blue Two'," +
                    " (SELECT team_data.team_number FROM team_data WHERE team_data._id = match_data.blue_team_three_id) AS 'Blue Three'," +
                    " (SELECT team_data.team_number FROM team_data WHERE team_data._id = match_data.red_team_one_id) AS 'Red One'," +
                    " (SELECT team_data.team_number FROM team_data WHERE team_data._id = match_data.red_team_two_id) AS 'Red Two'," +
                    " (SELECT team_data.team_number FROM team_data WHERE team_data._id = match_data.red_team_three_id) AS 'Red Three'" +
                    " FROM match_data" +
                    " WHERE competition_id=" + compID;

                    cmd.CommandText = query;
 
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    
                    DataSet ds = new DataSet();
                    adap.Fill(ds);
                    gridMatchList.DataSource = ds.Tables[0].DefaultView;
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    string message = "Unable to open MySQL connection - check if the database is installed and running!";
                    Console.Out.WriteLine(message);
                    lblStatus.Text = message;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            long compID = Utils.getLongIDFromComboSelectedValue(cmbCompetitionName, lblStatus);
            AddMatchForm amForm = new AddMatchForm(compID);
            amForm.Show();
            //this.LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void cmbCompetitionName_SelectedValueChanged(object sender, EventArgs e)
        {
            long val = Utils.getLongIDFromComboSelectedValue(cmbCompetitionName, lblStatus);
            if (val >= 0)
            {
                this.LoadData();
            }
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            long compID = Utils.getLongIDFromComboSelectedValue(cmbCompetitionName, lblStatus);
            ExportDataForm exportForm = new ExportDataForm(compID);
            exportForm.Show();
        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            long compID = Utils.getLongIDFromComboSelectedValue(cmbCompetitionName, lblStatus);
            ImportDataForm importForm = new ImportDataForm(compID);
            importForm.Show();
        }
    }
}
