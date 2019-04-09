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
    public partial class WebForm3 : System.Web.UI.Page
    {
        readonly PagedDataSource _pgsource = new PagedDataSource();
        int _firstIndex, _lastIndex;
        private int _pageSize = 5;
        public static int serial_number = 0;
        Business_Layer BL = new Business_Layer();
        DataSet DL = new DataSet();
        DataTable DT = new DataTable();
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



        protected void Page_Load(object sender, EventArgs e)
        {
            serial_number = 0;
            if (Page.IsPostBack) return;
            bindrepeater();
        }

        //public void bindrepeater()
        //{
        //    Business_Layer BL = new Business_Layer();
        //    Repeater_Auto_Default.DataSource = BL.get_auto_default();
        //    Repeater_Auto_Default.DataBind();
        //}


        public void bindrepeater()
        {
            
            DL = BL.get_auto_default();

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


        private void HandlePaging()
        {
            var dt = new DataTable();
            dt.Columns.Add("PageIndex"); //Start from 0
            dt.Columns.Add("PageText"); //Start from 1

            _firstIndex = CurrentPage - 5;
            if (CurrentPage > 5)
                _lastIndex = CurrentPage + 5;
            else
                _lastIndex = 10;

            // Check last page is greater than total page then reduced it 
            // to total no. of page is last index
            if (_lastIndex > Convert.ToInt32(ViewState["TotalPages"]))
            {
                _lastIndex = Convert.ToInt32(ViewState["TotalPages"]);
                _firstIndex = _lastIndex - 10;
            }

            if (_firstIndex < 0)
                _firstIndex = 0;

            // Now creating page number based on above first and last page index
            for (var i = _firstIndex; i < _lastIndex; i++)
            {
                var dr = dt.NewRow();
                dr[0] = i;
                dr[1] = i + 1;
                dt.Rows.Add(dr);
            }

            rptPaging.DataSource = dt;
            rptPaging.DataBind();
        }

        protected void lbFirst_Click(object sender, EventArgs e)
        {
            serial_number = 0;
            CurrentPage = 0;
            serial_number = ((CurrentPage) * _pageSize) + serial_number;

            bindrepeater();
        }
        protected void lbLast_Click(object sender, EventArgs e)
        {
            serial_number = 0;
            CurrentPage = (Convert.ToInt32(ViewState["TotalPages"]) - 1);

            serial_number = ((CurrentPage) * _pageSize) + serial_number;
            bindrepeater();
        }
        protected void lbPrevious_Click(object sender, EventArgs e)
        {
            serial_number = serial_number - 5;
            CurrentPage -= 1;
            serial_number = 0;
            serial_number = ((CurrentPage) * _pageSize) + serial_number;
            bindrepeater();
        }
        protected void lbNext_Click(object sender, EventArgs e)
        {
            CurrentPage += 1;
            serial_number = 0;
            serial_number = ((CurrentPage) * _pageSize) + serial_number;
            bindrepeater();
        }

        protected void rptPaging_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (!e.CommandName.Equals("newPage")) return;
            CurrentPage = Convert.ToInt32(e.CommandArgument.ToString());
            bindrepeater();
        }

        protected void rptPaging_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            var lnkPage = (LinkButton)e.Item.FindControl("lbPaging");
            if (lnkPage.CommandArgument != CurrentPage.ToString()) return;
            lnkPage.Enabled = false;

        }



        //For overall serial numbering
        protected void changedataset(string value,int n)
        {
                  DT.Rows[n][1]= value;      
        }

        protected string GetRowNo()
        {



            serial_number += 1;

            return serial_number.ToString();
        }
        protected void changedataset()
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AutoDefaultEdit.aspx");
        }

       
        
    }
}