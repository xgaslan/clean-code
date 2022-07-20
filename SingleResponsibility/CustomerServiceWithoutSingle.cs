using System.Collections.Generic;
using System.Linq;

namespace SingleResponsibility
{
    public class CustomerServiceWithoutSingle
    {
        public bool CheckCustomerExistById(List<Customer> customers, int id)
        {
            var isExist = customers.Where(x => x.Id == id).ToList();
            if (isExist.Count > 0)
            {
                return true;
            }
            return false;
        }

        public List<Customer> GetCustomers(List<Customer> customers)
        {
            var customersList = CreateDummyCustomerData.GetGeneratedCustomerList();
            customersList.AddRange(customers);
            return customersList;
        }
    }
}