using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strike_FX_Pro_Shops
{
    class Employee : IEmployee
    {
        private int m_ID;
        private string m_sFirstName;
        private string m_sLastName;

        public int ID
        {
            get { return m_ID; }
            set { m_ID = value; }
        }

        public string FirstName
        {
            get { return m_sFirstName; }
            set { m_sFirstName = value; }
        }

        public string LastName
        {
            get { return m_sLastName; }
            set { m_sLastName = value; }
        }
    }
}
