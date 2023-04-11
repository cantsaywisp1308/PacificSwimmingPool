using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SwimmingPool
{
    public partial class UserControlMemberList : UserControl
    {
        public UserControlMemberList()
        {
            InitializeComponent();
        }

        private void UserControlMemberList_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            var db = new DatabaseContext();
            dataGridViewMemberList.DataSource = db.Members.Select(mem => new
            {
                ID = mem.MemberID,
                First_Name = mem.FirstName,
                Middle_Name = mem.MiddleName,
                Last_Name = mem.LastName,
                Full_Name = mem.FullName,
                Date_Of_Birth = mem.DateOfBirth,
                Phone = mem.Phone,
                Email = mem.Email,
                Number_Of_Entries = mem.NumberOfEntries,
                Membership_Type = mem.Membership.MembershipName,
                Expired_Date = mem.ExpiredDate,
                Notes = mem.Notes
            }).ToList();
            comboBoxMembership.DataSource = db.Memberships.ToList();
            comboBoxMembership.DisplayMember = "MembershipName";
            comboBoxMembership.ValueMember = "MembershipType";
        }

        private void buttonAddNewMember_Click(object sender, EventArgs e)
        {
            var db = new DatabaseContext();
            var addMember = new AddMember();
            addMember.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            var db = new DatabaseContext();
            dataGridViewMemberList.DataSource = db.Members.Select(mem => new
            {
                ID = mem.MemberID,
                First_Name = mem.FirstName,
                Middle_Name = mem.MiddleName,
                Last_Name = mem.LastName,
                Full_Name = mem.FullName,
                Date_Of_Birth = mem.DateOfBirth,
                Phone = mem.Phone,
                Email = mem.Email,
                Number_Of_Entries = mem.NumberOfEntries,
                Membership_Type = mem.Membership.MembershipName,
                Expired_Date = mem.ExpiredDate,
                Notes = mem.Notes
            }).ToList();
        }

        private void buttonDeleteMember_Click(object sender, EventArgs e)
        {
            var db = new DatabaseContext();
            var id = dataGridViewMemberList.CurrentRow.Cells[0].Value.ToString();
            var account = db.Members.SingleOrDefault(acc =>acc.MemberID == id);
            string message = "Are you sure want to delete this member ?";
            string title = "Delete member";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, button);
            if(result == DialogResult.Yes)
            {
                db.Members.Remove(account);

                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Deleted successfully!!!");

                    Panel panelMain = (Panel)Parent;
                    panelMain.Controls.Clear();
                    panelMain.Controls.Add(new UserControlMemberList());
                }
                else
                {
                    MessageBox.Show("Falied to delete this member");
                }
            } else
            {

            }
        }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
            var db = new DatabaseContext();
            var id = dataGridViewMemberList.CurrentRow.Cells[0].Value.ToString();
            var data = new Dictionary<string, object>();
            data.Add("id", id);
            var updateProfile = new UpdateProfile(data);
            updateProfile.Show();
        }

        private void comboBoxMembership_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var db = new DatabaseContext();
            var membershipType = int.Parse(comboBoxMembership.SelectedValue.ToString());
            dataGridViewMemberList.DataSource = db.Members.Where(acc => acc.MembershipType == membershipType).Select(acc => new
            {
                ID = acc.MemberID,
                First_Name = acc.FirstName,
                Middle_Name = acc.MiddleName,
                Last_Name = acc.LastName,
                Full_Name = acc.FullName,
                Date_Of_Birth = acc.DateOfBirth,
                Phone = acc.Phone,
                Email = acc.Email,
                Number_Of_Entries = acc.NumberOfEntries,
                Membership_Type = acc.Membership.MembershipName,
                Expired_Date = acc.ExpiredDate,
                Notes = acc.Notes
            }).ToList();
        }

        private void textBoxNameSearch_TextChanged(object sender, EventArgs e)
        {
            var db = new DatabaseContext();
            var str = textBoxNameSearch.Text;
            dataGridViewMemberList.DataSource = db.Members.Where(acc => acc.FullName.Contains(str)).Select(acc => new
            {
                ID = acc.MemberID,
                First_Name = acc.FirstName,
                Middle_Name = acc.MiddleName,
                Last_Name = acc.LastName,
                Full_Name = acc.FullName,
                Date_Of_Birth = acc.DateOfBirth,
                Phone = acc.Phone,
                Email = acc.Email,
                Number_Of_Entries = acc.NumberOfEntries,
                Membership_Type = acc.Membership.MembershipName,
                Expired_Date = acc.ExpiredDate,
                Notes = acc.Notes
            }).ToList();
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            var db = new DatabaseContext();
            var id = dataGridViewMemberList.CurrentRow.Cells[0].Value.ToString();
            Entry entry = new Entry();
            var account = db.Members.SingleOrDefault(acc => acc.MemberID == id);
            entry.MemberID = id;
            entry.MembershipType = account.MembershipType;
            entry.checkIn = DateTime.Now;
            db.Entries.Add(entry);
            if(db.SaveChanges() > 0)
            {
                MessageBox.Show("Check-in successfully !!!");
            } else
            {
                MessageBox.Show("Failed to check-in !!!");
            }
        }

        private void buttonSeeEntries_Click(object sender, EventArgs e)
        {
            var db = new DatabaseContext();
            var id = dataGridViewMemberList.CurrentRow.Cells[0].Value.ToString();
            var data = new Dictionary<string, object>();
            data.Add("id", id);
            var entries = new Entries(data);
            entries.Show();
        }

        private void buttonSendIndivisualEmail_Click(object sender, EventArgs e)
        {
            var id = dataGridViewMemberList.CurrentRow.Cells[0].Value.ToString();
            var data = new Dictionary<string, object>();
            data.Add("id", id);
            var userControlSendEmail = new UserControlSendEmail(data);
            Panel panelMain = (Panel)Parent;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControlSendEmail);
        }
    }
}
