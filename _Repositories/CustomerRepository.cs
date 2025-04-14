using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    internal class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public CustomerRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(CustomerModel customerModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(CustomerModel customerModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerModel> GetAll()
        {
            var customerList = new List<CustomerModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Customer ORDER BY Customer_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var CustomerModel = new CustomerModel();
                        CustomerModel.Id = (int)reader["Customer_Id"];
                        CustomerModel.Document = reader["Customer_Document"].ToString();
                        CustomerModel.FirstName = reader["Customer_First_Name"].ToString();
                        CustomerModel.LastName = reader["Customer_Last_Name"].ToString();
                        CustomerModel.Address = reader["Customer_Address"].ToString();
                        CustomerModel.Birthday = reader["Customer_Birthday"].ToString();
                        CustomerModel.Phone = reader["Customer_Phone_Number"].ToString();
                        CustomerModel.Email = reader["Customer_Email"].ToString();

                        customerList.Add(CustomerModel);
                    }

                }
            }
            return customerList;
        }

        public IEnumerable<CustomerModel> GetByValue(string value)
        {
            var customerList = new List<CustomerModel>();
            int customerId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string customerDocument = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())

            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Customer
                                       WHERE Customer_Id=@id or Customer_Document LIKE @document + '%' 
                                        ORDER BY Customer_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = customerId;
                command.Parameters.Add("@document", SqlDbType.NVarChar).Value = customerDocument;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                            var customerModel = new CustomerModel();

                        customerModel.Id = (int)reader["Customer_Id"];
                        customerModel.Document = reader["Customer_Document"].ToString();
                        customerModel.FirstName = reader["Customer_First_Name"].ToString();
                        customerModel.LastName = reader["Customer_Last_Name"].ToString();
                        customerModel.Address = reader["Customer_Address"].ToString();
                        customerModel.Birthday = reader["Customer_Birthday"].ToString();
                        customerModel.Phone = reader["Customer_Phone_Number"].ToString();
                            customerModel.Email = reader["Customer_Email"].ToString();
                        
                        customerList.Add(customerModel);
                    }
                }
            }

            return customerList;
        }
    }
}
