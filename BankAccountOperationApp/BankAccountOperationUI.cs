using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountOperationApp
{
    public partial class BankAccountOperationUI : Form
    {

        private Account myAccount = null;
        private double amount;
        
        public BankAccountOperationUI()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            myAccount = new Account();
            myAccount.accountNumber = accountNumberTextBox.Text;
            myAccount.customerName = customerNameTextBox.Text;
            MessageBox.Show("Account has been created.\nAccount Number: " + myAccount.accountNumber + "\nCustomer Name: " +
                                myAccount.customerName);
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(transactionTextBox.Text);
            MessageBox.Show(myAccount.deposit(amount));
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(transactionTextBox.Text);
            MessageBox.Show(myAccount.withdraw(amount));
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            if (myAccount !=null)
            {
                MessageBox.Show(myAccount.customerName + "Your Acc No:" + myAccount.accountNumber
                    + "& Balance:"+ myAccount.balance +"Taka");
            }
        }
    }
}
