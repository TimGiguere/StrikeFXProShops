using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strike_FX_Pro_Shops
{
    interface IEmployee
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}
