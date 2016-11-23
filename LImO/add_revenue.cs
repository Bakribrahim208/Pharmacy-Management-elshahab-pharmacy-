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
    public partial class add_revenue : Form
    {
        Bussiness_layer.Revenue rev = new Bussiness_layer.Revenue();
        public add_revenue()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
             Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (txtday.Text != string.Empty && txtvalue.Text != string.Empty && TxtDate.Value != null)
            {
                rev.AddRevenue(txtday.Text, TxtDate.Value, txtvalue.Text, txtNotice.Text);
                MessageBox.Show("تم اضافه الايراد", "اضافه ايراد جديد");
                txtvalue.Clear();
                txtNotice.Clear();
            }
            else
            {
                MessageBox.Show("يجب اضافه الايراد واليوم والتاريخ", "معلومات ناقصه ",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtvalue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
