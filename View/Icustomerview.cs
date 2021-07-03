using Lab.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.View
{
    public interface Icustomerview
    {

        IList<string> CustomerList { get; set; }
        int SelectedCustomer { get; set; }
        string Address { get; set; }
        string FullName { get; set; }
        string Email { get; set; }
        string Nationality { get; set; }
        CustomerPresenter CustomerPresenter { get; set; }



    }
}
