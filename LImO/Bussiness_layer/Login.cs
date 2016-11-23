using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace LImO.Bussiness_layer
{
    class Login
    {
        Data_access_layer.Data_access_layer dal = new Data_access_layer.Data_access_layer();
        public DataTable login(string username, string password)//we will get the values of username and password from form
        {

            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@username", SqlDbType.VarChar, 50);
            param[0].Value = username;
            param[1] = new SqlParameter("@password", SqlDbType.VarChar, 50);
            param[1].Value = password;
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.select("login", param); //??? we should close connection or not????
            dal.close();
            return dt;
        }

        public void ADD_USER(string Username, string password, string usertype, string FullName)
        {
             dal.open();
            SqlParameter[] param = new SqlParameter[4];


            param[0] = new SqlParameter("@Username", SqlDbType.VarChar, 50);
            param[0].Value = Username;

            param[1] = new SqlParameter("@password", SqlDbType.VarChar, 50);
            param[1].Value = password;

            param[2] = new SqlParameter("@usertype", SqlDbType.VarChar, 15);
            param[2].Value = usertype;

            param[3] = new SqlParameter("@FullName", SqlDbType.VarChar, 25);
            param[3].Value = FullName;


            dal.ExecuteCommand("ADD_USER", param);
            dal.close();

        }
        public DataTable search_useres(string search_word)
        {

            dal.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@word_search", SqlDbType.VarChar, 50);
            param[0].Value = search_word;

            dt = dal.select("search_useres", param);
            dal.close();
            return dt;
        }
        public void Edit_USER(string Username, string password, string usertype, string FullName)
        {
             
            dal.open();
            SqlParameter[] param = new SqlParameter[4];


            param[0] = new SqlParameter("@Username", SqlDbType.VarChar, 50);
            param[0].Value = Username;

            param[1] = new SqlParameter("@password", SqlDbType.VarChar, 50);
            param[1].Value = password;

            param[2] = new SqlParameter("@usertype", SqlDbType.VarChar, 50);
            param[2].Value = usertype;

            param[3] = new SqlParameter("@FullName", SqlDbType.VarChar, 50);
            param[3].Value = FullName;


            dal.ExecuteCommand("Edit_USER", param);
            dal.close();

        }

        public void Delete_user(string Username)
        {
            
            dal.open();
            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@username", SqlDbType.VarChar, 50);
            param[0].Value = Username;
            dal.ExecuteCommand("Delete_user", param);
            dal.close();

        }

    }
}
