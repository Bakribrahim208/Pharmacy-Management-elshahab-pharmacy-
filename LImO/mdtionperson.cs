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
    public partial class mdtionperson : Form
    {
        Bussiness_layer.mdtional md = new Bussiness_layer.mdtional();
        public mdtionperson()
        {
            InitializeComponent();
        }
        public void showdata()
        {
            DG_expenses.DataSource = md.Get_ALL_mdionatperson();
            DG_expenses.Columns[0].Visible = false;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (txtname.Text != string.Empty && txtvalue.Text != string.Empty)
            {
                md.ADD_mdtion_person(txtname.Text, txtcategory.Text, txtdate.Value, txtvalue.Text, txtphone.Text);
                show.Text = "تمت الاضافه بنجاح";
                txtphone.Clear();
                txtname.Clear();
                txtcategory.Clear();
                txtvalue.Clear();

                showdata();
            }
            else
                MessageBox.Show("يجب ادخال قيمه ف الحقول الاسم والقيمه ", "معلومات ناقصه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد مسح الديونه المحدده", "مسح مديونه اشخاص ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                md.DElete_mdtion_perso(Convert.ToInt32(DG_expenses.CurrentRow.Cells[0].Value));
                show.Text = "تم المسح بنجاح";
                showdata();
            }
            else MessageBox.Show("لم يتم المسح", "مسح مديونه", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
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
