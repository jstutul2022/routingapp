using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SevenExercise.Models;
namespace SevenExercise.Controllers
{
    [RoutePrefix("employees")]
    public class EmployeeController : Controller
    {
        // GET: Employee
        [Route("")]
        public ActionResult GetAllEmployee()
        {
            var employee_list = Employees();
            ViewBag.Employees = employee_list;
            return View();
        }
        [Route("{id:int}")]
        public ActionResult SingleEmployee(int id)
        {
            var employee = Employees().FirstOrDefault(x => x.Id == id);
            ViewBag.SingleEmployee = employee;
            return View();
        }
        private List<Employee> Employees()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    Id=1,
                    FirstName="Md.",
                    LastName="Kalam",
                    Age=23,
                    Phone="11111111111",
                    Gender="Male",
                    Email="kalam@gmail.com",
                    Skill=new Skill()
                    {
                        WebDesign =true,
                        WebDeveloper=true,
                        GraphicsDesigner=false,
                        AppDeveloper =false,
                        UIUXDesigner =false,
                        FullStacDeveloper =true,
                    }
                },
                new Employee()
                {
                    Id=2,
                    FirstName="Md.",
                    LastName="Salam",
                    Age=24,
                    Phone="12211111133",
                    Gender="Male",
                    Email="salam@gmail.com",
                    Skill=new Skill()
                    {
                        WebDesign =true,
                        WebDeveloper=false,
                        GraphicsDesigner=false,
                        AppDeveloper =false,
                        UIUXDesigner =true,
                        FullStacDeveloper =false,
                    }
                },
                new Employee()
                {
                    Id=3,
                    FirstName="Mrs",
                    LastName="Salma",
                    Age=23,
                    Phone="33333333333",
                    Gender="Female",
                    Email="salma@gmail.com",
                    Skill=new Skill()
                    {
                        WebDesign =true,
                        WebDeveloper=true,
                        GraphicsDesigner=false,
                        AppDeveloper =false,
                        UIUXDesigner =false,
                        FullStacDeveloper =false,
                    }
                },
                new Employee()
                {
                    Id=4,
                    FirstName="Md.",
                    LastName="Kuddus",
                    Age=23,
                    Phone="1212123434123",
                    Gender="Male",
                    Email="kuddus@gmail.com",
                    Skill=new Skill()
                    {
                        WebDesign =true,
                        WebDeveloper=true,
                        GraphicsDesigner=false,
                        AppDeveloper =false,
                        UIUXDesigner =false,
                        FullStacDeveloper =true,
                    }
                },
                new Employee()
                {
                    Id=5,
                    FirstName="Mrs",
                    LastName="Selina",
                    Age=23,
                    Phone="32323232321",
                    Gender="Female",
                    Email="selina@gmail.com",
                    Skill=new Skill()
                    {
                        WebDesign =false,
                        WebDeveloper=false,
                        GraphicsDesigner=false,
                        AppDeveloper =true,
                        UIUXDesigner =true,
                        FullStacDeveloper =false,
                    }
                },
                new Employee()
                {
                    Id=6,
                    FirstName="Md.",
                    LastName="Shoaib",
                    Age=23,
                    Phone="11111111111",
                    Gender="Male",
                    Email="shoaib@gmail.com",
                    Skill=new Skill()
                    {
                        WebDesign =true,
                        WebDeveloper=true,
                        GraphicsDesigner=false,
                        AppDeveloper =false,
                        UIUXDesigner =false,
                        FullStacDeveloper =true,
                    }
                },
                new Employee()
                {
                    Id=7,
                    FirstName="Md.",
                    LastName="Ali",
                    Age=23,
                    Phone="88888888888",
                    Gender="Male",
                    Email="ali@gmail.com",
                    Skill=new Skill()
                    {
                        WebDesign =false,
                        WebDeveloper=true,
                        GraphicsDesigner=false,
                        AppDeveloper =true,
                        UIUXDesigner =false,
                        FullStacDeveloper =true,
                    }
                },
            };
        }

    }
}