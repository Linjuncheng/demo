using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DB.Model;
using DB.Dal;
using DB.IDal;

namespace InvoiceSystem.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            string ErrMsg = string.Empty;
            I_TokenTable u = new D_TokenTable();
            List<M_TokenTable> l = new List<M_TokenTable>();
            M_TokenTable m = new M_TokenTable();

            m.AesIV = "a33300";
            m.AesKey = "a33300a";
            m.Exp = 53330;
            m.MType = 13;
            m.Sign = "s03333000";
            m.Token = "1033333001";
            m.User_ID = 10222220;
            m.ID = 5;
            l.Add(m);

            m = new M_TokenTable();
            m.AesIV = "a022220";
            m.AesKey = "a22200a";
            m.Exp = 1222200;
            m.MType = 12;
            m.Sign = "s0222200";
            m.Token = "1033333001";
            m.User_ID = 122220;
            m.ID = 6;
            l.Add(m);

            m = new M_TokenTable();
            m.AesIV = "a111100";
            m.AesKey = "111100";
            m.Exp = 11110;
            m.MType = 111;
            m.Sign = "1110";
            m.Token = "1033333001";
            m.User_ID = 110;
            m.ID = 8;
            l.Add(m);

            //if (u.Delete(m,ref ErrMsg) > -1)
            //{

            //}
            //else
            //{
            //    return Content(ErrMsg);
            //}

            return Json(m,JsonRequestBehavior.AllowGet);
        }
    }
}