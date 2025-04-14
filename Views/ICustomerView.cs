using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    interface ICustomerView
    {
        string CustomerId { get; set; }
        string CustomerDocument { get; set; }
        string CustomerFirstName { get; set; }
        string CustomerLastName { get; set; }
        string CustomerAddress { get; set; }
        string CustomerBirthday { get; set; }
        string CustomerPhone { get; set; }
        string CustomerEmail { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetCustomerBindingSource(BindingSource customerList);

        void Show();
    }

    
}
