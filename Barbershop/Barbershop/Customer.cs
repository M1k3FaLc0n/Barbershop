﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop
{
    class Customer
    {
        private static int cur_max_id = 0;

        private int id;
        
        public string name;
        public string last_name;

        Customer(string name, string last_name) {
            id = cur_max_id;
            cur_max_id++;
            this.name = name;
            this.last_name = last_name;
        }

        public void print()
        {
            Console.WriteLine("____________");
            Console.WriteLine("Клиент № " + id + ":");
            Console.WriteLine(name + " " + last_name);
            Console.WriteLine("____________");
        }
    }
}