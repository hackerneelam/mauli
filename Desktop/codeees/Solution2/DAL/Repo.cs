using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BOL;

namespace DAL
{
    public class Repo
    {
        public static bool Validate(string name, string Password)
        {
            bool status = false;

            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dac\source\repos\Solution2\WebApplication1\App_Data\Database1.mdf;Integrated Security=True";
            con.ConnectionString = conString;
            string query = "Select * from Employee where name=@name and Password=@Password";
            cmd.CommandText = query;
            cmd.Parameters.Add(new SqlParameter("@name", name));
            cmd.Parameters.Add(new SqlParameter("@Password", Password));
            cmd.Connection = con;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    status = true;
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally {
                con.Close();
            }
            return status;
        }

        public static List<Employee> getAllDetails()
        {
            List<Employee> list = new List<Employee>();
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dac\source\repos\Solution2\WebApplication1\App_Data\Database1.mdf;Integrated Security=True";
            con.ConnectionString = conString;
            string query = "Select * from Employee";
            cmd.CommandText = query;
            cmd.Connection = con;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["Id"].ToString());
                    string name = reader["Name"].ToString();
                    string add = reader["Address"].ToString();
                    int sal = int.Parse(reader["Salary"].ToString());
                    string pass = reader["Password"].ToString();

                    list.Add(new Employee()
                    {
                        Id = id,
                        Name = name,
                        Address = add,
                        salary = sal,
                        Password = pass
                    });
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally {
                con.Close();
            }
            
            return list;
        }


        public static bool Insert(int id, string name, string address, string salary, string password)
        {
            bool status = false;

            //SqlConnection con=new SqlConnection();
           // SqlCommand cmd = new SqlCommand();
          

            string qry = "insert into Employee values(@Id,@Name,@Address,@salary,@Password)";
            string ConString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dac\source\repos\Solution2\WebApplication1\App_Data\Database1.mdf;Integrated Security=True";

           
            

            
            using (SqlConnection conn = new SqlConnection(ConString))
            {
                using (SqlCommand cmd = new SqlCommand(qry))
                {

                    cmd.Parameters.Add(new SqlParameter("@Id", id));
                    cmd.Parameters.Add(new SqlParameter("@Name", name));
                    cmd.Parameters.Add(new SqlParameter("@Address", address));
                    cmd.Parameters.Add(new SqlParameter("@salary", salary));
                    cmd.Parameters.Add(new SqlParameter("@Password", password));
              
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    status = true;
                }
            }
            return status;
        }


        public static bool update(int id, string password)
        {
            bool status = false;

            string query = "update Employee set Password=@Password where Id=@Id";
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dac\source\repos\Solution2\WebApplication1\App_Data\Database1.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Parameters.Add(new SqlParameter("@Id", id));
                    cmd.Parameters.Add(new SqlParameter("@Password", password));
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    status = true;
                }
            }
            return status;
        }
    }
}
