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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        bool isDataSaved = true; 

        private void Order_Load(object sender, System.EventArgs e)
        {
            comboBox1.Items.Add("Blue");
            comboBox1.Items.Add("Green");
            comboBox1.Items.Add("Red");
            comboBox1.Items.Add("Yellow");
            comboBox1.Items.Add("Gray");
        }

        private void DataChaned(object sender, System.EventArgs e)
        {
            isDataSaved = false; 
        }

        private void btnSelectItem_Click(object sender, System.EventArgs e)
        {
            Form menuForm = new Menu();
            DialogResult selectedButton = menuForm.ShowDialog();
            if (selectedButton == DialogResult.OK)
            {
                lbl3.Text = (string)menuForm.Tag;
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (IsValidData())
            {
                SaveData();
            }
        }

        private void SaveData()
        {
            comboBox1.SelectedIndex = -1;
            lbl3.Text = "";
            isDataSaved = true;
            comboBox1.Focus();
        }

        private bool IsValidData()
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please, select a table.",
                    "Entry Error");
                comboBox1.Focus();
                return false;
            }
            return true;
        }

        private void btnExit_CLick(object sender, System.EventArgs e)
        {
            {
            
                    this.Close();
            }
        }

        private void order_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDataSaved == false)

            {
                string message = "This form has unsaved data. \n\n" +
                                 "Would you like to save it?";

                DialogResult button =
                    MessageBox.Show(message, "Order",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);
                if (button == DialogResult.Yes)
                {
                    if (IsValidData())
                        this.SaveData();
                    else
                        e.Cancel = true;
                }
                
                if (button == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
