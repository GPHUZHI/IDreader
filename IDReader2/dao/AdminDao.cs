using IDReader2.model;
using IDReader2.util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDReader2.dao
{
    public class AdminDao
    {
        public static Manager getManager(string account)
        {

            SqlConnection conn = util.DBConnection.getConnection();
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                if (MessageBox.Show("数据库连接失败，请检查数据库配置或者网络配置", "数据库连接失败", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            Manager user = null;
            try
            {
                Console.WriteLine("初始化查询参数");
                string sql = "SELECT [id],[password],[day],[type] FROM sys_manager WHERE account=@account";
                Console.WriteLine("连接开启");
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@account", account);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        Console.WriteLine("结果：" + dr.HasRows);
                        if (dr.Read())
                        {
                            int id = Convert.ToInt32(dr["id"]);
                            string password = Convert.ToString(dr["password"]);
                            int day = Convert.ToInt32(dr["day"]);
                            int type = Convert.ToInt32(dr["type"]);
                            user = new Manager();
                            user.Id = id;
                            user.Account = account;
                            user.Passwd = password;
                            user.Day = day;
                            user.Type = type;
                        }
                        dr.Close();
                    }
                }
                Console.WriteLine(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\r\n" + ex.StackTrace);
            }
            finally
            {
                DBConnection.closeConnection(conn);
            }
            return user;
        }
    }
}
