namespace SwimmingPool
{
    partial class UserControlMemberList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSeeEntries = new System.Windows.Forms.Button();
            this.richTextBoxNotes = new System.Windows.Forms.RichTextBox();
            this.buttonSeeNotes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxMembership = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEditProfile = new System.Windows.Forms.Button();
            this.buttonDeleteMember = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.groupBoxManager = new System.Windows.Forms.GroupBox();
            this.buttonAddNewMember = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewMemberList = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSendIndivisualEmail = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxManager.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemberList)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckIn.Location = new System.Drawing.Point(7, 21);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(187, 27);
            this.buttonCheckIn.TabIndex = 2;
            this.buttonCheckIn.Text = "Check-in";
            this.buttonCheckIn.UseVisualStyleBackColor = true;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SaddleBrown;
            this.groupBox2.Controls.Add(this.buttonSeeEntries);
            this.groupBox2.Controls.Add(this.buttonCheckIn);
            this.groupBox2.Location = new System.Drawing.Point(863, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 198);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entries";
            // 
            // buttonSeeEntries
            // 
            this.buttonSeeEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeeEntries.Location = new System.Drawing.Point(6, 56);
            this.buttonSeeEntries.Name = "buttonSeeEntries";
            this.buttonSeeEntries.Size = new System.Drawing.Size(187, 27);
            this.buttonSeeEntries.TabIndex = 3;
            this.buttonSeeEntries.Text = "See Entries";
            this.buttonSeeEntries.UseVisualStyleBackColor = true;
            this.buttonSeeEntries.Click += new System.EventHandler(this.buttonSeeEntries_Click);
            // 
            // richTextBoxNotes
            // 
            this.richTextBoxNotes.Location = new System.Drawing.Point(7, 56);
            this.richTextBoxNotes.Name = "richTextBoxNotes";
            this.richTextBoxNotes.Size = new System.Drawing.Size(280, 136);
            this.richTextBoxNotes.TabIndex = 1;
            this.richTextBoxNotes.Text = "";
            // 
            // buttonSeeNotes
            // 
            this.buttonSeeNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeeNotes.Location = new System.Drawing.Point(7, 22);
            this.buttonSeeNotes.Name = "buttonSeeNotes";
            this.buttonSeeNotes.Size = new System.Drawing.Size(187, 27);
            this.buttonSeeNotes.TabIndex = 0;
            this.buttonSeeNotes.Text = "See Notes";
            this.buttonSeeNotes.UseVisualStyleBackColor = true;
            this.buttonSeeNotes.Click += new System.EventHandler(this.buttonSeeEntries_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Controls.Add(this.richTextBoxNotes);
            this.groupBox1.Controls.Add(this.buttonSeeNotes);
            this.groupBox1.Location = new System.Drawing.Point(560, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 198);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "See Notes Here";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SaddleBrown;
            this.groupBox3.Controls.Add(this.comboBoxMembership);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxNameSearch);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(209, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 198);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sort Members";
            // 
            // comboBoxMembership
            // 
            this.comboBoxMembership.FormattingEnabled = true;
            this.comboBoxMembership.Location = new System.Drawing.Point(115, 63);
            this.comboBoxMembership.Name = "comboBoxMembership";
            this.comboBoxMembership.Size = new System.Drawing.Size(221, 24);
            this.comboBoxMembership.TabIndex = 3;
            this.comboBoxMembership.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMembership_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "By Membership";
            // 
            // textBoxNameSearch
            // 
            this.textBoxNameSearch.Location = new System.Drawing.Point(79, 21);
            this.textBoxNameSearch.Name = "textBoxNameSearch";
            this.textBoxNameSearch.Size = new System.Drawing.Size(257, 22);
            this.textBoxNameSearch.TabIndex = 1;
            this.textBoxNameSearch.TextChanged += new System.EventHandler(this.textBoxNameSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "By Name:";
            // 
            // buttonEditProfile
            // 
            this.buttonEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditProfile.Location = new System.Drawing.Point(6, 85);
            this.buttonEditProfile.Name = "buttonEditProfile";
            this.buttonEditProfile.Size = new System.Drawing.Size(188, 28);
            this.buttonEditProfile.TabIndex = 2;
            this.buttonEditProfile.Text = "Update Profile";
            this.buttonEditProfile.UseVisualStyleBackColor = true;
            this.buttonEditProfile.Click += new System.EventHandler(this.buttonEditProfile_Click);
            // 
            // buttonDeleteMember
            // 
            this.buttonDeleteMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteMember.Location = new System.Drawing.Point(7, 56);
            this.buttonDeleteMember.Name = "buttonDeleteMember";
            this.buttonDeleteMember.Size = new System.Drawing.Size(187, 23);
            this.buttonDeleteMember.TabIndex = 1;
            this.buttonDeleteMember.Text = "Delete this Member";
            this.buttonDeleteMember.UseVisualStyleBackColor = true;
            this.buttonDeleteMember.Click += new System.EventHandler(this.buttonDeleteMember_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(7, 119);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(188, 28);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // groupBoxManager
            // 
            this.groupBoxManager.BackColor = System.Drawing.Color.SaddleBrown;
            this.groupBoxManager.Controls.Add(this.buttonRefresh);
            this.groupBoxManager.Controls.Add(this.buttonEditProfile);
            this.groupBoxManager.Controls.Add(this.buttonDeleteMember);
            this.groupBoxManager.Controls.Add(this.buttonAddNewMember);
            this.groupBoxManager.Location = new System.Drawing.Point(3, 3);
            this.groupBoxManager.Name = "groupBoxManager";
            this.groupBoxManager.Size = new System.Drawing.Size(200, 198);
            this.groupBoxManager.TabIndex = 0;
            this.groupBoxManager.TabStop = false;
            this.groupBoxManager.Text = "Member Manager";
            // 
            // buttonAddNewMember
            // 
            this.buttonAddNewMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewMember.Location = new System.Drawing.Point(6, 21);
            this.buttonAddNewMember.Name = "buttonAddNewMember";
            this.buttonAddNewMember.Size = new System.Drawing.Size(188, 28);
            this.buttonAddNewMember.TabIndex = 0;
            this.buttonAddNewMember.Text = "Add a new Member";
            this.buttonAddNewMember.UseVisualStyleBackColor = true;
            this.buttonAddNewMember.Click += new System.EventHandler(this.buttonAddNewMember_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBoxManager);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1314, 136);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewMemberList, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1320, 569);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridViewMemberList
            // 
            this.dataGridViewMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMemberList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMemberList.Location = new System.Drawing.Point(3, 145);
            this.dataGridViewMemberList.Name = "dataGridViewMemberList";
            this.dataGridViewMemberList.RowHeadersWidth = 51;
            this.dataGridViewMemberList.RowTemplate.Height = 24;
            this.dataGridViewMemberList.Size = new System.Drawing.Size(1314, 421);
            this.dataGridViewMemberList.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.SaddleBrown;
            this.groupBox4.Controls.Add(this.buttonSendIndivisualEmail);
            this.groupBox4.Location = new System.Drawing.Point(1069, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 198);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Other tasks";
            // 
            // buttonSendIndivisualEmail
            // 
            this.buttonSendIndivisualEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendIndivisualEmail.Location = new System.Drawing.Point(7, 21);
            this.buttonSendIndivisualEmail.Name = "buttonSendIndivisualEmail";
            this.buttonSendIndivisualEmail.Size = new System.Drawing.Size(187, 28);
            this.buttonSendIndivisualEmail.TabIndex = 0;
            this.buttonSendIndivisualEmail.Text = "Send Individual Email";
            this.buttonSendIndivisualEmail.UseVisualStyleBackColor = true;
            this.buttonSendIndivisualEmail.Click += new System.EventHandler(this.buttonSendIndivisualEmail_Click);
            // 
            // UserControlMemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControlMemberList";
            this.Size = new System.Drawing.Size(1320, 569);
            this.Load += new System.EventHandler(this.UserControlMemberList_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxManager.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemberList)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSeeEntries;
        private System.Windows.Forms.RichTextBox richTextBoxNotes;
        private System.Windows.Forms.Button buttonSeeNotes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxMembership;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNameSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEditProfile;
        private System.Windows.Forms.Button buttonDeleteMember;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.GroupBox groupBoxManager;
        private System.Windows.Forms.Button buttonAddNewMember;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonSendIndivisualEmail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewMemberList;
    }
}
