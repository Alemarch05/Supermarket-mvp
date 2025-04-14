using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
   internal class CategoryPresenter
    {
        private ICategoryView view;
        private ICategoryRepository repository;
        private BindingSource categoryBindingSource;
        private IEnumerable<CategoryModel> categoryList;

        public CategoryPresenter(ICategoryView view, ICategoryRepository repository)
        {
            this.categoryBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategory;
            this.view.AddNewEvent += AddNewCategory;
            this.view.EditEvent += LoadSelectCategoryToEdit;
            this.view.DeleteEvent += DeleteSelectedCategory;
            this.view.SaveEvent += SaveCategory;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategoryBillBindingSource(categoryBindingSource);


            LoadAllCategoryList();

            this.view.Show();
        }

        private void LoadAllCategoryList()
        {
            categoryList = repository.GetAll();
            categoryBindingSource.DataSource = categoryList;
        }

        private void SaveCategory(object? sender, EventArgs e)
        {
            var Category = new CategoryModel();
            Category.Id = Convert.ToInt32(view.CategoryId);
            Category.Name = view.CategoryName;
            Category.description = view.CategoryDescription;

            try
            {
                new Common.ModelDataValidation().Validate(Category);
                if (view.IsEdit)
                {
                    repository.Edit(Category);
                    view.Message = "Category edited successfully";
                }
                else
                {
                    repository.Add(Category);
                    view.Message = "Category added successfully";
                }
                view.IsSucessful = true;
                LoadAllCategoryList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSucessful = false;
                view.Message = ex.Message;
            }
        }
        private void CleanViewFields()
        {
            view.CategoryId = "0";
            view.CategoryName = "";
            view.CategoryDescription = "";
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void CancelCategory(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectCategoryToEdit(object? sender, EventArgs e)
        {
            MessageBox.Show("Hizo clic en el boton Editar");
            var category = (CategoryModel)categoryBindingSource.Current;

            view.CategoryId = category.Id.ToString();
            view.CategoryName = category.Name;
            view.CategoryDescription = category.description;

            view.IsEdit = true;
        }

        private void DeleteSelectedCategory(object? sender, EventArgs e)
        {
            try
            {
                var Category = (CategoryModel)categoryBindingSource.Current;
                repository.Delete(Category.Id);
                view.IsSucessful = true;
                view.Message = "Category Delete Succesfully";
                LoadAllCategoryList();
            }
            catch (Exception ex)
            {
                view.IsSucessful = false;
                view.Message = "Ha ocuurido una anomalia";
            }
        }

        private void AddNewCategory(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCategory(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                categoryList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categoryList = repository.GetAll();
            }
            categoryBindingSource.DataSource = categoryList;

        }


    }
}
