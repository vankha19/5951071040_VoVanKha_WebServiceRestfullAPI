using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace _5951071040_VoVanKha_CRUD.Models
{
    public class db
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-9DKLIBTR;Initial Catalog=DemoCRUD;Integrated Security=True");


        public DataSet Empget(Employee emp, out string msg)
        {
            msg = null;
            DataSet ds = new DataSet();
            string msp = "";
            try
            {
                SqlCommand comm = new SqlCommand("Sp_Employee", conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@Sr_no", emp.Sr_no);
                comm.Parameters.AddWithValue("@Emp_name", emp.Emp_name);
                comm.Parameters.AddWithValue("@City", emp.City);
                comm.Parameters.AddWithValue("@STATE", emp.State);
                comm.Parameters.AddWithValue("@Country", emp.Country);
                comm.Parameters.AddWithValue("@Department", emp.Department);
                comm.Parameters.AddWithValue("@flag",emp.flag);
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(ds);
                msg = "ok";
                return ds;
            }
            catch(Exception ex)
            {
                msp = ex.Message;
                
                return ds;
            }
        }
        public string Empdml(Employee emp,out string msg)
        {
            msg = null;
            string msp = "";
            try
            {
                SqlCommand comm = new SqlCommand("Sp_Employee", conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@Sr_no", emp.Sr_no);
                comm.Parameters.AddWithValue("@Emp_name", emp.Emp_name);
                comm.Parameters.AddWithValue("@City", emp.City);
                comm.Parameters.AddWithValue("@STATE", emp.State);
                comm.Parameters.AddWithValue("@Country", emp.Country);
                comm.Parameters.AddWithValue("@Department", emp.Department);
                comm.Parameters.AddWithValue("@flag", emp.flag);
                conn.Open();
                comm.ExecuteNonQuery();
                conn.Close();
                msg = "OK";
                return msg;
            }
            catch(Exception ex)
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                msp = ex.Message;
                return msp;
            }
        }
    }
  
   


}
    