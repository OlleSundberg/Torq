using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Torq.Models.Objects;
using Torq.MVC.EmployeesService;
using Torq.MVC.SchedulesService;
using Torq.MVC.SalariesService;
using Torq.MVC.RolesService;
using Torq.MethodLiberary;

namespace Torq.MVC.Controllers
{
    public class CalendarController : Controller
    {

        // GET: Calendar
        [HttpGet]
        public ActionResult Index()
        {
			DateHandler dateHandler = new DateHandler();

			ViewBag.DayOfWeek = dateHandler.GetDayOfWeek(1);

			using (ScheduleServiceClient scheduleService = new ScheduleServiceClient())
            {
                var schedules = scheduleService.GetSchedules()/*.Where(s => s.Employee == employee)*/;
            }


            Schedule[] MockArray = new Schedule[] {
                new Schedule { Id = 1, ClockedIn = false, Employee = null, EndTime = new DateTime(2018, 5, 1, 18, 30, 52), StartTime = new DateTime(2018, 5, 1, 8, 30, 52), Salary = null },
                new Schedule { Id = 2, ClockedIn = false, Employee = null, EndTime = new DateTime(2018, 5, 2, 18, 30, 52), StartTime = new DateTime(2018, 5, 2, 8, 30, 52), Salary = null },
                new Schedule { Id = 3, ClockedIn = false, Employee = null, EndTime = new DateTime(2018, 5, 3, 18, 30, 52), StartTime = new DateTime(2018, 5, 3, 8, 30, 52), Salary = null },
                new Schedule { Id = 4, ClockedIn = true, Employee = new Employee { Id = 1, FirstName = "Tobb", LastName = "Fobbs", IsOnline = false }, EndTime = new DateTime(2018, 5, 4, 18, 30, 52), StartTime = new DateTime(2018, 5, 4, 8, 30, 52), Salary = null },
                new Schedule { Id = 5, ClockedIn = false, Employee = new Employee { Id = 2, FirstName = "Mobbs", LastName = "Robbs", IsOnline = false }, EndTime = new DateTime(2018, 5, 5, 18, 30, 52), StartTime = new DateTime(2018, 5, 5, 8, 30, 52), Salary = null },
            };

            List<Schedule> MockList = new List<Schedule>()
            {
                new Schedule { Id = 1, ClockedIn = false, Employee = null, EndTime = new DateTime(2018, 5, 1, 18, 30, 52), StartTime = new DateTime(2018, 5, 1, 8, 30, 52), Salary = null },
                new Schedule { Id = 2, ClockedIn = false, Employee = null, EndTime = new DateTime(2018, 5, 2, 18, 30, 52), StartTime = new DateTime(2018, 5, 2, 8, 30, 52), Salary = null },
                new Schedule { Id = 3, ClockedIn = false, Employee = null, EndTime = new DateTime(2018, 5, 3, 18, 30, 52), StartTime = new DateTime(2018, 5, 3, 8, 30, 52), Salary = null },
                new Schedule { Id = 4, ClockedIn = true, Employee = new Employee { Id = 1, FirstName = "Tobb", LastName = "Fobbs", IsOnline = false }, EndTime = new DateTime(2018, 5, 4, 18, 30, 52), StartTime = new DateTime(2018, 5, 4, 8, 30, 52), Salary = null },
                new Schedule { Id = 5, ClockedIn = false, Employee = new Employee { Id = 2, FirstName = "Mobbs", LastName = "Robbs", IsOnline = false }, EndTime = new DateTime(2018, 5, 5, 18, 30, 52), StartTime = new DateTime(2018, 5, 5, 8, 30, 52), Salary = null }
            };

            Schedule[] schedulesArray = new Schedule[] { };
            Employee[] employees = new Employee[] { };

            using (ScheduleServiceClient db = new ScheduleServiceClient())
            {
                schedulesArray = db.GetSchedules();
            }
            using (EmployeeServiceClient eb = new EmployeeServiceClient())
            {
                employees = eb.GetEmployees();
            }


            var sortArray = schedulesArray.OrderBy(m => m.StartTime).ToArray();
            ViewBag.CalendarDataArray = MockArray;
            ViewBag.CalendarDataList = MockList;
            ViewBag.Employees = employees;
            //@model Torq.Models.Objects.Schema[]
            //@model List<Torq.Models.Objects.Schema>
            return View(sortArray);
        }

        public ActionResult CreateSchedule()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSchedule([Bind(Include = "StartTime,EndTime")] Schedule schedule, int? Id)
        {
            schedule.ClockedIn = false;
            var x = schedule;

            using (ScheduleServiceClient db = new ScheduleServiceClient())
            {
                db.CreateSchedule(schedule);
            }

            return Redirect("~/calendar/index");
        }

        [HttpGet]
        public ActionResult EditSchedule(int id)
        {

            using (ScheduleServiceClient db = new ScheduleServiceClient())
            {
                using (EmployeeServiceClient edb = new EmployeeServiceClient())
                {
                    var schedule = db.GetScheduleById(id);
                    var x = edb.GetEmployees();
                    ViewData["Employees"] = edb.GetEmployees();
                    return View(schedule);
                }
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditSchedule([Bind(Include = "Id,ClockedIn,StartTime,EndTime,Employee")] Schedule schedule)
        {

            using (ScheduleServiceClient db = new ScheduleServiceClient())
            {
                using (EmployeeServiceClient edb = new EmployeeServiceClient())
                {
                    Employee x = edb.GetEmployeeById(schedule.Employee.Id);
                    schedule.Employee = x;
                    //TODO: updaterar ej employee, behöver fkey endast vara EmployeeId?
                    db.UpdateScheduleAsync(schedule);

                }
            }
            return Redirect("~/calendar/index");
        }

        public ActionResult CreateEmployee()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateEmployee([Bind(Include = "UserName,Password,FirstName,LastName,Email,IsOnline")] Employee employee)
        {
            using (EmployeeServiceClient edb = new EmployeeServiceClient())
            {
                edb.CreateEmployeeAsync(employee);

                return Redirect("~/calendar/index");
            }
        }


        public ActionResult CreateSalary()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSalary([Bind(Include = "SalaryType,Amount")] Salary salary)
        {
            using (SalaryServiceClient ss = new SalaryServiceClient())
            {
                ss.CreateSalary(salary);
                return Redirect("~/calendar/index");
            }

        }
	}


}