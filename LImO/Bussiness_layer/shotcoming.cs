using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace LImO.Bussiness_layer
{
    class shotcoming
    {
        Data_access_layer.Data_access_layer dal = new Data_access_layer.Data_access_layer();

        public DataTable Get_ALL_shortcoming()
        {

            dal.open();
            DataTable dt = new DataTable();
            dt = dal.select("ALL_shortcoming", null);
            dal.close();
            return dt;
        }
        public void delete_shortcoming(int id)
        {
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dal.ExecuteCommand("delete_shortcoming", param);
            dal.close();

        }
        public void edit_shortcoming(int id,string category, int number, string type)
        {
            dal.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@category", SqlDbType.VarChar, 50);
            param[1].Value = category;

            param[2] = new SqlParameter("@type", SqlDbType.VarChar, 50);
            param[2].Value = type;

            param[3] = new SqlParameter("@number", SqlDbType.Int);
            param[3].Value = number;
            dal.ExecuteCommand("edit_shortcoming", param);
            dal.close();

        }
        public void add_shortComing(  string category, int number, string type)
        {
            dal.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@category", SqlDbType.VarChar, 50);
            param[0].Value = category;

            param[1] = new SqlParameter("@nuber", SqlDbType.Int);
            param[1].Value = number;

            param[2] = new SqlParameter("@type", SqlDbType.VarChar, 50);
            param[2].Value = type;
            dal.ExecuteCommand("add_shortComing", param);
            dal.close();

        }
    }
}
