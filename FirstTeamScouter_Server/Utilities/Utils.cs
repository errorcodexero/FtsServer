using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace FirstTeamScouter_Server
{
    class Utils
    {
        public static String getConnectionString()
        {
            String connectionString = (Program.TEST_MODE) ? Program.conTestString : Program.conString;
            return connectionString;
        }

        public static bool openConnection(MySqlConnection connection, Label lblStatus)
        {
            bool connectionAvailable = true;

            try
            {
                connection.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                string message = "Unable to open MySQL connection - check if the database is installed and running!";
                Console.Out.WriteLine(message);
                lblStatus.Text = message;
                connectionAvailable = false;
            }
            catch (Exception)
            {
                string message = "Unknown issue at open - check if the database is installed and running!";
                Console.Out.WriteLine(message);
                lblStatus.Text = message;
                connectionAvailable = false;
            }

            return connectionAvailable;
        }

        public static long getLongIDFromComboSelectedValue(ComboBox combo, Label lblStatus)
        {
            long ID = -1;
            
            try
            {
                object val = combo.SelectedValue;
                if ((val != null) && (val.GetType() != typeof(DataRowView)))
                {
                    ID = Convert.ToInt64(val);
                }
                
            }
            catch (Exception)
            {
                if (ID == -1)
                {
                    string message = "Selected Value failed conversion to long for: " + combo.Name;
                    Console.Out.WriteLine(message);
                    if (lblStatus != null)
                    {
                        lblStatus.Text = message;
                    }
                }
                //throw;
            }
            return ID;
        }
    }
}
