using BBM.DAL;
using BBM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBM.Ui
{
    public partial class AdminForm : MetroFramework.Forms.MetroForm
    {
        public static UserInfo loggedinUser = new UserInfo();
        BloodDataDal bloodStat = new BloodDataDal();
        public AdminForm(UserInfo loggedInUserInfo)
        {
            InitializeComponent();
            userIdLabelAdminForm.Text = loggedInUserInfo.UId.ToString();
            userNameLabelAdminForm.Text = loggedInUserInfo.Name;
            loggedinUser = loggedInUserInfo;
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            bloodStatGridAdminForm.DataSource = bloodStat.Blood();
        }

        private void mainPanelAdminForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inventoryButtonAdminForm_Click(object sender, EventArgs e)
        {
            InventoryForm obj = new InventoryForm();
            obj.Show(this);
        }

        private void historyButtonAdminForm_Click(object sender, EventArgs e)
        {
            ReportForm obj = new ReportForm();
            obj.Show(this);
        }

        private void editDetailsButtonAdminForm_Click(object sender, EventArgs e)
        {
            EditDetailsForm obj = new EditDetailsForm(loggedinUser);
            obj.Show(this);
            this.Hide();
        }

        private void bloodStatGridAdminForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void logOutButtonAdminForm_Click(object sender, EventArgs e)
        {
            var obj = new MainForm();
                obj.Show();
            this.Close();
        }
    }
}
