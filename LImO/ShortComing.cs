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
    public partial class ShortComing : Form
    {
        Bussiness_layer.shotcoming str = new Bussiness_layer.shotcoming();
        public ShortComing()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            showdata();
            this.Size = new Size(875, 515);
        }
        public void showdata()
        {
            dataGridView1.DataSource = str.Get_ALL_shortcoming();
            dataGridView1.Columns[0].Visible = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtcategory.Text != string.Empty && txtnum.Text != string.Empty)
            {
                str.add_shortComing(txtcategory.Text, Convert.ToInt32(txtnum.Text), txtType.Text);
                show.Text = "تمت الاضافه بنجاح";
                txtType.Clear();
                txtnum.Clear();
                txtcategory.Clear();
                showdata();
            }
            else
                MessageBox.Show("يجب ادخال قيم ف الحقول اسم الصنف والعدد ", "معلومات ناقصه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            str.delete_shortcoming(Convert.ToInt32 (dataGridView1.CurrentRow.Cells[0].Value));
            show.Text="تم المسح بنجاح";
            showdata();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            str.edit_shortcoming (Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), txtcategory.Text,Convert.ToInt32( txtnum.Text), txtType.Text);
            show.Text = "تم التعديل بنجاح";
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtcategory.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtnum.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtType.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtcategory.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtnum.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtType.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
