﻿namespace LImO
{
    partial class mdionatCompanies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DG_expenses = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtday = new System.Windows.Forms.ComboBox();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtvalue = new System.Windows.Forms.TextBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_expenses)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::LImO.Properties.Resources._11992106_708123659331491_528230389_n;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.show);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(970, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::LImO.Properties.Resources._11992106_708123659331491_528230389_n;
            this.groupBox2.Controls.Add(this.DeleteBtn);
            this.groupBox2.Controls.Add(this.AddBtn);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(717, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 234);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteBtn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DeleteBtn.Image = global::LImO.Properties.Resources._1441912041_delete;
            this.DeleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteBtn.Location = new System.Drawing.Point(22, 94);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(186, 63);
            this.DeleteBtn.TabIndex = 34;
            this.DeleteBtn.Text = "حذف   ";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddBtn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AddBtn.Image = global::LImO.Properties.Resources._1441911963_add;
            this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddBtn.Location = new System.Drawing.Point(22, 19);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(186, 63);
            this.AddBtn.TabIndex = 28;
            this.AddBtn.Text = "اضافه  ";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(22, 163);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 61);
            this.button5.TabIndex = 35;
            this.button5.Text = "خروج";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.SystemColors.Control;
            this.show.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.ForeColor = System.Drawing.Color.Red;
            this.show.Location = new System.Drawing.Point(180, 175);
            this.show.Name = "show";
            this.show.Padding = new System.Windows.Forms.Padding(3);
            this.show.Size = new System.Drawing.Size(459, 45);
            this.show.TabIndex = 43;
            this.show.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::LImO.Properties.Resources._11992106_708123659331491_528230389_n;
            this.groupBox3.Controls.Add(this.DG_expenses);
            this.groupBox3.Location = new System.Drawing.Point(6, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(705, 187);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            // 
            // DG_expenses
            // 
            this.DG_expenses.AllowUserToAddRows = false;
            this.DG_expenses.AllowUserToDeleteRows = false;
            this.DG_expenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_expenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_expenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_expenses.DefaultCellStyle = dataGridViewCellStyle2;
            this.DG_expenses.Location = new System.Drawing.Point(6, 19);
            this.DG_expenses.Name = "DG_expenses";
            this.DG_expenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_expenses.Size = new System.Drawing.Size(693, 162);
            this.DG_expenses.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.BackgroundImage = global::LImO.Properties.Resources._11992106_708123659331491_528230389_n;
            this.groupBox6.Controls.Add(this.txtday);
            this.groupBox6.Controls.Add(this.txtdate);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.txtvalue);
            this.groupBox6.Controls.Add(this.txtdes);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(6, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(936, 148);
            this.groupBox6.TabIndex = 41;
            this.groupBox6.TabStop = false;
            // 
            // txtday
            // 
            this.txtday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtday.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtday.FormattingEnabled = true;
            this.txtday.Items.AddRange(new object[] {
            "السبت ",
            "الاحد ",
            "الاثنين",
            "الثلاثاء ",
            "الاربعاء ",
            "الخميس ",
            "الجمعه"});
            this.txtday.Location = new System.Drawing.Point(718, 79);
            this.txtday.Name = "txtday";
            this.txtday.Size = new System.Drawing.Size(175, 31);
            this.txtday.TabIndex = 37;
            // 
            // txtdate
            // 
            this.txtdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(487, 79);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(192, 30);
            this.txtdate.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(718, 19);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3);
            this.label7.Size = new System.Drawing.Size(175, 46);
            this.label7.TabIndex = 13;
            this.label7.Text = "اليوم";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtvalue
            // 
            this.txtvalue.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalue.Location = new System.Drawing.Point(260, 82);
            this.txtvalue.Multiline = true;
            this.txtvalue.Name = "txtvalue";
            this.txtvalue.Size = new System.Drawing.Size(188, 39);
            this.txtvalue.TabIndex = 31;
            this.txtvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalue_KeyPress);
            // 
            // txtdes
            // 
            this.txtdes.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdes.Location = new System.Drawing.Point(6, 68);
            this.txtdes.Multiline = true;
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(215, 62);
            this.txtdes.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label16.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label16.Location = new System.Drawing.Point(8, 16);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(3);
            this.label16.Size = new System.Drawing.Size(213, 44);
            this.label16.TabIndex = 19;
            this.label16.Text = "الجهة";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(487, 21);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(3);
            this.label8.Size = new System.Drawing.Size(192, 44);
            this.label8.TabIndex = 15;
            this.label8.Text = "التاريخ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label13.Location = new System.Drawing.Point(260, 19);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(3);
            this.label13.Size = new System.Drawing.Size(188, 44);
            this.label13.TabIndex = 17;
            this.label13.Text = "القيمه";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mdionatCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 431);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mdionatCompanies";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مديونات الشركات والمستودعات";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_expenses)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox txtday;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtvalue;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DG_expenses;
        private System.Windows.Forms.Label show;

    }
}