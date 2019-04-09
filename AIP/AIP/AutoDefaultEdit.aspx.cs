using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using AIP.App_Code;

namespace AIP
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        readonly PagedDataSource _pgsource = new PagedDataSource();
        private int _pageSize = 5;
        public static int serial_number = 0;
         Business_Layer BL = new Business_Layer();
            DataSet DL = new DataSet();
            DataTable DT = new DataTable();
           // int[] temp_index = new int[5];
           
        private int CurrentPage
        {
            get
            {
                if (ViewState["CurrentPage"] == null)
                {
                    return 0;
                }
                return ((int)ViewState["CurrentPage"]);
            }
            set
            {
                ViewState["CurrentPage"] = value;
            }
        }

         private DataSet Dataset_1
        {
            get
            {
                if (ViewState["ds"] == null)
                {
                    DataSet d = new DataSet();
                    d = BL.get_auto_default();
                    ViewState["ds"] = d;
                    return d;
                }
                return ((DataSet)ViewState["ds"]);
            }
            set
            {
                ViewState["ds"] = value;
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            serial_number = 0;
            if (Page.IsPostBack) return;
            bindrepeater();
            ddl();


        }

        //public void bindrepeater()
        //{
        //    Business_Layer BL = new Business_Layer();
        //    Repeater_Auto_Default.DataSource = BL.get_auto_default();
        //    Repeater_Auto_Default.DataBind();
        //}


        public void bindrepeater()
        {
            //Business_Layer BL = new Business_Layer();

             DL = Dataset_1;
             DT = DL.Tables[0];
            _pgsource.DataSource = DT.DefaultView;
            _pgsource.AllowPaging = true;

            // Number of items to be displayed in the Repeater
            _pgsource.PageSize = _pageSize;
            _pgsource.CurrentPageIndex = CurrentPage;

            // Keep the Total pages in View State
            ViewState["TotalPages"] = _pgsource.PageCount;


            // Example: "Page 1 of 10"
            lblpage.Text = "Page " + (CurrentPage + 1) + " of " + _pgsource.PageCount;


            // Enable First, Last, Previous, Next buttons
            lbPrevious.Enabled = !_pgsource.IsFirstPage;
            lbNext.Enabled = !_pgsource.IsLastPage;
            lbFirst.Enabled = !_pgsource.IsFirstPage;
            lbLast.Enabled = !_pgsource.IsLastPage;

            // Bind data into repeater
            Repeater_Auto_Default.DataSource = _pgsource;
            Repeater_Auto_Default.DataBind();
        }


        protected void lbFirst_Click(object sender, EventArgs e)
        {
            serial_number = 0;
            CurrentPage = 0;
            serial_number = ((CurrentPage) * _pageSize) + serial_number;

            bindrepeater();
            ddl();
        }
        protected void lbLast_Click(object sender, EventArgs e)
        {
            serial_number = 0;
            CurrentPage = (Convert.ToInt32(ViewState["TotalPages"]) - 1);

            serial_number = ((CurrentPage) * _pageSize) + serial_number;
            bindrepeater();
            ddl();
        }
        protected void lbPrevious_Click(object sender, EventArgs e)
        {
            serial_number = serial_number - 5;
            CurrentPage -= 1;
            serial_number = 0;
            serial_number = ((CurrentPage) * _pageSize) + serial_number;
            bindrepeater();
            ddl();
        }
        protected void lbNext_Click(object sender, EventArgs e)
        {
            CurrentPage += 1;
            serial_number = 0;
            serial_number = ((CurrentPage) * _pageSize) + serial_number;
            bindrepeater();
            ddl();
        }

        protected void rptPaging_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (!e.CommandName.Equals("newPage")) return;
            CurrentPage = Convert.ToInt32(e.CommandArgument.ToString());
            bindrepeater();
            ddl();
        }

        protected void rptPaging_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            var lnkPage = (LinkButton)e.Item.FindControl("lbPaging");
            if (lnkPage.CommandArgument != CurrentPage.ToString()) return;
            lnkPage.Enabled = false;

        }

        //For overall serial numbering

        protected string GetRowNo()
        {
            serial_number += 1;

            return serial_number.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = BL.update_database(Dataset_1);
            Response.Write(Dataset_1.Tables[0].Rows.Count);
        }

        protected void ddlOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (RepeaterItem item in Repeater_Auto_Default.Items)
            {
                DropDownList ddl = (DropDownList)item.FindControl("ddlOptions");
                //if (Dataset_1.Tables[0].Rows.Count > 0)
                int ind = item.ItemIndex + (CurrentPage * 5);
                if (ddl.SelectedValue == "Error")
                {
                    Dataset_1.Tables[0].Rows[ind][0] = "Error";
                    Dataset_1 = Dataset_1;
                }
                else if (ddl.SelectedValue == "Auto Weiver")
                {
                    Dataset_1.Tables[0].Rows[ind][0] = "Auto Weiver";
                    Dataset_1 = Dataset_1;
                }
                else if (ddl.SelectedValue == "Auto")
                {
                    Dataset_1.Tables[0].Rows[ind][0] = "Auto";
                    Dataset_1 = Dataset_1;
                }

            }
           
                
        }

        //protected void ddlOptions_SelectI(object sender, EventArgs e)
        //{
        //    foreach (RepeaterItem item in Repeater_Auto_Default.Items)
        //    {
        //        DropDownList ddl = (DropDownList)item.FindControl("ddlOptions");
        //        int ind = item.ItemIndex + (CurrentPage * 5);
        //        string s = (string)Dataset_1.Tables[0].Rows[ind][0];
        //        if (s == "Error")
        //        {
        //            ddl.Items.FindByValue("Error").Selected = true;
        //        }
        //        else if (s == "Auto Weiver")
        //        {
        //            ddl.Items.FindByValue("Auto Weiver").Selected = true;
        //        }
        //        else if (s == "Auto")
        //        {
        //            ddl.Items.FindByValue("Auto").Selected = true;
        //        }

        //    }



        //}

        protected void ddl()
        {
            foreach (RepeaterItem item in Repeater_Auto_Default.Items)
            {
                DropDownList ddl = (DropDownList)item.FindControl("ddlOptions");
                int ind = item.ItemIndex + (CurrentPage * 5);
                string s = (string)Dataset_1.Tables[0].Rows[ind][0];
                if (s == "Error")
                {
                    ddl.Items.FindByValue("Error").Selected = true;
                }
                else if (s == "Auto Weiver")
                {
                    ddl.Items.FindByValue("Auto Weiver").Selected = true;
                }
                else if (s == "Auto")
                {
                    ddl.Items.FindByValue("Auto").Selected = true;
                }

            }
        }
        

    }
}