using BBM.BLL;
using BBM.DAL;
using BBM.Entity;
using System;
using MetroFramework;
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
    public partial class EditDetailsForm : MetroFramework.Forms.MetroForm
    {
        public static UserInfo loggedinUser = new UserInfo();
        public static AddressInfo loggedInUserAddress = new AddressInfo();

        EditDetailsData userToEdit = new EditDetailsData();



        public EditDetailsForm(UserInfo loggedInUserInfo)
        {
            InitializeComponent();
            loggedinUser = loggedInUserInfo;
        }



        private void EditDetails_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void backButtonEditDetailsForm_Click(object sender, EventArgs e)
        {
            if (loggedinUser.UserRole == 1)
                new AdminForm(loggedinUser).Show();
            else
                new UserHomePageForm(loggedinUser).Show();

            this.Hide();
        }

        private void clearEditDetailsForm_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            nameEditDetailsForm.Text = "";
            phoneEditDetailsForm.Text = "";
            emailEditDetailsForm.Text = "";
            passwordEditDetailsForm.Text = "";
            ageEditDetailsForm.Text = "";
            bloodGroupEditForm.Text = "";
            houseNumberEditDetailsForm.Text = "";
            roadNumberEditDetailsForm.Text = "";
            subDistrictEditDetailsForm.Text = "";
            districtEditDetailsForm.Text = "";
            countryEditDetailsForm.Text = "";
            zipCodeEditDetailsForm.Text ="" ;
        }

        private void saveButtonEditDetailsForm_Click(object sender, EventArgs e)
        {
            if (phoneEditDetailsForm.Text == string.Empty || 
                emailEditDetailsForm.Text == string.Empty || 
                passwordEditDetailsForm.Text==string.Empty || 
                ageEditDetailsForm.Text==string.Empty || 
                subDistrictEditDetailsForm.Text==string.Empty ||
                districtEditDetailsForm.Text==string.Empty||
                countryEditDetailsForm.Text==string.Empty||
                houseNumberEditDetailsForm.Text==string.Empty||
                roadNumberEditDetailsForm.Text==string.Empty||
                zipCodeEditDetailsForm.Text==string.Empty
                )
            {
                MetroMessageBox.Show(this, "Please fill up all the fields first","Sorry",MessageBoxButtons.RetryCancel,MessageBoxIcon.Asterisk);
                loadForm();
            }
            else
            {
                int status = 0;
                loggedinUser.Age = ageEditDetailsForm.Text;
                //loggedinUser.Name = userNameLabelEditDetailsForm.Text ;
                // loggedinUser.UId =Convert.ToInt32( userIdLabelEditDetailsForm.Text);
                //loggedinUser.UserRole= what it received earlier;
                loggedinUser.Email = emailEditDetailsForm.Text;
                loggedinUser.Phone = phoneEditDetailsForm.Text;
                loggedinUser.Password = passwordEditDetailsForm.Text;
                //loggedinUser.BloodGroup = bloodGroupLabelEditDetailsForm.Text ;


                loggedInUserAddress.Houseno = houseNumberEditDetailsForm.Text;
                loggedInUserAddress.Roadno = roadNumberEditDetailsForm.Text;
                loggedInUserAddress.SubDistrict = subDistrictEditDetailsForm.Text;
                loggedInUserAddress.District = districtEditDetailsForm.Text;
                loggedInUserAddress.Country = countryEditDetailsForm.Text;
                loggedInUserAddress.Zip = Convert.ToInt32(zipCodeEditDetailsForm.Text);

                EditDetailsRepo objToEdit = new EditDetailsRepo();
                status = objToEdit.editUser(loggedinUser, loggedInUserAddress);
                if (status > 0)
                {
                    MetroMessageBox.Show(this, "Operation successful", "Sucess", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    loadForm();
                }

                else
                {
                    MetroMessageBox.Show(this, "Some Error Occurred Sorry For inconvenience", "Sorry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }    
        }
        private void loadForm()
            {
            loggedinUser = userToEdit.InitializeUserInfo(loggedinUser);
            loggedInUserAddress.AId = loggedinUser.AddressId;

            loggedInUserAddress = userToEdit.InitializeUserAddress(loggedInUserAddress);

            nameEditDetailsForm.Text = loggedinUser.Name;
            userIdLabelEditDetailsForm.Text = loggedinUser.UId.ToString();
            emailEditDetailsForm.Text = loggedinUser.Email;
            phoneEditDetailsForm.Text = loggedinUser.Phone;
            passwordEditDetailsForm.Text = loggedinUser.Password;
            bloodGroupEditForm.Text = loggedinUser.BloodGroup;
            ageEditDetailsForm.Text = loggedinUser.Age;

            houseNumberEditDetailsForm.Text = loggedInUserAddress.Houseno;
            roadNumberEditDetailsForm.Text = loggedInUserAddress.Roadno;
            subDistrictEditDetailsForm.Text = loggedInUserAddress.SubDistrict;
            districtEditDetailsForm.Text = loggedInUserAddress.District;
            countryEditDetailsForm.Text = loggedInUserAddress.Country;
            zipCodeEditDetailsForm.Text = loggedInUserAddress.Zip.ToString();
        }

        private void realoadButton_Click(object sender, EventArgs e)
        {
            loadForm();
        }

        private void userRegistrationGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void phoneEditDetailsForm_Click(object sender, EventArgs e)
        {

        }

        private void bloodGroupEditForm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
