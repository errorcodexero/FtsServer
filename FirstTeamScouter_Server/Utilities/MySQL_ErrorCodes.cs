using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstTeamScouter_Server.Utilities
{
    public class MySQL_ErrorCodes
    {
        public Dictionary<Int32, String> errorCodes = new Dictionary<Int32, String>();

        public MySQL_ErrorCodes()
        {
            errorCodes.Add(1054, "Bad Field Error");
        }
    }
}
