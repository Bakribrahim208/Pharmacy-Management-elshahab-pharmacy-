using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LImO.Bussiness_layer
{
    class mdtional
    {
        Data_access_layer.Data_access_layer dal = new Data_access_layer.Data_access_layer();
        public void add_mdionatcmp(string day, DateTime date, string desitnation, string value)
        {
            dal.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@day", SqlDbType.VarChar, 20);
            param[0].Value = day;

            param[1] = new SqlParameter("@date", SqlDbType.Date);
            param[1].Value = date;

            param[2] = new SqlParameter("@desitnation", SqlDbType.VarChar, 50);
            param[2].Value = desitnation;

            param[3] = new SqlParameter("@value ", SqlDbType.VarChar, 50);
            param[3].Value = value;


            dal.ExecuteCommand("add_mdionatperson", param);
            dal.close();

        }
        public void ADD_mdtion_person(string name, string category, DateTime date, string value, string phone)
        {
            dal.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@name", SqlDbType.VarChar, 20);
            param[0].Value = @name;

            param[1] = new SqlParameter("@category", SqlDbType.VarChar,50);
            param[1].Value = category;

            param[2] = new SqlParameter("@date", SqlDbType.Date);
            param[2].Value = date;

            param[3] = new SqlParameter("@value ", SqlDbType.VarChar, 50);
            param[3].Value = value;
            param[4] = new SqlParameter("@phone ", SqlDbType.VarChar, 50);
            param[4].Value = phone;

            dal.ExecuteCommand("ADD_mdtion_person", param);
            dal.close();

        }

        public void Delete_mdionat_com(int id)
        {
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dal.ExecuteCommand("Delete_mdionat_com", param);
            dal.close();

        }
        public void DElete_mdtion_perso(int id)
        {
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dal.ExecuteCommand("DElete_mdtion_perso", param);
            dal.close();

        }

        public DataTable Get_ALL_mdionatCom()
        {

            dal.open();
            DataTable dt = new DataTable();
            dt = dal.select("ALL_mdionatCom", null);
            dal.close();
            return dt;
        }
        public DataTable Get_ALL_mdionatperson()
        {

            dal.open();
            DataTable dt = new DataTable();
            dt = dal.select("ALL_mdionatperson", null);
            dal.close();
            return dt;
        }
    }
}
