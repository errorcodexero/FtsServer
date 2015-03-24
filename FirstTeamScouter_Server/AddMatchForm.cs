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
        public AddMatchForm(long competition_id)
        {
            this.compID = competition_id;
            InitializeComponent();
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
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO match_data(tablet_id, competition_id, match_number, match_type, match_time, match_location," + 
                "red_team_one_id, red_team_two_id, red_team_three_id, blue_team_one_id, blue_team_two_id, blue_team_three_id, ready_to_export)" +
                "VALUES(@tabletID, @competitionID, @matchNumber, @matchType, @matchTime, @matchLocation," +
                "@redTeamOneId, @redTeamTwoId, @redTeamThreeId, @blueTeamOneId, @blueTeamTwoId, @blueTeamThreeId, @readyToExport)";

                cmd.Parameters.AddWithValue("@tabletID", 0);
                cmd.Parameters.AddWithValue("@competitionID", this.compID);
                cmd.Parameters.AddWithValue("@matchNumber", int.Parse(txtMatchNumber.Text));
                cmd.Parameters.AddWithValue("@matchType", txtMatchType.Text);
                cmd.Parameters.AddWithValue("@matchTime", txtMatchTime.Text);
                cmd.Parameters.AddWithValue("@matchLocation", txtMatchLocation.Text);
                cmd.Parameters.AddWithValue("@redTeamOneId", int.Parse(cmbRed1.Text));
                cmd.Parameters.AddWithValue("@redTeamTwoId", int.Parse(cmbRed2.Text));
                cmd.Parameters.AddWithValue("@redTeamThreeId", int.Parse(cmbRed3.Text));
                cmd.Parameters.AddWithValue("@blueTeamOneId", int.Parse(cmbBlue1.Text));
                cmd.Parameters.AddWithValue("@blueTeamTwoId", int.Parse(cmbBlue2.Text));
                cmd.Parameters.AddWithValue("@blueTeamThreeId", int.Parse(cmbBlue3.Text));
                cmd.Parameters.AddWithValue("@readyToExport", "false");

                cmd.ExecuteNonQuery();
                
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
}
