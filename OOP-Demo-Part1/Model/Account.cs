using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Demo_Part1.Model
{
    class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public Account()
        {
            MessageBox.Show("Account a object is CREATED");
        }

        ~Account()
        {
            MessageBox.Show("Account a object is DESTROYED");
        }

    }
}
