using Lab.Model;
using Lab.Repository;
using Lab.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Presenter
{
   public class CustomerPresenter
    {

        ICustomerRepository repository;
        Icustomerview view;
       
        public CustomerPresenter(Icustomerview view, ICustomerRepository repository )
        {
            this.view = view;
            this.view.CustomerPresenter = this;
            this.repository = repository;
            
            UpdateCustomerListView();
        }
        public void UpdateCustomerView(int id) {
            Customer customer = repository.GetCustomerById(id);
            view.FullName = customer.FullName;
            view.Address = customer.Address;
            view.Email = customer.Email;
            view.Nationality = customer.Nationality;
        }
        public void SaveCustomer() {
            Customer customer = new Customer(view.FullName,view.Address,view.Email,view.Nationality);
            repository.SaveCustomer(view.SelectedCustomer,customer);

            UpdateCustomerListView();

        }
        public void AddNewCustomer()
        {
            Customer customer = new Customer(view.FullName, view.Address, view.Email, view.Nationality);
            repository.AddNewCustomer(customer);
            UpdateCustomerListView();
        }
        public void UpdateCustomerListView() {
            var customerNames = repository.GetAllCustomers().Select(x => x.FullName);
            int selectedCustomer = view.SelectedCustomer >= 0 ? view.SelectedCustomer : 0;
            view.CustomerList = customerNames.ToList();
            view.SelectedCustomer = selectedCustomer;

        }
    }
}
