using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace LivePerformance
{
    public static class DatabaseManager
    {
        private static OracleConnection conn;
        static DatabaseManager()
        {
            conn = new OracleConnection();
            #region Secret

            #region No really!
            conn.ConnectionString = "User Id=dbi302722;Password=Pi5XmsCM6L;Data Source=" + " //192.168.15.50:1521/fhictora" + ";";
            #endregion

            #endregion
        }
    }
}
