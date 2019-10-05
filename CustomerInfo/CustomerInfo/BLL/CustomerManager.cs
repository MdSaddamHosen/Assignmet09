using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerInfo.DAL;
using CustomerInfo.Model;

namespace CustomerInfo.BLL
{
     class CustomerManager
    {

        CustomerRepository _customerRepository = new CustomerRepository();

        public bool Save(Customer _customer)
        {
            return _customerRepository.Save(_customer);
        }

        public List<District> ComboBoxDistricts()
        {
            return _customerRepository.ComboBoxDistricts();
        }

        public List<Customer> ShowCustomers(Customer _customer)
        {
            return _customerRepository.ShowCustomers(_customer);
        }

        public List<Customer> SearchCustomers(Customer _customer)
        {
            return _customerRepository.SearchCustomers(_customer);
        }
    }
}
