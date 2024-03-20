using System;
using System.Collections.Generic;

namespace User
{
    public class Sellers
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserID { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public int Numberofproductssold {  get; set; }

        public bool Validatedprofil { get; set; }
        public string Description { get; set; }

        bool Login()
        { return true; }
        bool Logout()
        { return false; }

    }
}
