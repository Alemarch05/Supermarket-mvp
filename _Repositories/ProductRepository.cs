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
        public void Add(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Product VALUES(@name,@price,@stock,@categoty_id)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.Name;
                command.Parameters.Add("@price", SqlDbType.NVarChar).Value = productModel.Price;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = productModel.Stock;
                command.Parameters.Add("@category_id", SqlDbType.Int).Value = productModel.Category_Id;


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
                command.CommandText = "DELETE FROM PayMode WHERE Product_Id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Product
                                        SET Product_Name=@name,Product_Price=@price,Product_Stock=@stock,Category_Id=@category_id
                                        WHERE Product_Id=@id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.Name;
                command.Parameters.Add("@price", SqlDbType.NVarChar).Value = productModel.Price;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = productModel.Stock;
                command.Parameters.Add("@category_id", SqlDbType.Int).Value = productModel.Category_Id;
                command.Parameters.Add("@id", SqlDbType.Int).Value = productModel.Id;


                command.ExecuteNonQuery();
            }
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
                        productModel.Price =reader["Product_Price"].ToString(); ;
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
                        productModel.Price = reader["Product_Price"].ToString();
                        productModel.Stock = (int)reader["Product_Stock"];

                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        }

    }
}
