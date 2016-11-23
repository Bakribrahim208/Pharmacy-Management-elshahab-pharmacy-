namespace LImO
{
    partial class add_revenue
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Button();
            this.addBTN = new System.Windows.Forms.Button();
            this.txtvalue = new System.Windows.Forms.TextBox();
            this.TxtDate = new System.Windows.Forms.DateTimePicker();
            this.txtNotice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtday = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::LImO.Properties.Resources._11992106_708123659331491_528230389_n;
            this.panel1.Controls.Add(this.txtday);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.addBTN);
            this.panel1.Controls.Add(this.txtvalue);
            this.panel1.Controls.Add(this.TxtDate);
            this.panel1.Controls.Add(this.txtNotice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 400);
            this.panel1.TabIndex = 0;
            // 
            // Close
            // 
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Close.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Close.Image = global::LImO.Properties.Resources._1441904201_exit;
            this.Close.Location = new System.Drawing.Point(39, 330);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(129, 34);
            this.Close.TabIndex = 21;
            this.Close.Text = "الغاء";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // addBTN
            // 
            this.addBTN.BackColor = System.Drawing.SystemColors.Control;
            this.addBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addBTN.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBTN.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.addBTN.Image = global::LImO.Properties.Resources._1441911963_add;
            this.addBTN.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.addBTN.Location = new System.Drawing.Point(216, 330);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(146, 34);
            this.addBTN.TabIndex = 20;
            this.addBTN.Text = "اضافه  ";
            this.addBTN.UseVisualStyleBackColor = false;
            this.addBTN.Click += new System.EventHandler(this.add_Click);
            // 
            // txtvalue
            // 
            this.txtvalue.Location = new System.Drawing.Point(39, 144);
            this.txtvalue.Name = "txtvalue";
            this.txtvalue.Size = new System.Drawing.Size(249, 36);
            this.txtvalue.TabIndex = 19;
            this.txtvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalue_KeyPress);
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(39, 80);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(249, 36);
            this.TxtDate.TabIndex = 18;
            // 
            // txtNotice
            // 
            this.txtNotice.Location = new System.Drawing.Point(39, 213);
            this.txtNotice.Multiline = true;
            this.txtNotice.Name = "txtNotice";
            this.txtNotice.Size = new System.Drawing.Size(249, 90);
            this.txtNotice.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(313, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "ملاحظات";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(338, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "الايراد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(336, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "التاريخ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(347, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "يوم";
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
            this.txtday.Location = new System.Drawing.Point(39, 27);
            this.txtday.Name = "txtday";
            this.txtday.Size = new System.Drawing.Size(249, 31);
            this.txtday.TabIndex = 38;
            // 
            // add_revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 406);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_revenue";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "الايراد";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNotice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker TxtDate;
        public System.Windows.Forms.TextBox txtvalue;
        private System.Windows.Forms.Button Close;
        public System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.ComboBox txtday;
    }
}