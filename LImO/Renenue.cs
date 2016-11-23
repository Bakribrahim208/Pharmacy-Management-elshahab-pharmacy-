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
    public partial class Revunes : Form
    {
        Bussiness_layer.Revenue rev = new Bussiness_layer.Revenue();
        public Revunes()
        {
            InitializeComponent();
            refresh_dataGridview();

        }
        public void refresh_dataGridview()
        {
            DG_Revenue.DataSource = rev.Get_all_revenue();
            DG_Revenue.Columns[0].Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            add_revenue add = new add_revenue();
            add.ShowDialog();
            refresh_dataGridview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد مسح هذا الايراد؟", " مسح ايراد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                rev.Delete_revenue(Convert.ToInt32(DG_Revenue.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم مسح الايراد بنجاح", "مسح ايراد");
                refresh_dataGridview();
            }

        }

        private void Revunes_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
             
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
