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
    internal class CategoryRepository : BaseRepository, ICategoryRepository
    {
            public CategoryRepository(string connectionString)
        {
          this.connectionString = connectionString;
        }
        public void Add(CategoryModel categoryModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(CategoryModel categoryModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryModel> GetAll()
        {
            var CategoryList = new List<CategoryModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Category ORDER BY Category_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var CategoryModel = new CategoryModel();
                        CategoryModel.Id = (int)reader["Category_Id"];
                        CategoryModel.Name = reader["Category_Name"].ToString();
                        CategoryModel.description = reader["Category_description"].ToString();
                        CategoryList.Add(CategoryModel);
                    }

                }
            }
            return CategoryList;
        }

        public IEnumerable<CategoryModel> GetByValue(string value)
        {
            var categoryList = new List<CategoryModel>();
            int categoryId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string categoryName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())

            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Category
                                       WHERE Category_Id=@id or Category_Name LIKE @name + '%' 
                                        ORDER BY Category_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoryId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoryName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoryModel = new CategoryModel();
                        categoryModel.Id = (int)reader["Category_Id"];
                        categoryModel.Name = reader["Category_Name"].ToString();
                        categoryModel.description = reader["Category_description"].ToString();
                        categoryList.Add(categoryModel);
                    }
                }
            }
            return categoryList;
        }
    }
}
