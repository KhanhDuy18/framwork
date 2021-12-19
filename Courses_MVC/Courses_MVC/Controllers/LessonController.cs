using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Courses_MVC.Data;
using Courses_MVC.Models;

namespace Courses_MVC.Controllers
{
    public class LessonController : Controller
    {
        private readonly CoursesContext _context;

        public LessonController(CoursesContext context)
        {
            _context = context;
        }
        //Khánh Duy//
        [TempData]
        public string StatusMessage { get; set; }
        public IActionResult LessonCourse(int id)
        {
            var exercise = _context.Exercises
                            .Where(l => l.lessonId == id)
                            .Count();
            TempData["NumberofLesson"] = exercise;
            ViewBag.listExercise = exercise;
            var courseDetail = (_context.Lessons
                                .Where(l => l.courseId == id)
                                .Include(l => l.Course)
                                ).ToList();
            if(courseDetail.ToArray().Length ==0)
            {
                StatusMessage = "Khóa học đang được phát triển";
                return Redirect("/Courses/DanhSachHienTHi");
            }    
            else
            {
                return View(courseDetail);
            }               
        }
        public IActionResult LessonDetail(int id)
        {
            var courseDetail = (_context.Lessons
                                .Include(l => l.Course)
                                ).FirstOrDefault(l => l.lessonId == id);
            var listExercise = _context.Exercises
                                .Where(e => e.lessonId == id)
                                .ToList();

            ViewBag.listExercise = listExercise;

            return View(courseDetail);
        }
        //Khánh Duy//
        // GET: Lesson
        public async Task<IActionResult> Index()
        {
            var LessonContext = _context.Lessons.Include(c => c.lessonId);
            return View(await LessonContext.ToListAsync());
        }

        // GET: Lesson/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lesson = await _context.Lessons
                .Include(c => c.courseId)
                .FirstOrDefaultAsync(m => m.lessonId == id);
            if (lesson == null)
            {
                return NotFound();
            }

            return View(lesson);
        }

        // GET: Lesson/Create
        public IActionResult Create()
        {
            ViewData["courseId"] = new SelectList(_context.Courses, "courseId", "courseName");// "originalPrice","imgCourse","totalTime","totalStudent","ToppicId","discountId");
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("lesonId,title,content,courseId")] Lesson lesson)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lesson);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["courseId"] = new SelectList(_context.Courses, "courseId", "courseName", lesson.courseId);
            return View(lesson);
        }

        // GET: Lesson/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lesson = await _context.Lessons.FindAsync(id);
            if (lesson == null)
            {
                return NotFound();
            }
            ViewData["courseId"] = new SelectList(_context.Discounts, "courseId", "courseName", lesson.courseId);
            return View(lesson);
        }

        // POST: Lesson/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("lessonId,title,content,courseId")] Lesson lesson)
        {
            if (id != lesson.lessonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lesson);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LessonExists(lesson.lessonId))
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
            ViewData["courseId"] = new SelectList(_context.Discounts, "courseId", "courseName", lesson.courseId);
            return View(lesson);
        }

        // GET: Lesson/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lesson = await _context.Lessons
                .Include(c => c.courseId)
                .FirstOrDefaultAsync(m => m.lessonId == id);
            if (lesson == null)
            {
                return NotFound();
            }

            return View(lesson);
        }

        // POST: Lesson/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lesson = await _context.Lessons.FindAsync(id);
            _context.Lessons.Remove(lesson);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LessonExists(int id)
        {
            return _context.Lessons.Any(e => e.lessonId == id);
        }
    }
}
