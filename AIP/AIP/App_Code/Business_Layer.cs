using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace AIP.App_Code
{
    public class Business_Layer
    {

        // user registration process begins
        public string user_registration_process(User_Object user_details)
        {
            Data_Access_Layer data_object_I = new Data_Access_Layer();
            try
            {
                return data_object_I.User_Registration(user_details);
            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                data_object_I = null;
            }
        }


        // user registration process ends

        // Admin Registration process starts

        public string admin_registration_process(Admin_Object admin_details)
        {
            Data_Access_Layer data_object_II = new Data_Access_Layer();
            try
            {
                return data_object_II.Admin_Registration(admin_details);
            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                data_object_II = null;
            }
        }

        //  Admin Registration process finishes

        // Admin Login Process starts

        public string admin_login_process(Admin_Object admin_details)
        {
            Data_Access_Layer data_object_III = new Data_Access_Layer();
            try
            {
                return data_object_III.Admin_Login(admin_details);
            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                data_object_III = null;
            }
        }

        // Admin Login Process Ends

        // User Login Process Starts

        public string user_login_process(User_Object user_details)
        {
            Data_Access_Layer data_object_VI = new Data_Access_Layer();
            try
            {
                return data_object_VI.User_Login(user_details);
            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                data_object_VI = null;
            }
        }

        public string get_user_id()
        {
            Data_Access_Layer data_object_V = new Data_Access_Layer();
            try
            {
                return data_object_V.getUser_id();
            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                data_object_V = null;
            }

        }


        public string get_admin_id()
        {
            Data_Access_Layer data_object_V = new Data_Access_Layer();
            try
            {
                return data_object_V.getAdmin_id();
            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                data_object_V = null;
            }

        }


        public DataSet get_auto_default()
        {
            Data_Access_Layer data_object_VI = new Data_Access_Layer();
            try
            {
                return data_object_VI.getAutoDefault();
            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                data_object_VI = null;
            }

        }


        public DataSet get_manual_default()
        {
            Data_Access_Layer data_object_VII = new Data_Access_Layer();
            try
            {
                return data_object_VII.getManualDefault();
            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                data_object_VII = null;
            }

        }

        public string update_database(DataSet DS)
        {
            Data_Access_Layer data_object_VIII = new Data_Access_Layer();
            try
            {
                return data_object_VIII.setUpdatedDatabase(DS);
            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                data_object_VIII = null;
            }
        }

    }
}