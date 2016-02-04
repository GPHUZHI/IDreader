using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDReader2.model;
using System.Data.SqlClient;
using IDReader2.util;

namespace IDReader2.dao
{
    class CustomerDao
    {
        public static Customer getCustomerByAccount(string account)
        {
            SqlConnection conn = DBConnection.getConnection();
            try
            {
                conn.Open();
            }
            catch (SqlException e)
            {
                throw e;
            }
            Customer user = null;
            try
            {
                Console.WriteLine("初始化查询参数"+account);
                string sql = "SELECT [account],[password],[gender],[starttime],[availableday],[name] FROM available_user WHERE account=@account";
                Console.WriteLine("连接开启");
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@account", account);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        Console.WriteLine("结果：" + dr.HasRows);
                        if (dr.Read())
                        {
                            string name = Convert.ToString(dr["name"]);
                            string password = Convert.ToString(dr["password"]);
                            string gender = Convert.ToString(dr["gender"]);
                            DateTime starttime = Convert.ToDateTime(dr["starttime"]);
                            int availableday = Convert.ToInt32(dr["availableday"]);
                            user = new Customer();
                            user.Account = account;
                            user.Name = name;
                            user.Password = password;
                            user.Gender = gender;
                            user.StartTime = starttime;
                            user.AvailableDay = availableday;
                        }
                        dr.Close();
                    }
                }
                Console.WriteLine(user);
            }
            catch (Exception ex)
            {
               throw ex;
            }
            finally
            {
                DBConnection.closeConnection(conn);
            }
            return user;
        }

        internal static List<Customer> getCustomers()
        {
            throw new NotImplementedException();
        }

        internal static void RemoveCustomerDao(Customer u)
        {
            try {
                InsertUser("unavailable_user", u);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (u == null)
            {
                return;
            }
            string sql = "DELETE FROM available_user WHERE account=@account";
            SqlConnection con = DBConnection.getConnection();
            try
            {
                Console.WriteLine("初始化删除参数");
                con.Open();
                Console.WriteLine("连接开启");
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@account", u.Account);
                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw  new Exception("移除失效用户失败!");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                DBConnection.closeConnection(con);
            }
        }

        internal static List<Customer> GetUnAvailableUser()
        {
            SqlConnection con = DBConnection.getConnection();
            List<Customer> users = new List<Customer>();
            try
            {
                Console.WriteLine("初始化查询参数");
                con.Open();
                string sql = "SELECT [account],[password],[gender],[starttime],[availableday],[name] FROM unavailable_user";
                Console.WriteLine("连接开启");
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        Console.WriteLine("结果：" + dr.HasRows);
                        while (dr.Read())
                        {
                            string name = Convert.ToString(dr["name"]);
                            string account = Convert.ToString(dr["account"]);
                            string password = Convert.ToString(dr["password"]);
                            string gender = Convert.ToString(dr["gender"]);
                            DateTime starttime = Convert.ToDateTime(dr["starttime"]);
                            int availableday = Convert.ToInt32(dr["availableday"]);
                            Customer user = new Customer();
                            user.Account = account;
                            user.Name = name;
                            user.Password = password;
                            user.Gender = gender;
                            user.StartTime = starttime;
                            user.AvailableDay = availableday;
                            users.Add(user);
                        }
                        dr.Close();
                    }
                }
                Console.WriteLine(users);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                DBConnection.closeConnection(con);
            }
            return users;
        }

        internal static List<Customer> GetAvailableUser()
        {
            SqlConnection con = DBConnection.getConnection();
            List<Customer> users = new List<Customer>();
            try
            {
                Console.WriteLine("初始化查询参数");
                con.Open();
                string sql = "SELECT [account],[password],[gender],[starttime],[availableday],[name] FROM available_user";
                Console.WriteLine("连接开启");
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        Console.WriteLine("结果：" + dr.HasRows);
                        while (dr.Read())
                        {
                            string name = Convert.ToString(dr["name"]);
                            string account = Convert.ToString(dr["account"]);
                            string password = Convert.ToString(dr["password"]);
                            string gender = Convert.ToString(dr["gender"]);
                            DateTime starttime = Convert.ToDateTime(dr["starttime"]);
                            int availableday = Convert.ToInt32(dr["availableday"]);
                            Customer user = new Customer();
                            user.Account = account;
                            user.Name = name;
                            user.Password = password;
                            user.Gender = gender;
                            user.StartTime = starttime;
                            user.AvailableDay = availableday;
                            users.Add(user);
                        }
                        dr.Close();
                    }
                }
                Console.WriteLine(users);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                DBConnection.closeConnection(con);
            }
            return users;
        }

        internal static void InsertCustomer(Customer c)
        {
            // 登记新用户
            if (c == null)
            {
                return;
            }
            Console.WriteLine("插入新成员");
            try {
                InsertUser("available_user", c);
            }catch(Exception e)
            {
                throw e;
            }
        }

        private static void InsertUser(string TABLE_NAME, Customer user)
        {
            if (TABLE_NAME == null || user == null)
            {
                return;
            }
            SqlConnection con = DBConnection.getConnection();
            try
            {
                Console.WriteLine("初始化" + TABLE_NAME + "插入参数");
                con.Open();
                string sql = "INSERT INTO " + TABLE_NAME + "(account,password, gender, starttime, availableday, name)"
                      + " VALUES(@account,@password,@gender,@starttime,@availableday,@name)";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@account", user.Account);
                    cmd.Parameters.AddWithValue("@passowrd", user.Password);
                    cmd.Parameters.AddWithValue("@gender", user.Gender);
                    cmd.Parameters.AddWithValue("@starttime", user.StartTime);
                    cmd.Parameters.AddWithValue("@availableday", user.AvailableDay);
                    cmd.Parameters.AddWithValue("@name", user.Name);
                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        throw new Exception("插入失败!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException());
                throw ex;
            }
            finally
            {
                DBConnection.closeConnection(con);
            }
            throw new Exception("插入成功!");
        }
    }
}
