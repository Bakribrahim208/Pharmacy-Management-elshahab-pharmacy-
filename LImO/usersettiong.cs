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
    public partial class usersettiong : Form
    {
        Bussiness_layer.Login log = new Bussiness_layer.Login();
        public usersettiong()
        {
            InitializeComponent();
            dataGridView2.DataSource = log.search_useres("");

        }

        private void usersettiong_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            user us = new user();
            us.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            user us = new LImO.user();
            us.Text = "تعديل المستخدم ";
            us.savebtn.Text = "تعديل مستخدم";
            us.fullname.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            us.password.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            us.confirmpass.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            us.username.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            us.comboBox1.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();

            us.ShowDialog();
            dataGridView2.DataSource = log.search_useres("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المستخد المحدد ", "حذف مستخدم", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                log.Delete_user(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تم مسح المستخدم ", "حذف مستخدم");
                dataGridView2.DataSource = log.search_useres("");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_text_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = log.search_useres(search_text.Text);
        }
    }
}
