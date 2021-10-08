using System;
using Microsoft.Data.SqlClient;

namespace HeadphoneApi.Services
{
    public class DatabaseHandler
    {
        private string _connectionString = "workstation id=swinburneswd.mssql.somee.com;packet size=4096;user id=swinburne_swd;pwd=TQ,wGzw@9\"}'=[Dm;data source=swinburneswd.mssql.somee.com;persist security info=False;initial catalog=swinburneswd";

        private SqlConnection _connection;


        public string TestConnection() {
            this._connection = new SqlConnection(this._connectionString);

            try {
                this._connection.Open();
                return "Successful";

            } catch (Exception e) {
                return "Unsuccessful";
            }
        }
    }
}