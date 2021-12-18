using Courses_MVC.Data;
using Courses_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Controllers
{
    public class CoursesController : Controller
    {
        private readonly CoursesContext _context;

        public CoursesController(CoursesContext context)
        {
            _context = context;
        }
        public IActionResult CoursesDetail(int id)
        {
            var courseDetail = (from cs in _context.Courses
                                select cs).Include(c => c.Discount).Include(c => c.Topic).FirstOrDefault(c => c.courseId == id);
            return View(courseDetail);
        }
        public IActionResult DanhSachCourses()
        {
            List<Course> kq = _context.Courses.ToList();
            return View(kq);
        }
        public IActionResult DanhSachHienThi()
        {

            var coursesContext = _context.Courses.Include(c => c.Discount).Include(c => c.Topic);
            return View(coursesContext.ToList());
        }

        [HttpPost]
        public IActionResult DanhSachHienThi(string? courestitle)
        {
            
            var coursesContext = (from cs in _context.Courses
                                  select cs);
            if (!string.IsNullOrEmpty(courestitle))
            {
                coursesContext = coursesContext.Where(c=>c.courseName.Contains(courestitle)).Include(c => c.Discount).Include(c => c.Topic);
            }
            else
            {
                coursesContext = _context.Courses.Include(c => c.Discount).Include(c => c.Topic);
            }    
            return View(coursesContext.ToList());
        }

        // GET: Courses
        public async Task<IActionResult> Index()
        {
            var coursesContext = _context.Courses.Include(c => c.Discount).Include(c => c.Topic);
            return View(await coursesContext.ToListAsync());
        }

        // GET: Courses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var course = (from cs in _context.Courses
                         join tp in _context.Topic on cs.topicId equals tp.topicId
                         join dc in _context.Discounts on cs.discountId equals dc.discountId
                         select cs)
                         .Include(c=>c.Topic)
                         .Include(c=>c.Discount)
                         .FirstOrDefault(c=>c.courseId == id);
            //var course = await _context.Courses
            //    .Include(c => c.Discount)
            //    .Include(c => c.Topic)
            //    .FirstOrDefaultAsync(m => m.courseId == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: Courses/Create
        public IActionResult Create()
        {
            ViewData["discountId"] = new SelectList(_context.Discounts, "discountId", "discription");
            ViewData["topicId"] = new SelectList(_context.Topic, "topicId", "topicName");
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("courseId,courseName,discription,price,originalPrice,imgCourse,totalTime,totalStudent,topicId,discountId")] Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Add(course);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["discountId"] = new SelectList(_context.Discounts, "discountId", "discription", course.discountId);
            ViewData["topicId"] = new SelectList(_context.Topic, "topicId", "topicName", course.topicId);
            return View(course);
        }

        // GET: Courses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            ViewData["discountId"] = new SelectList(_context.Discounts, "discountId", "discription", course.discountId);
            ViewData["topicId"] = new SelectList(_context.Topic, "topicId", "topicName", course.topicId);
            return View(course);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("courseId,courseName,discription,price,originalPrice,imgCourse,totalTime,totalStudent,topicId,discountId")] Course course)
        {
            if (id != course.courseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(course);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(course.courseId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["discountId"] = new SelectList(_context.Discounts, "discountId", "discription", course.discountId);
            ViewData["topicId"] = new SelectList(_context.Topic, "topicId", "topicName", course.topicId);
            return View(course);
        }

        // GET: Courses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .Include(c => c.Discount)
                .Include(c => c.Topic)
                .FirstOrDefaultAsync(m => m.courseId == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.courseId == id);
        }
    }
}
