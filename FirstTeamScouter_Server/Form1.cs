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
            LoadData();
        }

        public void LoadData()
        {
            MySqlConnection connection = new MySqlConnection(Program.conString);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT match_number, match_time, match_type, match_location, red_team_one_id, red_team_two_id, red_team_three_id, blue_team_one_id, blue_team_two_id, blue_team_three_id FROM match_data";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                gridMatchList.DataSource = ds.Tables[0].DefaultView;
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

        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            AddMatchForm amForm = new AddMatchForm();
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
    }
}
