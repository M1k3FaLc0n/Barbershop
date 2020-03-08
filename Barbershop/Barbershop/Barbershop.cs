using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop
{
    static class Barbershop
    {
        public static List<Customer> customers = new List<Customer>();
        public static List<Service> services = new List<Service>();

        public static int find_customer(Customer customer)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].is_compare(customer))
                    return i;
            }
            return -1;
        }

        public static int find_service(____)
        {
            for (int i = 0; i < ____; i++)
            {
                if (___)
                    return i;
            }
            return -1;
        }
    }
}
