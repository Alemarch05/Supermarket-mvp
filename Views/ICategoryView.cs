using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    interface ICategoryView
    {
        string CategoryId { get; set; }
        string CategoryName { get; set; }
        string CategoryDescription { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSucessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetCategoryBillBindingSource(BindingSource categoryList);
        void Show();
    }
}
