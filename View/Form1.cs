using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab.Presenter;
namespace Lab.View
{
    public partial class Form1 : Form,Icustomerview
    {
        public Form1()
        {
            InitializeComponent();
        }
        public IList<string> CustomerList
        {
            get { return (IList<string>)this.listBox1.DataSource; }
            set { this.listBox1.DataSource = value; }
        }

        public string Address
        {
            get { return addressTextbox.Text; }
            set { addressTextbox.Text = value; }
        }
        public string FullName
        {
            get { return nameTextbox.Text; }
            set { nameTextbox.Text = value; }
        }
        public string Email
        {
            get { return EmailTextbox.Text; }
            set { EmailTextbox.Text = value; }
        }
  
        public CustomerPresenter CustomerPresenter { get; set; }
        public int SelectedCustomer { get => listBox1.SelectedIndex; set => listBox1.SelectedIndex = value; }
       public string Nationality { get { return Nationalitycombo.Text; } set { Nationalitycombo.Text = value; } }

        private void saveButton_Click(object sender, EventArgs e)
        {
            CustomerPresenter.AddNewCustomer();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            CustomerPresenter.SaveCustomer();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerPresenter.UpdateCustomerView(listBox1.SelectedIndex);
        }
    }
}
