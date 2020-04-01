using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InvoiceSystem.Controllers
{
    public class LoginRegisterController : Controller
    {
        // GET: LoginRegister
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Success()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Models.LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                
            }
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Models.RegisterViewModel model)
        {
            try
            {
                string Usertype = "普通用户";
                int Admin_BL = 0;
                string connectionString =
                    "Data Source=WIN-0MGTRP6ACV5\\MSSQL;Initial Catalog=test;Persist Security Info=false;User ID=sa;Password=Aa123456";
                SqlConnection SqlCon = new SqlConnection(connectionString); //数据库连接
                SqlCon.Open(); //打开数据库
                string sql = "insert into [test].[dbo].[user_1] values" +
                             $"('{model.RegisterTel}','{model.RegisterPassword}','{Usertype}',{Admin_BL})";
                SqlCommand cmd = new SqlCommand(sql, SqlCon);
                cmd.CommandType = CommandType.Text;
                int ret = (int)cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                    return RedirectToAction("Success");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return View();
        }
        [HttpGet]
        public ActionResult AdminRegister()
        {
            return View();
        }
        public ActionResult AdminRegister(Models.AdminRegisterViewModel model)
        {
            try
            {
                string Usertype = "管理员用户";
                int Admin_BL = 1;
                string connectionString =
                    "Data Source=WIN-0MGTRP6ACV5\\MSSQL;Initial Catalog=test;Persist Security Info=false;User ID=sa;Password=Aa123456";
                SqlConnection SqlCon = new SqlConnection(connectionString); //数据库连接
                SqlCon.Open(); //打开数据库
                string sql = "insert into [test].[dbo].[admin] values" +
                             $"('{model.AdminTel}','{model.AdminPassword}','{Usertype}',{Admin_BL})";
                SqlCommand cmd = new SqlCommand(sql, SqlCon);
                cmd.CommandType = CommandType.Text;
                int ret = (int)cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                    return RedirectToAction("Success");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return View();
        }

    }
}