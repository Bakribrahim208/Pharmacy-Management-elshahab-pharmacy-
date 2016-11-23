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
    public partial class espeness : Form
    {
        Bussiness_layer.EXpenses ex = new Bussiness_layer.EXpenses();
        public espeness()
        {
            InitializeComponent();
            play_data_in_datagrid();
            DeleteBtn.Enabled = false;
        }
        public void play_data_in_datagrid()
        {
            DG_expenses.DataSource = ex.Get_all_Expenses();
            DG_expenses.Columns[0].Visible = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        
        }

        private void espeness_Load(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void txtday_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void DG_expenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

      

        private void showALl_Click(object sender, EventArgs e)
        {
            this.Size = new Size(706, 523);
            DeleteBtn.Enabled = true;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (txtdate.Value != null && txtpay.Text != string.Empty && txtday.Text != string.Empty)
            {
                ex.ADD_Expenses(txtday.Text, txtdate.Value, txtdes.Text, txtpay.Text);
                show.Text = "تم اضافه المصروفات بنجاح ";
                show.Visible = true;
                txtday.Text = "";
                txtpay.Clear();
                txtdes.Clear();
                play_data_in_datagrid();
            }
            else
                MessageBox.Show("يجب ادخال قيم ف الحقول التاريخ واليوم المدفوعات", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
             if (MessageBox.Show("هل تريد مسح هذا المصروف؟", " مسح المصروف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                ex.Delete_Expenses(Convert.ToInt32(DG_expenses.CurrentRow.Cells[0].Value));
                show.Text = "تم مسح المصروف المحدد";
                play_data_in_datagrid();
                show.Visible = true;
            }
        }

        private void txtday_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            show.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
