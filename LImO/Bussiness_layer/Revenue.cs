using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace LImO.Bussiness_layer
{
     
    class Revenue
    {
        Data_access_layer.Data_access_layer dal = new Data_access_layer.Data_access_layer();
         
        public void AddRevenue(string day, DateTime date, string value_revenue, string notice)
        {
             dal.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Day", SqlDbType.VarChar,20);
            param[0].Value = day;

            param[1] = new SqlParameter("@date", SqlDbType.Date);
            param[1].Value = date;

            param[2] = new SqlParameter("@value_Revenue", SqlDbType.VarChar, 50);
            param[2].Value = value_revenue;

            param[3] = new SqlParameter("@notice", SqlDbType.VarChar,300);
            param[3].Value = notice;


            dal.ExecuteCommand("AddRevenue", param);
            dal.close();

        }
        public void Delete_revenue(int id)
        {
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dal.ExecuteCommand("Delete_revenue", param);
            dal.close();

        }
        public DataTable Get_all_revenue()
        {

            dal.open();
            DataTable dt = new DataTable();
            dt = dal.select("allrevenue", null);
            dal.close();
            return dt;
        }



    }
}
