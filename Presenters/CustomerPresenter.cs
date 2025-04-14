using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;

namespace Supermarket_mvp.Presenters
{
    internal class CustomerPresenter
    {
        private ICustomerView view;
        private ICustomerRepository repository;
        private BindingSource customerBindingSource;
        private IEnumerable<CustomerModel> customerList;

        public CustomerPresenter(ICustomerView view, ICustomerRepository repository)
        {
            this.customerBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCustomer;
            this.view.AddNewEvent += AddNewCustomer;
            this.view.EditEvent += LoadSelectCustomerToEdit;
            this.view.DeleteEvent += DeleteSelectedCustomer;
            this.view.SaveEvent += SaveCustomer;
            this.view.CancelEvent += CancelCustomer;

            this.view.SetCustomerBindingSource(customerBindingSource);



            LoadAllCustomerList();

            this.view.Show();
        }

        private void LoadAllCustomerList()
        {
            customerList = repository.GetAll();
            customerBindingSource.DataSource = customerList;
        }

        private void SaveCustomer(object? sender, EventArgs e)
        {
            var customer = new CustomerModel();
            customer.Id = Convert.ToInt32(view.CustomerId);
            customer.Document = view.CustomerDocument;
            customer.FirstName = view.CustomerFirstName;
            customer.LastName = view.CustomerLastName;
            customer.Address = view.CustomerAddress;
            customer.Birthday = view.CustomerBirthday;
            customer.Phone = view.CustomerPhone;
            customer.Email = view.CustomerEmail;
          



            try
            {
                new Common.ModelDataValidation().Validate(customer);
                if (view.IsEdit)
                {
                    repository.Edit(customer);
                    view.Message = "Customer edited successfully";
                }
                else
                {
                    repository.Add(customer);
                    view.Message = "Customer added successfully";
                }
                view.IsSuccessful = true;
                LoadAllCustomerList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }
        private void CleanViewFields()
        {
            view.CustomerId = "0";
            view.CustomerDocument = "";
            view.CustomerFirstName = "";
            view.CustomerLastName = "";
            view.CustomerAddress = "";
            view.CustomerBirthday = "";
            view.CustomerPhone = "";
            view.CustomerEmail = "";
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void CancelCustomer(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectCustomerToEdit(object? sender, EventArgs e)
        {
            MessageBox.Show("Hizo clic en el boton Editar");
            var customer = (CustomerModel)customerBindingSource.Current;

            view.CustomerId = customer.Id.ToString();
            view.CustomerDocument = customer.Document;
            view.CustomerFirstName = customer.FirstName;
            view.CustomerLastName = customer.LastName;
            view.CustomerAddress = customer.Address;
            view.CustomerBirthday = customer.Birthday;
            view.CustomerPhone = customer.Phone;
            view.CustomerEmail = customer.Email;
            
            

            view.IsEdit = true;
        }

        private void DeleteSelectedCustomer(object? sender, EventArgs e)
        {
            try
            {
                var customer = (CustomerModel)customerBindingSource.Current;
                repository.Delete(customer.Id);
                view.IsSuccessful = true;
                view.Message = "Customer Delete Succesfully";
                LoadAllCustomerList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Ha ocuurido una anomalia";
            }
        }

        private void AddNewCustomer(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCustomer(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                customerList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                customerList = repository.GetAll();
            }
            customerBindingSource.DataSource = customerList;

        }
    }
}
