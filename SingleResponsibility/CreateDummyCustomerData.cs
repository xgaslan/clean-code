using System.Collections.Generic;

namespace SingleResponsibility
{
    public class CreateDummyCustomerData
    {
        public static List<Customer> GetGeneratedCustomerList()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer(){Id = 1, Name = "Samsung"},
                new Customer(){Id = 2, Name = "Huawei"},
                new Customer(){Id = 3, Name = "Nokia"},
                new Customer(){Id = 4, Name = "Xiamoi"}
            };
            return customers;
        }
    }
}