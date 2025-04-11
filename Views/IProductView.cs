using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface IProductView
    {
        string ProductId { get; set; }
        string ProductName { get; set; }
        decimal ProductPrice { get; set; }
        int ProductStock { get; set; }
        int CategoryId { get; set; }
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

        void SetProductBillBindingSource(BindingSource ProductList);
        void Show();
    }
}
