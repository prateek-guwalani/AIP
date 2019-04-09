using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AIP.App_Code;

namespace AIP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Business_Layer BL = new Business_Layer();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

      

        protected void Button1_Click(object sender, EventArgs e)
        {
            Admin_Object AO = new Admin_Object();
            AO.first_name_value = TextBox_First_Name.Text;
            AO.last_name_value = TextBox_Last_Name.Text;
            AO.age_value = TextBox_Age.Text;
            AO.gender_value = DropDownList_Gender.SelectedItem.Text;
            AO.contact_number_value = TextBox_Contact_Number.Text;
            AO.email_value = TextBox_Email.Text;
            AO.admin_address_value = TextBox_Address.Text;
            AO.country_value = DropDownList_Country.SelectedItem.Text;
            AO.city_name_value = DropDownList_City.SelectedItem.Text;
            AO.pincode_value = TextBox_Zipcode.Text;
            AO.password_value = TextBox_Password.Text;
            AO.login_id_value = BL.get_admin_id();
            string message = BL.admin_registration_process(AO);
            Response.Redirect("AIPlogin.aspx");

        }
    }
}