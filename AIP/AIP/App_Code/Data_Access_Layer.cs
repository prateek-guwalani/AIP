using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AIP.App_Code
{
    public class Data_Access_Layer
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["AIP_1"].ConnectionString);

        //Insertion of the Admin details (Admin Registration)
        public string Admin_Registration(Admin_Object admin_details)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("A_Sign_Up", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@log_id", admin_details.login_id_value);
                cmd.Parameters.AddWithValue("@fir_nam", admin_details.first_name_value);
                cmd.Parameters.AddWithValue("@las_nam", admin_details.last_name_value);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt16(admin_details.age_value));
                cmd.Parameters.AddWithValue("@gen", admin_details.gender_value);
                cmd.Parameters.AddWithValue("@con_num", long.Parse(admin_details.contact_number_value));
                cmd.Parameters.AddWithValue("@emailid", admin_details.email_value);
                cmd.Parameters.AddWithValue("@adm_add", admin_details.admin_address_value);
                cmd.Parameters.AddWithValue("@cou", admin_details.country_value);
                cmd.Parameters.AddWithValue("@cit", admin_details.city_name_value);
                cmd.Parameters.AddWithValue("@pin", Convert.ToInt32(admin_details.pincode_value));
                cmd.Parameters.AddWithValue("@pass", admin_details.password_value);
                return cmd.ExecuteNonQuery().ToString();
            }
            catch (Exception show_error)
            {
                throw show_error;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }

        }




        //Insertion of User details (User Registration)



        public string User_Registration(User_Object user_details)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("U_Sign_Up", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@log_id", user_details.login_id_value);
                cmd.Parameters.AddWithValue("@acc_num", user_details.account_number_value);
                cmd.Parameters.AddWithValue("@fir_nam", user_details.first_name_value);
                cmd.Parameters.AddWithValue("@las_nam", user_details.last_name_value);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt16(user_details.age_value));
                cmd.Parameters.AddWithValue("@gen", user_details.gender_value);
                cmd.Parameters.AddWithValue("@con_num", long.Parse(user_details.contact_number_value));
                cmd.Parameters.AddWithValue("@emailid", user_details.email_value);
                cmd.Parameters.AddWithValue("@adm_add", user_details.admin_address_value);
                cmd.Parameters.AddWithValue("@cou", user_details.country_value);
                cmd.Parameters.AddWithValue("@cit", user_details.city_name_value);
                cmd.Parameters.AddWithValue("@pin", Convert.ToInt16(user_details.pincode_value));
                cmd.Parameters.AddWithValue("@pass", user_details.password_value);
                return cmd.ExecuteNonQuery().ToString();
            }
            catch (Exception show_error)
            {
                throw show_error;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }

        }


        // Admin Login 

        public string Admin_Login(Admin_Object admin_details)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("A_login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@log_id", admin_details.login_id_value);
                cmd.Parameters.AddWithValue("@pass", admin_details.password_value);

                return cmd.ExecuteScalar().ToString();
            }
            catch (Exception show_error)
            {
                throw show_error;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }

        }

        // User Login


        public string User_Login(User_Object user_details)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("U_login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@log_id", user_details.login_id_value);
                cmd.Parameters.AddWithValue("@pass", user_details.password_value);
                return cmd.ExecuteScalar().ToString();
            }
            catch (Exception show_error)
            {
                throw show_error;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }

        }

        public string getAdmin_id()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("get_count_admin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                int x = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                string to_return = "admin" + x.ToString();

                return to_return;
            }
            catch (Exception show_error)
            {
                throw show_error;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }
        }

        public string getUser_id()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("get_count_user", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                int x = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                string to_return = "user" + x.ToString();

                return to_return;
            }
            catch (Exception show_error)
            {
                throw show_error;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }
        }


        // Auto Default Repeater

        public DataSet getAutoDefault()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("getAutoDefault_table", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                DataSet DS = new DataSet();

                SqlDataAdapter SDA = new SqlDataAdapter(cmd);

                SDA.Fill(DS);



                return DS;
            }
            catch (Exception show_error)
            {
                throw show_error;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }
        }

        public DataSet getManualDefault()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("getManualDefault_table", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                DataSet DS = new DataSet();

                SqlDataAdapter SDA = new SqlDataAdapter(cmd);

                SDA.Fill(DS);



                return DS;
            }
            catch (Exception show_error)
            {
                throw show_error;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }
        }

        public string setUpdatedDatabase(DataSet DS)
        {


            int rw = DS.Tables[0].Rows.Count;
            for (int i = 0; i < rw; i++)
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AIP_1"].ConnectionString);

                conn.Open();
                SqlCommand cmd = new SqlCommand("update_Bank_DB", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    cmd.Parameters.AddWithValue("@stat", DS.Tables[0].Rows[i][0]);
                    cmd.Parameters.AddWithValue("@acc_num", DS.Tables[0].Rows[i][5]);
                    cmd.ExecuteNonQuery();
                    
                }
                catch (Exception show_error)
                {
                    throw show_error;
                }
                finally
                {
                    cmd.Dispose();
                    conn.Close();
                    conn.Dispose();
                }

            }
            return "Database Update Successful";

            //con.Open();
            //SqlCommand cmd = new SqlCommand("getAutoDefault_table", con);
            //cmd.CommandType = CommandType.StoredProcedure;

            //    SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            //    SDA.TableMappings.Add("DS.Tables[0]", "Bank_Details");
            //    SqlCommandBuilder objCommandBuilder = new SqlCommandBuilder(SDA);
            //    SDA.Update(DS,"Bank_Details");
            //    return "Database Update Successful";
            
            
        }

    }
}