using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using System.Data;

namespace Supermarket_mvp._Repositories
{
    internal class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(string coonectionString) 
        {
            this.connectionString = coonectionString;
        }
        public void Add(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductModel> GetAll()
        {
            var productList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Product ORDER BY Product_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.Id = (int)reader["Product_Id"];
                        productModel.Name = reader["Product_Name"].ToString();
                        productModel.Price = (decimal)reader["Product_Price"];
                        productModel.Stock = (int)reader["Product_Stock"];
                        productModel.Category_Id = (int)reader["Category_Id"];

                        productList.Add(productModel);
                    }

                }
            }
            return productList;
        }

        public IEnumerable<ProductModel> GetByValue(string value)
        {
            var productList = new List<ProductModel>();
            int productId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productValue = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())

            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Products
                                        WHERE Product_Id = @id 
                                        OR Product_Name LIKE @value+ '%'
                                        OR Product_Price LIKE @value+ '%'
                                        ORDER By Product_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productId;
                command.Parameters.Add("@value", SqlDbType.NVarChar).Value = productValue;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();

                        productModel.Id = (int)reader["Product_Id"];
                        productModel.Name = reader["Product_Name"].ToString();
                        productModel.Price = (decimal)reader["Product_Price"];
                        productModel.Stock = (int)reader["Product_Stock"];

                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        }
    }
}
