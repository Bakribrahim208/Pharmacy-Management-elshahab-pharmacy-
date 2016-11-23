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
    public partial class mdionatCompanies : Form
    {
        Bussiness_layer.mdtional md = new Bussiness_layer.mdtional();
        public mdionatCompanies()
        {
            InitializeComponent();
            showdata(); 
        }
        public void showdata()
        {
            DG_expenses.DataSource = md.Get_ALL_mdionatCom();
            DG_expenses.Columns[0].Visible = false;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (txtvalue.Text != string.Empty && txtdes.Text != string.Empty)
            {
                md.add_mdionatcmp(txtday.Text, txtdate.Value, txtdes.Text, txtvalue.Text);
                show.Text = "تمت الاضافه بنجاح";
                txtvalue.Clear();
                txtdes.Clear();
                showdata();
            }
            else
                MessageBox.Show("يجب ادخال قيمه في حقول الجهة والقيمه ", "معلومات ناقصه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

       
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد مسح المديونه المحدده", "مسح مديونه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                md.Delete_mdionat_com(Convert.ToInt32(DG_expenses.CurrentRow.Cells[0].Value));
                showdata();
                show.Text = "تم المسح بنجاح";
            }
            else
                show.Text = "لم يتم المسح";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();    
        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
