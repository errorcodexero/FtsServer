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
    public partial class AddMatchForm : Form
    {
        private long compID;
        private List<ComboBox> teamComboList;
        private bool initSentinal;
        public AddMatchForm(long competition_id)
        {
            this.initSentinal = false;
            this.compID = competition_id;
            this.teamComboList = new List<ComboBox>(6);
            InitializeComponent();
            LoadCompetitions();
            initTeamComboBoxes();
            LoadTeams();
            this.initSentinal = true;
        }

        public void LoadCompetitions()
        {
            MySqlConnection connection = new MySqlConnection(Program.conString);
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
                    cmbCompetitionName.SelectedValue = this.compID;
                    cmbCompetitionName.DisplayMember = "competition_name";
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    string message = "Unable to open MySQL connection - check if the database is installed and running!";
                    Console.Out.WriteLine(message);
                    lblStatus.Text = message;
                }
                catch (Exception)
                {
                    string message = "Unknown error - check if the database is installed and running!";
                    Console.Out.WriteLine(message);
                    lblStatus.Text = message;
                    //throw;
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

        public void initTeamComboBoxes()
        {
            teamComboList.Add(cmbBlue1);
            teamComboList.Add(cmbBlue2);
            teamComboList.Add(cmbBlue3);
            teamComboList.Add(cmbRed1);
            teamComboList.Add(cmbRed2);
            teamComboList.Add(cmbRed3);

            cmbBlue1.Text = "";
        }

        public void LoadTeams()
        {
            MySqlConnection connection = new MySqlConnection(Program.conString);
            MySqlCommand cmd;
            bool connectionAvailable = Utils.openConnection(connection, lblStatus);

            if (connectionAvailable)
            {
                try
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "SELECT _id, team_number FROM team_data";
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adap.Fill(ds);

                    foreach (ComboBox combo in teamComboList)
                    {
                        combo.BindingContext = new System.Windows.Forms.BindingContext();
                        combo.DataSource = ds.Tables[0].DefaultView;
                        combo.ValueMember = "_id";
                        combo.DisplayMember = "team_number";
                        //cmbCompetitionName.SelectedValue = this.compID;
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    string message = "Unable to open MySQL connection - check if the database is installed and running!";
                    Console.Out.WriteLine(message);
                    lblStatus.Text = message;
                }
                catch (Exception)
                {
                    string message = "Unknown error - check if the database is installed and running!";
                    Console.Out.WriteLine(message);
                    lblStatus.Text = message;
                    //throw;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData(true);
        }

        private void btnSaveAndAddNew_Click(object sender, EventArgs e)
        {
            SaveData(false);
        }

        private void SaveData(bool exit)
        {
            MySqlConnection connection = new MySqlConnection(Program.conString);
            MySqlCommand cmd;
            bool saved = true, validated = true;
            long blue1ID = -1, blue2ID = -1, blue3ID = -1, red1ID = -1, red2ID = -1, red3ID = -1;

            connection.Open();

            try
            {
                blue1ID = Utils.getLongIDFromComboSelectedValue(cmbBlue1, lblStatus);
                blue2ID = Utils.getLongIDFromComboSelectedValue(cmbBlue2, lblStatus);
                blue3ID = Utils.getLongIDFromComboSelectedValue(cmbBlue3, lblStatus);
                red1ID = Utils.getLongIDFromComboSelectedValue(cmbRed1, lblStatus);
                red2ID = Utils.getLongIDFromComboSelectedValue(cmbRed2, lblStatus);
                red3ID = Utils.getLongIDFromComboSelectedValue(cmbRed3, lblStatus);
            }
            catch (Exception e)
            {
                validated = false;
                Console.Out.WriteLine(e.Message);
            }

            if (validated)
            {
                try
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "INSERT INTO match_data(tablet_id, competition_id, match_number, match_type, match_time, match_location," +
                    "blue_team_one_id, blue_team_two_id, blue_team_three_id, red_team_one_id, red_team_two_id, red_team_three_id, ready_to_export)" +
                    "VALUES(@tabletID, @competitionID, @matchNumber, @matchType, @matchTime, @matchLocation," +
                    "@blueTeamOneId, @blueTeamTwoId, @blueTeamThreeId, @redTeamOneId, @redTeamTwoId, @redTeamThreeId, @readyToExport)";

                    cmd.Parameters.AddWithValue("@tabletID", 0);
                    cmd.Parameters.AddWithValue("@competitionID", this.compID);
                    cmd.Parameters.AddWithValue("@matchNumber", int.Parse(txtMatchNumber.Text));
                    cmd.Parameters.AddWithValue("@matchType", txtMatchType.Text);
                    cmd.Parameters.AddWithValue("@matchTime", txtMatchTime.Text);
                    cmd.Parameters.AddWithValue("@matchLocation", txtMatchLocation.Text);
                    cmd.Parameters.AddWithValue("@blueTeamOneId", blue1ID);
                    cmd.Parameters.AddWithValue("@blueTeamTwoId", blue2ID);
                    cmd.Parameters.AddWithValue("@blueTeamThreeId", blue3ID);
                    cmd.Parameters.AddWithValue("@redTeamOneId", red1ID);
                    cmd.Parameters.AddWithValue("@redTeamTwoId", red2ID);
                    cmd.Parameters.AddWithValue("@redTeamThreeId", red3ID);
                    cmd.Parameters.AddWithValue("@readyToExport", "false");

                    cmd.ExecuteNonQuery();

                }
                catch (Exception)
                {
                    saved = false;
                    lblStatus.Text = "Failed to save data, check that database is active, and verify data is entered correctly";
                    //throw;
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }

            if (saved)
            {
                if (exit)
                {
                    Form1 formObj = (Form1)Application.OpenForms["Form1"];
                    formObj.LoadData();
                    this.Close();
                }
                else
                {
                    txtMatchNumber.Text = "";
                    txtMatchTime.Text = "";
                    txtMatchType.Text = "Qualification";
                    txtMatchLocation.Text = "Auburn";
                    cmbBlue1.Text = "";
                    cmbBlue2.Text = "";
                    cmbBlue3.Text = "";
                    cmbRed1.Text = "";
                    cmbRed2.Text = "";
                    cmbRed3.Text = "";
                }
            }
        }

        private void cmbCompetitionName_SelectedValueChanged(object sender, EventArgs e)
        {
            object val = cmbCompetitionName.SelectedValue;
            if (this.initSentinal && val.GetType() != typeof(DataRowView))
            {
                this.compID = Utils.getLongIDFromComboSelectedValue(cmbCompetitionName, lblStatus);
            }
        }
    }
}
