//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using DB.Model;
//using DB.IDal;
//using System.Data;
//using System.Data.SqlClient;

//namespace DB.Dal
//{
//    public class DEmployeeLogin  : SqlBase, IEmployeeLogin
//    {
//        public int CreatEmployeeLogin(M_EmployeeLogin Obj,string ErrMsg)
//        {
//            SqlConnection conn;
//            using (conn = CreatConn())
//            {
//                try
//                {
//                    conn.Open();
//                }
//                catch (Exception ex)
//                {
//                    ErrMsg = ex.Message;
//                    return -1;
//                }
//            }
//        }

//    }
//}