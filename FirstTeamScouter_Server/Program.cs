using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.Odbc;
using MySql.Data.MySqlClient;
using System.Data;


namespace FirstTeamScouter_Server
{
    static class Program
    {
        // globals

        public static Boolean TEST_MODE = true;

        public static long id = -1, tablet_id = -1;
        public static int team_number = -1, team_sub_number = -1, num_team_members = -1, team_creation_year = -1;
        public static string team_name = "", team_city = "", team_state = "";
        public static bool ready_to_export = false;

        public static String conString =
            "server=localhost;" +
            "port=3306;" +
            "uid=ftsscout;" +
            "pwd=ftsscouter;" +
            "database=firstteamscouter;";

        public static String conTestString =
            "server=localhost;" +
            "port=3306;" +
            "uid=ftsscout;" +
            "pwd=ftsscouter;" +
            "database=firstteamscouter_test;";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //while (queryResults.Read())
            //{
            //    try { id = queryResults.GetInt64(0); }
            //    catch (InvalidCastException) { }

            //    try { tablet_id = queryResults.GetInt64(1); }
            //    catch (InvalidCastException) { }

            //    try { team_number = queryResults.GetInt32(2); }
            //    catch (InvalidCastException) { }

            //    try { team_sub_number = queryResults.GetInt32(3); }
            //    catch (InvalidCastException) { }

            //    try { num_team_members = queryResults.GetInt32(4); }
            //    catch (InvalidCastException) { }

            //    try { team_creation_year = queryResults.GetInt32(5); }
            //    catch (InvalidCastException) { }

            //    try { team_number = queryResults.GetInt32(6); }
            //    catch (InvalidCastException) { }

            //    try { team_name = queryResults.GetString(7); }
            //    catch (InvalidCastException) { }

            //    try { team_city = queryResults.GetString(8); }
            //    catch (InvalidCastException) { }

            //    try { team_state = queryResults.GetString(9); }
            //    catch (InvalidCastException) { }

            //    try { ready_to_export = queryResults.GetBoolean(10); }
            //    catch (InvalidCastException) { }
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Form1 frm = new Form1();
                Application.Run(frm);
            }
            catch (Exception)
            {
                Console.Out.WriteLine("Could not create form due to database issues");
            }
            
        }

        
    }
}
