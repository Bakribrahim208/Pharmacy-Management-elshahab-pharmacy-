namespace LImO
{
    partial class login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logbut = new System.Windows.Forms.Button();
            this.closebut = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernamrtxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImage = global::LImO.Properties.Resources._11992106_708123659331491_528230389_n;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.logbut);
            this.groupBox1.Controls.Add(this.closebut);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.usernamrtxt);
            this.groupBox1.Controls.Add(this.passtxt);
            this.groupBox1.Location = new System.Drawing.Point(0, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 300);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LImO.Properties.Resources.download1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 268);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // logbut
            // 
            this.logbut.BackColor = System.Drawing.SystemColors.Control;
            this.logbut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logbut.CausesValidation = false;
            this.logbut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.logbut.FlatAppearance.BorderSize = 3;
            this.logbut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logbut.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logbut.Image = global::LImO.Properties.Resources.download3;
            this.logbut.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.logbut.ImageKey = "(none)";
            this.logbut.Location = new System.Drawing.Point(533, 241);
            this.logbut.Name = "logbut";
            this.logbut.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.logbut.Size = new System.Drawing.Size(139, 37);
            this.logbut.TabIndex = 5;
            this.logbut.Text = "تسجيل ";
            this.logbut.UseVisualStyleBackColor = false;
            this.logbut.Click += new System.EventHandler(this.logbut_Click);
            // 
            // closebut
            // 
            this.closebut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.closebut.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closebut.Image = global::LImO.Properties.Resources._1441904201_exit;
            this.closebut.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.closebut.Location = new System.Drawing.Point(354, 241);
            this.closebut.Name = "closebut";
            this.closebut.Size = new System.Drawing.Size(139, 37);
            this.closebut.TabIndex = 6;
            this.closebut.Text = "خروج";
            this.closebut.UseVisualStyleBackColor = false;
            this.closebut.Click += new System.EventHandler(this.closebut_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(354, 173);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "عرض الباسورد";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "اسم المستخدم";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(540, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "كلمه المرور";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // usernamrtxt
            // 
            this.usernamrtxt.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.usernamrtxt.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamrtxt.Location = new System.Drawing.Point(283, 25);
            this.usernamrtxt.Name = "usernamrtxt";
            this.usernamrtxt.Size = new System.Drawing.Size(233, 33);
            this.usernamrtxt.TabIndex = 1;
            // 
            // passtxt
            // 
            this.passtxt.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.passtxt.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Location = new System.Drawing.Point(283, 106);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(233, 33);
            this.passtxt.TabIndex = 2;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 306);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button logbut;
        private System.Windows.Forms.Button closebut;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernamrtxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}