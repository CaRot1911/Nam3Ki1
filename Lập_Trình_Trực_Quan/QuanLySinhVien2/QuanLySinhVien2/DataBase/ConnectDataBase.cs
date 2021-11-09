using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien2.DataBase
{
    class ConnectDataBase
    {
        // Khai bao biến toàn cục
        String strCon = "Data Source=DUONGCONGCHUA;Initial Catalog=StudentScore;Integrated Security=True;User ID=DUONGCONGCHUA;Password=123456";
        private SqlConnection sqlConnect = null;


        //Connection
        void ConnectToDataBase()
        {
            sqlConnect = new SqlConnection(strCon);
            if (sqlConnect.State != ConnectionState.Open)
            {
                sqlConnect.Open();
            }
        }

        //Disconnect
        void Disconnet()
        {
            if (sqlConnect.State != ConnectionState.Closed)
            {
                sqlConnect.Close();
                sqlConnect.Dispose();
            }
        }

        //Excute Query
        public DataTable DataReader(string query)
        {
            DataTable tblData = new DataTable();
            ConnectToDataBase();
            SqlDataAdapter sqlData = new SqlDataAdapter(query, sqlConnect);
            sqlData.Fill(tblData);
            Disconnet();
            return tblData;
        }

        // Inser Update Delete
        public void DataChange(string query)
        {
            ConnectToDataBase();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnect;
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
            Disconnet();
        }
    }
}

