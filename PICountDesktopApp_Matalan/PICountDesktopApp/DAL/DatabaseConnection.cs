using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace PICountDesktopApp.DAL
{
    class DatabaseConnection
    {
        #region Properties

        /// <summary>
        /// Properties for cnDbConnection.
        /// </summary>

        public SqlConnection CnDbConnection
        {
            get;
            set;
        }

        /// <summary>
        /// Db Connection Failure Message
        /// </summary>
        public string DbConnectionFailureMessage
        {
            get;
            set;
        }

        /// <summary>
        ///Connection String
        /// </summary>
        public string dbCntStr
        {
            get;
            set;
        }
        #endregion Properties

        #region Constructor

        #region DbConnection
        /// <summary>
        /// Constructor for DbConnection class.  In this constructor
        /// database connection to cnDbConnection is initialised.
        /// </summary>
        public DatabaseConnection()
        {

            try
            {
                
                dbCntStr = (null != ConfigurationManager.ConnectionStrings["AppConnectionString"]) ? ConfigurationManager.ConnectionStrings["AppConnectionString"].ConnectionString : "";
                                    
                CnDbConnection = new SqlConnection(dbCntStr);

                if ((null != CnDbConnection) && (CnDbConnection.ConnectionString.Trim().Length > 0))
                {
                    CnDbConnection.Open();
                    DbConnectionFailureMessage = "";
                }
                else
                {
                    DbConnectionFailureMessage = "Unable to establish DB connection";
                }
            }
            catch (SqlException ex)
            {
                DbConnectionFailureMessage = "Server Error!!! " + ex.Message;
            }
        }
        #endregion DbConnection

        #endregion Constructor

        #region Public Method

        #region CloseDbConnection
        /// <summary>
        /// Method for closing sqldbconnection. Each time 
        /// the connection is used it must be closed.
        /// </summary>
        public void CloseDbConnection()
        {
            if ((null != CnDbConnection) && (CnDbConnection.State != System.Data.ConnectionState.Closed))
            {
                CnDbConnection.Close();
            }
        }
        #endregion CloseDbConnection

        #endregion Public Method
    }
}
