using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace LImO
{
    public partial class login : Form
    {
        Bussiness_layer.Login log = new Bussiness_layer.Login();
        public login()
        {
            InitializeComponent();
        }

        private void logbut_Click(object sender, EventArgs e)
        {
             
            if (usernamrtxt.Text == string.Empty || passtxt.Text == string.Empty)
            {
                MessageBox.Show("ادخل البيانات المطلوبه", "خطا ف تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable dt = new DataTable();

            dt = log.login(usernamrtxt.Text, passtxt.Text);
            if (dt.Rows.Count > 0)
            {
                // MessageBox.Show("تم تسجيل الدخول بنجاح", "تسجيل دخول ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SystemSounds.Beep.Play();
               if (dt.Rows[0][2].ToString() == "ادمن")
                     {
                         MessageBox.Show("  تم تسجيل الدحول بنجاح كادمن ", "دخول ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         Mainmenu.getmaianmenu .ShortComing.Enabled = true;
                         Mainmenu.getmaianmenu.REvenue.Enabled= true;
                         Mainmenu.getmaianmenu.personAMD.Enabled = true;
                         Mainmenu.getmaianmenu.expenes.Enabled = true;
                         Mainmenu.getmaianmenu.cOmpany.Enabled = true;
                         Mainmenu.getmaianmenu.login.Enabled = false;
                         Mainmenu.getmaianmenu.USERES.Enabled= true;
                         Mainmenu.getmaianmenu.logout.Enabled = true;
                         Mainmenu.getmaianmenu.DataBS.Enabled = true;
                         Mainmenu.getmaianmenu.usersetting.Enabled = true;

                         this.Close();
                     }
               else  
                     {
                         MessageBox.Show("تم تسجيل الدحول بنجاح كمستخدم عادي ", "دخول ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         Mainmenu.getmaianmenu.ShortComing.Enabled = true;
                         Mainmenu.getmaianmenu.REvenue.Enabled = true;
                         Mainmenu.getmaianmenu.personAMD.Enabled = true;
                         Mainmenu.getmaianmenu.expenes.Enabled = true;
                         Mainmenu.getmaianmenu.cOmpany.Enabled = true;
                         Mainmenu.getmaianmenu.login.Enabled = false;
                         Mainmenu.getmaianmenu.USERES.Enabled = true;
                         Mainmenu.getmaianmenu.logout.Enabled = true;

                         //and user form will be disable

                         this.Close();
                     }
                    
                 }
             
            else
                MessageBox.Show("كلمه المرور او اسم المستخدم خطأ ", "تسجيل دخول ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                passtxt.PasswordChar = (char)0;

            }
            else
                passtxt.PasswordChar = '*';
        }

        private void closebut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
