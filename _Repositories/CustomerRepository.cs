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
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Customer VALUES(@document,@firstName,@lastName,@address,@birthday,@phone,@email)";
                command.Parameters.Add("@document", SqlDbType.NVarChar).Value = customerModel.Document;
                command.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = customerModel.FirstName;
                command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = customerModel.LastName;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = customerModel.Address;
                command.Parameters.Add("@birthday", SqlDbType.NVarChar).Value = customerModel.Birthday;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = customerModel.Phone;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = customerModel.Email;

                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Customer WHERE Customer_Id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CustomerModel customerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                
                command.CommandText = @"UPDATE Customer SET Customer_Document = @document,Customer_First_Name = @firstName,Customer_Last_Name = @lastName,Customer_Address = @address,Customer_BirthDay = @birthday,Customer_Phone_Number = @phone, Customer_Email = @email WHERE Customer_Id = @id";
                command.Parameters.Add("@document", SqlDbType.NVarChar).Value = customerModel.Document;
                command.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = customerModel.FirstName;
                command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = customerModel.LastName;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = customerModel.Address;
                command.Parameters.Add("@birthday", SqlDbType.NVarChar).Value = customerModel.Birthday;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = customerModel.Phone;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = customerModel.Email;
                command.Parameters.Add("@id", SqlDbType.Int).Value = customerModel.Id;


                command.ExecuteNonQuery();
            }
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
