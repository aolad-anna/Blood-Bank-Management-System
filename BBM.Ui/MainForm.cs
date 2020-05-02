using BBM.DAL;
using BBM.Entity;
using MetroFramework;
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
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public static UserInfo loggedInUserInfo = new UserInfo(); 
        UserData toAccessLogin = new UserData();
        public MainForm() { InitializeComponent(); }
        private void MainForm_Load(object sender, EventArgs e) { }

        private void registerButtonMainForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            var obj = new userRegistrationForm();
            obj.Show(this);
        }

        private void loginButtonMainForm_Click(object sender, EventArgs e)
        {
            if (userNameTextBoxMainForm.Text != string.Empty && passwordTextBoxMainForm.Text != string.Empty)
            {
                loggedInUserInfo = toAccessLogin.UserLogin(userNameTextBoxMainForm.Text, passwordTextBoxMainForm.Text, loggedInUserInfo);

                if (loggedInUserInfo.UserRole == 1)
                {
                    this.Hide();
                    AdminForm newAdminForm = new AdminForm(loggedInUserInfo);
                    newAdminForm.Show(this);
                }

                else if (loggedInUserInfo.UserRole == 2)
                {
                    this.Hide();
                    UserHomePageForm newUserHomepage = new UserHomePageForm(loggedInUserInfo);
                    newUserHomepage.Show(this);
                }
                else
                    MetroMessageBox.Show(this, "Your User Name or Password was incorrect", "Try Again", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
                MetroMessageBox.Show(this, "Please Fill Up All The Required Fields To Login", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clearButtonMainForm_Click(object sender, EventArgs e)
        {
            userNameTextBoxMainForm.Text = "";
            passwordTextBoxMainForm.Text = "";
        }

        private void rightGridMainForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lowerGridMainForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
