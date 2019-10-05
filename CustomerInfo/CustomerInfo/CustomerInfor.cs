using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
 using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  CustomerInfo.Model;
using CustomerInfo.BLL;

namespace CustomerInfo
{
    public partial class CustomerInfor : Form
    {
        CustomerManager _customerManager = new CustomerManager();
        Customer _customer = new Customer();
      //  public object labelCode;
      // public object labelName;
      //public object labelContact;
      // public object labelDistrict;

        public CustomerInfor()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _customer.Code = codeTextBox.Text;
                _customer.Name = nameTextBox.Text;
                _customer.Address = addressTextBox.Text;
                _customer.Contact = codeTextBox.Text;
                _customer.District = districtComboBox.Text;
                List<Customer> customers = _customerManager.SearchCustomers(_customer);
                if (customers.Contains(_customer))
                {
                    codeTextBox.Text = "Code Exists";
                }
                else if (_customer.Code.Length == 0)
                {
                    codeTextBox.Text = "Code Can't Be Empty";
                }
                else if (_customer.Code.Length < 4)
                {
                    codeTextBox.Text = "Code Must Be 4 Character";
                }
                else if (_customer.Code.Length > 4)
                {
                    codeTextBox.Text = "Code Must Not Exceed 4 Character";
                }
                else if (_customer.Name.Length == 0)
                {
                    nameTextBox.Text= "Name Can't Be Empty";
                }
                else if (_customer.Contact.Length == 0)
                {
                    contactTextBox.Text = "Contact Is Mandatory";
                }
                else if (_customer.Contact.Length < 11)
                {
                    contactTextBox.Text = "Contact Is 11 Digit";
                }
                else if (_customer.Contact.Length > 0)
                {
                    contactTextBox.Text = "Contact Is Not More Than 11 Digit";
                }
                else if (_customer.District == "--Select--")
                {
                    districtComboBox.Text = "You Must Select A District";
                }
                else
                {
                    bool isSaved = _customerManager.Save(_customer);
                    if (isSaved)
                    {
                        MessageBox.Show("Saved");
                        displayDataGridView.DataSource = _customerManager.ShowCustomers(_customer);
                    }
                }
                 
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }

        private void CustomerInfor_Load(object sender, EventArgs e)
        {
            districtComboBox.DataSource = _customerManager.ComboBoxDistricts();
        }
    }
}
