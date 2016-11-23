using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LImO
{
    public partial class user : Form
    {
        Bussiness_layer.Login log = new Bussiness_layer.Login();
        public user()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (username.Text == string.Empty || password.Text == string.Empty || confirmpass.Text == string.Empty || fullname.Text == string.Empty)
            {
                MessageBox.Show("اكمل الملعومات الناقصه ", "خطا ف المعلومات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password.Text != confirmpass.Text)
            {
                MessageBox.Show("كلمتي السر غير متطابقتين ", "خطأ ف كلمه السر ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (savebtn.Text == "حفظ المستخدم")
            {
                log.ADD_USER  (username.Text, password.Text, comboBox1.Text, fullname.Text);
                MessageBox.Show("تم اضافه المتسخدم", "اضافه مستخدم جديد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (savebtn.Text == "تعديل مستخدم")
            {
                log.Edit_USER (username.Text, password.Text, comboBox1.Text, fullname.Text);
                MessageBox.Show("تم تعديل المتسخدم", "تعديل مستخدم ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            password.Clear();
            fullname.Clear();
            confirmpass.Clear();
            username.Clear();
            savebtn.Text = "حفظ المستخدم";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
