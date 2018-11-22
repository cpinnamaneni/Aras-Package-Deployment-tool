namespace WindowsFormsApp2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inFolder_btn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pre_imp_btn = new System.Windows.Forms.Button();
            this.post_impt_btn = new System.Windows.Forms.Button();
            this.aras_inn_fldr_btn = new System.Windows.Forms.Button();
            this.url = new System.Windows.Forms.TextBox();
            this.url_Label = new System.Windows.Forms.Label();
            this.db_label = new System.Windows.Forms.Label();
            this.userid_label = new System.Windows.Forms.Label();
            this.user_id = new System.Windows.Forms.TextBox();
            this.paswrd = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.button2_login = new System.Windows.Forms.Button();
            this.database = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmd_status = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.log_path = new System.Windows.Forms.TextBox();
            this.log_path_lbl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inn_fold_path = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pre_imp_fold_path = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.post_inp_fold_path = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.aras_inn_fldr_path = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inFolder_btn
            // 
            this.inFolder_btn.Location = new System.Drawing.Point(630, 9);
            this.inFolder_btn.Name = "inFolder_btn";
            this.inFolder_btn.Size = new System.Drawing.Size(33, 23);
            this.inFolder_btn.TabIndex = 0;
            this.inFolder_btn.Text = "...";
            this.toolTip1.SetToolTip(this.inFolder_btn, "Select the Folder where images are saved");
            this.inFolder_btn.UseVisualStyleBackColor = true;
            this.inFolder_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pre_imp_btn
            // 
            this.pre_imp_btn.Location = new System.Drawing.Point(632, 170);
            this.pre_imp_btn.Name = "pre_imp_btn";
            this.pre_imp_btn.Size = new System.Drawing.Size(33, 23);
            this.pre_imp_btn.TabIndex = 26;
            this.pre_imp_btn.Text = "...";
            this.toolTip1.SetToolTip(this.pre_imp_btn, "Select the Folder where images are saved");
            this.pre_imp_btn.UseVisualStyleBackColor = true;
            this.pre_imp_btn.Click += new System.EventHandler(this.pre_imp_btn_Click);
            // 
            // post_impt_btn
            // 
            this.post_impt_btn.Location = new System.Drawing.Point(632, 207);
            this.post_impt_btn.Name = "post_impt_btn";
            this.post_impt_btn.Size = new System.Drawing.Size(33, 23);
            this.post_impt_btn.TabIndex = 29;
            this.post_impt_btn.Text = "...";
            this.toolTip1.SetToolTip(this.post_impt_btn, "Select the Folder where images are saved");
            this.post_impt_btn.UseVisualStyleBackColor = true;
            this.post_impt_btn.Click += new System.EventHandler(this.post_impt_btn_Click);
            // 
            // aras_inn_fldr_btn
            // 
            this.aras_inn_fldr_btn.Location = new System.Drawing.Point(630, 35);
            this.aras_inn_fldr_btn.Name = "aras_inn_fldr_btn";
            this.aras_inn_fldr_btn.Size = new System.Drawing.Size(33, 23);
            this.aras_inn_fldr_btn.TabIndex = 32;
            this.aras_inn_fldr_btn.Text = "...";
            this.toolTip1.SetToolTip(this.aras_inn_fldr_btn, "Select the Folder where images are saved");
            this.aras_inn_fldr_btn.UseVisualStyleBackColor = true;
            this.aras_inn_fldr_btn.Click += new System.EventHandler(this.aras_inn_fldr_btn_Click);
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(112, 32);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(343, 20);
            this.url.TabIndex = 1;
            // 
            // url_Label
            // 
            this.url_Label.AutoSize = true;
            this.url_Label.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url_Label.Location = new System.Drawing.Point(67, 35);
            this.url_Label.Name = "url_Label";
            this.url_Label.Size = new System.Drawing.Size(32, 15);
            this.url_Label.TabIndex = 2;
            this.url_Label.Text = "URL";
            // 
            // db_label
            // 
            this.db_label.AutoSize = true;
            this.db_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_label.Location = new System.Drawing.Point(40, 75);
            this.db_label.Name = "db_label";
            this.db_label.Size = new System.Drawing.Size(66, 13);
            this.db_label.TabIndex = 6;
            this.db_label.Text = "Data Base";
            // 
            // userid_label
            // 
            this.userid_label.AutoSize = true;
            this.userid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userid_label.Location = new System.Drawing.Point(545, 35);
            this.userid_label.Name = "userid_label";
            this.userid_label.Size = new System.Drawing.Size(48, 13);
            this.userid_label.TabIndex = 7;
            this.userid_label.Text = "User Id";
            // 
            // user_id
            // 
            this.user_id.Location = new System.Drawing.Point(599, 34);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(159, 20);
            this.user_id.TabIndex = 9;
            // 
            // paswrd
            // 
            this.paswrd.AutoSize = true;
            this.paswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paswrd.Location = new System.Drawing.Point(532, 66);
            this.paswrd.Name = "paswrd";
            this.paswrd.Size = new System.Drawing.Size(61, 13);
            this.paswrd.TabIndex = 10;
            this.paswrd.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(599, 63);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(159, 20);
            this.password.TabIndex = 11;
            // 
            // button2_login
            // 
            this.button2_login.Location = new System.Drawing.Point(691, 89);
            this.button2_login.Name = "button2_login";
            this.button2_login.Size = new System.Drawing.Size(75, 23);
            this.button2_login.TabIndex = 12;
            this.button2_login.Text = "Login";
            this.button2_login.UseVisualStyleBackColor = true;
            this.button2_login.Click += new System.EventHandler(this.button2_login_Click);
            // 
            // database
            // 
            this.database.FormattingEnabled = true;
            this.database.Location = new System.Drawing.Point(112, 66);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(220, 21);
            this.database.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(471, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(158, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Execute";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.execute_Click);
            // 
            // cmd_status
            // 
            this.cmd_status.Location = new System.Drawing.Point(5, 381);
            this.cmd_status.Multiline = true;
            this.cmd_status.Name = "cmd_status";
            this.cmd_status.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.cmd_status.Size = new System.Drawing.Size(761, 357);
            this.cmd_status.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(632, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(158, 105);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(447, 20);
            this.path.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "mf File Path";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // log_path
            // 
            this.log_path.Location = new System.Drawing.Point(158, 134);
            this.log_path.Name = "log_path";
            this.log_path.Size = new System.Drawing.Size(447, 20);
            this.log_path.TabIndex = 21;
            // 
            // log_path_lbl
            // 
            this.log_path_lbl.Location = new System.Drawing.Point(632, 131);
            this.log_path_lbl.Name = "log_path_lbl";
            this.log_path_lbl.Size = new System.Drawing.Size(33, 23);
            this.log_path_lbl.TabIndex = 20;
            this.log_path_lbl.Text = "...";
            this.log_path_lbl.UseVisualStyleBackColor = true;
            this.log_path_lbl.Click += new System.EventHandler(this.log_path_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Log File";
            // 
            // inn_fold_path
            // 
            this.inn_fold_path.Location = new System.Drawing.Point(156, 9);
            this.inn_fold_path.Name = "inn_fold_path";
            this.inn_fold_path.Size = new System.Drawing.Size(447, 20);
            this.inn_fold_path.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Innovator Folder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Pre-Imports Folder";
            // 
            // pre_imp_fold_path
            // 
            this.pre_imp_fold_path.Location = new System.Drawing.Point(158, 170);
            this.pre_imp_fold_path.Name = "pre_imp_fold_path";
            this.pre_imp_fold_path.Size = new System.Drawing.Size(447, 20);
            this.pre_imp_fold_path.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Post-Imports Folder";
            // 
            // post_inp_fold_path
            // 
            this.post_inp_fold_path.Location = new System.Drawing.Point(158, 207);
            this.post_inp_fold_path.Name = "post_inp_fold_path";
            this.post_inp_fold_path.Size = new System.Drawing.Size(447, 20);
            this.post_inp_fold_path.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Innovator Folder(Aras)";
            // 
            // aras_inn_fldr_path
            // 
            this.aras_inn_fldr_path.Location = new System.Drawing.Point(156, 35);
            this.aras_inn_fldr_path.Name = "aras_inn_fldr_path";
            this.aras_inn_fldr_path.Size = new System.Drawing.Size(447, 20);
            this.aras_inn_fldr_path.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(665, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "* source folder";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(663, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "* destination folder";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.aras_inn_fldr_path);
            this.groupBox1.Controls.Add(this.aras_inn_fldr_btn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.inn_fold_path);
            this.groupBox1.Controls.Add(this.inFolder_btn);
            this.groupBox1.Location = new System.Drawing.Point(2, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 78);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Copy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(770, 750);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.post_inp_fold_path);
            this.Controls.Add(this.post_impt_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pre_imp_fold_path);
            this.Controls.Add(this.pre_imp_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.log_path);
            this.Controls.Add(this.log_path_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.path);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cmd_status);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.database);
            this.Controls.Add(this.button2_login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.paswrd);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.userid_label);
            this.Controls.Add(this.db_label);
            this.Controls.Add(this.url_Label);
            this.Controls.Add(this.url);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Deployment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MouseHover += new System.EventHandler(this.button_MouseHover);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inFolder_btn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Label url_Label;
        private System.Windows.Forms.Label db_label;
        private System.Windows.Forms.Label userid_label;
        private System.Windows.Forms.TextBox user_id;
        private System.Windows.Forms.Label paswrd;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button button2_login;
        private System.Windows.Forms.ComboBox database;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox cmd_status;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox log_path;
        private System.Windows.Forms.Button log_path_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inn_fold_path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pre_imp_fold_path;
        private System.Windows.Forms.Button pre_imp_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox post_inp_fold_path;
        private System.Windows.Forms.Button post_impt_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox aras_inn_fldr_path;
        private System.Windows.Forms.Button aras_inn_fldr_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

