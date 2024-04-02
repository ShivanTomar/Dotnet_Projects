using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentsPortal.Web.Data;
using StudentsPortal.Web.Models;
using StudentsPortal.Web.Models.Entities;
using System.Reflection.Metadata.Ecma335;

namespace StudentsPortal.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public StudentController(ApplicationDbContext dbContext) {
            this.dbContext = dbContext;
        }  

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        {
            var student = new Student
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                Subscribed = viewModel.Subscribed
            };
            await dbContext.students.AddAsync(student);
            await dbContext.SaveChangesAsync();

            return View();
        }


        [HttpGet]
        public async Task<IActionResult> List() { 
            var student = await dbContext.students.ToListAsync();

            return View(student);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id) { 
            var student = await dbContext.students.FindAsync(id);
            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Student viewModel) {

          var student=  await dbContext.students.FindAsync(viewModel.Id);
            if (student is not null) { 
                student.Name = viewModel.Name;
                student.Email = viewModel.Email;
                student.Phone = viewModel.Phone;
                student.Subscribed = viewModel.Subscribed;

                await dbContext.SaveChangesAsync();
            
            }
            return RedirectToAction("List", "Student");
        }
        
        [HttpPost]
        public async Task<IActionResult> Delete(Student viewmodel)
        {
            
            var student = await dbContext.students.AsNoTracking().FirstOrDefaultAsync(x => x.Id == viewmodel.Id);

            if (student is not null)
            {
                dbContext.students.Remove(viewmodel);
                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("List", "Student");
        }
    }
}
