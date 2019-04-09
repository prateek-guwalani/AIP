using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AIP.App_Code;

namespace AIP
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Business_Layer BL = new Business_Layer();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedIndex == 0)
            {
                Admin_Object a = new Admin_Object();
                a.login_id_value = TextBox_Id.Text;
                a.password_value = TextBox_Password.Text;
                int str_temp = int.Parse(BL.admin_login_process(a));

                //Redirection
                Response.Redirect("Default.aspx");


            }
            else if (RadioButtonList1.SelectedValue == "User")
            {
                User_Object u = new User_Object();
                u.login_id_value = TextBox_Id.Text;
                u.password_value = TextBox_Password.Text;
                int str_temp = int.Parse(BL.user_login_process(u));

                //Redirection
                Response.Redirect("User.aspx");

            }

        }
    }
}