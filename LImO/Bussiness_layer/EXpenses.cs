using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace LImO.Bussiness_layer
{
    class EXpenses
    {
        
        Data_access_layer.Data_access_layer dal = new Data_access_layer.Data_access_layer();

        public void ADD_Expenses(string day, DateTime date, string Destination, string pay)
        {
            dal.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@day", SqlDbType.VarChar, 20);
            param[0].Value = day;

            param[1] = new SqlParameter("@date", SqlDbType.Date);
            param[1].Value = date;

            param[2] = new SqlParameter("@Destination ", SqlDbType.VarChar, 50);
            param[2].Value = Destination;

            param[3] = new SqlParameter("@pay ", SqlDbType.VarChar, 50);
            param[3].Value = pay;


            dal.ExecuteCommand("ADD_Expenses", param);
            dal.close();

        }
        public DataTable Get_all_Expenses()
        {

            dal.open();
            DataTable dt = new DataTable();
            dt = dal.select("all_Expenses", null);
            dal.close();
            return dt;
        }
        public void Delete_Expenses(int id)
        {
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dal.ExecuteCommand("Delete_Expenses", param);
            dal.close();

        }
    }
}
