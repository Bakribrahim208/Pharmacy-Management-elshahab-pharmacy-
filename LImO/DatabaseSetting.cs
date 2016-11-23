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
    public partial class DatabaseSetting : Form
    {
        public DatabaseSetting()
        {
            InitializeComponent();
            servertxt.Text = Properties.Settings.Default.server;
            databasetxt.Text = Properties.Settings.Default.Database;
            if (Properties.Settings.Default.Mode == "SQl")
            {
                radioButton2.Checked = true;
                usertxt.Text = Properties.Settings.Default.id;
                passwordtxt.Text = Properties.Settings.Default.password;
            }
            else
            {
                radioButton1.Checked = true;
                usertxt.Clear();
                passtxt.Clear();
                usertxt.ReadOnly = true;
                passtxt.ReadOnly = true;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.server = servertxt.Text;
            Properties.Settings.Default.Database = databasetxt.Text;
            Properties.Settings.Default.Mode = radioButton2.Checked == true ? "SQL" : "Windows";
            Properties.Settings.Default.id = usertxt.Text;
            Properties.Settings.Default.password = passtxt.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("تم حفظ اعدادات السيرفر بنجاح", "اعدادت السيرفر ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DatabaseSetting_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            usertxt.ReadOnly = false;
            passtxt.ReadOnly = false;
        }
    }
}
