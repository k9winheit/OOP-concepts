using OOP_Demo_Part1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Demo_Part1
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }      

        Account a;

        private void btnCreate_Click(object sender, EventArgs e)
        {
             a = new Account();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            a.Id = int.Parse(txtId.Text);
            a.Name = txtName.Text;
            a.Balance =  decimal.Parse(txtBalance.Text);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            txtId.Text = a?.Id.ToString();
            txtName.Text = a?.Name;
            txtBalance.Text = a?.Balance.ToString();
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            a = null;
            GC.Collect();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtBalance.Text = string.Empty;
        }
    }
}
