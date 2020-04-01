using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InvoiceSystem.dal;
using InvoiceSystem.Models;
using PagedList;


namespace InvoiceSystem.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        private StudentContext db = new StudentContext();

        public ViewResult Index(int? page)
        {
            //学生列表
            var students = from s in db.Students select s;

            //第几页
            int pageNumber = page ?? 1;

            //每页显示多少条
            int pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"]);

            //根据ID排序
            students = students.OrderBy(x => x.ID);

            //通过ToPagedList扩展方法进行分页
            IPagedList<Student> pagedList = students.ToPagedList(pageNumber, pageSize);

            //将分页处理后的列表传给View
            return View(pagedList);
        }


    }
}