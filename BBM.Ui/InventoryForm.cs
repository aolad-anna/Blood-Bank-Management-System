using BBM.DAL;
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
    public partial class InventoryForm : MetroFramework.Forms.MetroForm
    {
        BloodInventoryData inventoryData = new BloodInventoryData();
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            bloodGroupComboBox.SelectedIndex = 0;
            InventoryForm_Load();
        }
        private void searchBoxInventoryForm_Click(object sender, EventArgs e)
        {

        }
        private void InventoryForm_Load()
        {
            FormLoad();
        }

        private void bloodGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bloodGroup = bloodGroupComboBox.SelectedItem.ToString();
            inventoryGridInventoryForm.DataSource = inventoryData.InventoryDataByBloodGroup(bloodGroup);
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            bloodGroupComboBox.SelectedIndex = 0;
            FormLoad();
        }
        private void FormLoad()
        {
            inventoryGridInventoryForm.DataSource = inventoryData.InventoryData();
        }

        private void inventoryGridInventoryForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
