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
    public partial class Mainmenu : Form
    {
        private static Mainmenu frm;
        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Mainmenu getmaianmenu
        {
            get
            {
                if (frm == null)
                {
                    frm = new Mainmenu();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);
                }
                return frm;
            }
        }
        public Mainmenu()
        {
            InitializeComponent();
            MessageBox.Show("يجب تسجيل الدخول اولا ", "ملحوظه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (frm == null)
                frm = this;
            expenes.Enabled = false;
            ShortComing.Enabled = false;
            USERES.Enabled = false;
            personAMD.Enabled = false;
            cOmpany.Enabled = false;
            REvenue.Enabled = false;
            logout.Enabled = false;
            usersetting.Enabled = false;
           

        }
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

       

        

       

       

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
        }

        

        private void COming_Click(object sender, EventArgs e)
        {
            
        }

        private void person_Click(object sender, EventArgs e)
        {
            
        }

        private void shorCOmIng_Click(object sender, EventArgs e)
        {
           
        }

        private void Mainmenu_Load(object sender, EventArgs e)
        {

        }
      
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            espeness ex = new espeness();
            ex.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShortComing str = new ShortComing();
            str.ShowDialog();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            mdtionperson mp = new mdtionperson();
            mp.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Revunes rev = new Revunes();
            rev.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            mdionatCompanies md = new mdionatCompanies();
            md.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            user us = new user();
            us.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.ShowDialog();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تم تسجيل الخروج نجاح", "تسجيل الخروج", MessageBoxButtons.OK, MessageBoxIcon.Information);
            logout.Enabled = false;
            login.Enabled = true;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            usersettiong us = new usersettiong();
            us.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            programar pro = new programar();
            pro.ShowDialog();
        }

        private void label2_Click_2(object sender, EventArgs e)
        {
            DatabaseSetting dt = new DatabaseSetting();
            dt.ShowDialog();
        }

        private void usersetting_Click(object sender, EventArgs e)
        {
            usersettiong us = new usersettiong();
            us.ShowDialog();
        }
    }
}
