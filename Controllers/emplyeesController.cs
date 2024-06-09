using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapp.data;
using webapp.Models;

namespace webapp.Controllers
{
    public class emplyeesController : Controller
    {

        ApplicationDbContext _context;
        public emplyeesController(ApplicationDbContext context)
        {
            _context = context;
        }


        // employees = new List<Employee>();
        [HttpGet]
        public IActionResult GetIndexView(String? search) //nullable
        {
            ViewBag.Search = search;

            if (search == null) {
                return View("Index", _context.Employees);

            }
            else { 
                return View("Index", _context.Employees.Where(e => e.FullName.Contains(search) ||  e.Position.Contains(search))) ;
                }

        }
        [HttpGet]

        public IActionResult GetdetalisView(int id)
        {
            Employee employee = _context.Employees.Include(e=>e.Department).FirstOrDefault(emp => emp.Id == id);
            if (employee == null)
            {
                return NotFound();

            }
            else {
                return View("detalis", employee);
            }



        }
        [HttpGet]
        public IActionResult GetCreateView()
        {
            ViewBag.AllDepartments=_context.Departments.ToList();
            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddNew([Bind("Id,FullName,Position,Salary,Appraisal,birthdate,joinDateTime ,IsActive , DepartmentId")] Employee emp)

        {
            if ((emp.joinDateTime - emp.birthdate).Days / 365 < 18) {

                ModelState.AddModelError("", "under 18 years ago");
            }
            if (ModelState.IsValid == true)
            {
                _context.Employees.Add(emp);
                _context.SaveChanges();
                return RedirectToAction("GetIndexView");
            }

            else
            {
                ViewBag.AllDepartments = _context.Departments.ToList();


                return View("Create"); }
        }
        [HttpGet]
        public IActionResult GetEditView(int id) {


            Employee employee = _context.Employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {

                return NotFound();
            }
            else
            {
                ViewBag.AllDepartments = _context.Departments.ToList();

                return View("Edit", employee);
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditCurrent([Bind("Id,FullName,Position,Salary,Appraisal,birthdate,joinDateTime ,IsActive ,DepartmentId")] Employee emp) {

            if ((emp.joinDateTime - emp.birthdate).Days / 365 < 18)
            {

                ModelState.AddModelError("", "under 18 years ago");
            }
            if (ModelState.IsValid == true)
            {
                _context.Employees.Update(emp);
                _context.SaveChanges();
                return RedirectToAction("GetIndexView");
            }

            else {
                ViewBag.AllDepartments = _context.Departments.ToList();

                return View("Edit"); }
        }
        public IActionResult GetDeleteView(int id)
        {


            Employee employee = _context.Employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {

                return NotFound();
            }
            else
            {
                return View("Delete", employee);
            }

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteCurrent(int id)
        {
            Employee employee = _context.Employees.FirstOrDefault(e=>e.Id == id);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return RedirectToAction("GetIndexView");
             
        }
    }
    }

