using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AIP.App_Code
{
    public class Admin_Object
    {

        // Declare Admin registration model
        private string login_id;
        private string first_name;
        private string last_name;
        private string age;
        private string gender;
        private string contact_number;
        private string email;
        private string admin_address;
        private string country;
        private string city_name;
        private string pincode;
        private string password;

        public string login_id_value
        {
            get
            {
                return login_id;
            }
            set
            {
                login_id = value;
            }
        }
        public string first_name_value
        {
            get
            {
                return first_name;
            }
            set
            {
                first_name = value;
            }
        }
        public string last_name_value
        {
            get
            {
                return last_name;
            }
            set
            {
                last_name = value;
            }
        }

        public string age_value
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string gender_value
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public string contact_number_value
        {
            get
            {
                return contact_number;
            }
            set
            {
                contact_number = value;
            }
        }

        public string email_value
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string admin_address_value
        {
            get
            {
                return admin_address;
            }
            set
            {
                admin_address = value;
            }
        }

        public string country_value
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        public string city_name_value
        {
            get
            {
                return city_name;
            }
            set
            {
                city_name = value;
            }
        }


        public string pincode_value
        {
            get
            {
                return pincode;
            }
            set
            {
                pincode = value;
            }
        }

        public string password_value
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

    }
}