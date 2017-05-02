using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            listBoxItem.Items.Add("Pork Chop");
            listBoxItem.Items.Add("Chicken");
            listBoxItem.Items.Add("Fish");
            listBoxItem.SelectedIndex = 0;

            comboBox1.Items.Add("Baked Potato");
            comboBox1.Items.Add("Side Salad");
            comboBox1.Items.Add("Assorted Vegitables");
            comboBox1.Items.Add("French Fries");

            comboBox2.Items.Add("Chocolate Cake");
            comboBox2.Items.Add("Pumpkin Pie");
            comboBox2.Items.Add("Ice Cream");
            comboBox2.Items.Add("Cookie");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                this.SaveData();
            }
        }

        private bool isValidData()
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a side dish", "Entry Error");
                listBoxItem.Focus();
                return false;
            }
            return true;
        }

        private void SaveData()
        {
            string msg = null;
            if (radiobtnEatIn.Checked || radiobtnToGo.Checked == true)
            {
                msg += "\n";
                msg += "" + "Your order of:" + "\n";
                msg += "\n";
                msg += "" + listBoxItem.Text + "\n";
                msg += "" + comboBox1.Text + "\n";
                msg += "" + comboBox2.Text + "\n";
                msg += "\n";
                msg += "" + "has been selected.";
            }
            else
            {
                MessageBox.Show("Please select whether you order is for here or to go." + "\n" + "Thank you!");
            }

            bool isDefultPreference = checkBox1.Checked;
            this.Tag = msg;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
