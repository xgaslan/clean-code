using System;
using System.Collections.Generic;
using System.Linq;

namespace SingleResponsibility
{
    public class CustomerServiceWithSingle
    {

        public List<Customer> GetCustomers()
        {
            var customerList = CreateDummyCustomerData.GetGeneratedCustomerList();
            return customerList;
        }

        public bool CheckCustomerExistsById(int id)
        {
            var customers = GetCustomers();
            var isCustomerExist = customers.Any(c => c.Id == id);
            if (isCustomerExist)
            {
                return true;
            }
            return false;
        }

        public Customer CreateCustomer(Customer customer)
        {
            var customers = GetCustomers();
            var isCustomerExist = customers.Any(c => c.Name == customer.Name);
            if (isCustomerExist)
            {
                throw new SystemException($"There is a record with this customer name {customer.Name}.");
            }
            customers.Add(customer);
            return customer;
        }
    }
}