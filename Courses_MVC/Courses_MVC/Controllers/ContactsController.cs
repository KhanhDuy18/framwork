using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Courses_MVC.Data;
using Courses_MVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Courses_MVC.Controllers
{
    public class ContactsController : Controller
    {
        private readonly CoursesContext _context;
        private readonly UserManager<AppUser> _userManager;
        public ContactsController(CoursesContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        [TempData]
        public string StatusMessage { get; set; }
        // GET: Contacts
        [Authorize(Policy = "AllowEditRole")]
        public async Task<IActionResult> Index()
        {
            var coursesContext = _context.Contact.Include(c => c.AppUser);
            return View(await coursesContext.ToListAsync());
        }

        // GET: Contacts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .Include(c => c.AppUser)
                .FirstOrDefaultAsync(m => m.contactId == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }
        // GET: Contacts/Create
        [AllowAnonymous]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Contacts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("contactId,AppUserId,HoTen,email,SDT,title,content")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                var user =await _userManager.GetUserAsync(User);

                if(user != null)
                {
                    contact.AppUserId = user.Id;
                    contact.HoTen = user.UserName;
                    contact.email = user.Email;
                    _context.Add(contact);
                    
                    await _context.SaveChangesAsync();

                }
                else
                {
                    _context.Add(contact);
                    await _context.SaveChangesAsync();
                }
                
            }
            return View(contact);
        }


        public async Task<IActionResult> ThemContact()
        {
            //var themContact = await (from ct in _context.Contact
            //                         select ct).Include(c => c.AppUser).ToListAsync();
            ViewData["user"] = new SelectList(_context.Users, "Id", "UserName");
            return View();

        }

        // GET: Contacts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .Include(c => c.AppUser)
                .FirstOrDefaultAsync(m => m.contactId == id);
            if (contact == null)
            {
                return NotFound();
            }
            _context.Contact.Remove(contact);
            await _context.SaveChangesAsync();
            StatusMessage = $"Đã xóa thành công liên hệ của {_userManager.GetUserName(User)}";
            return RedirectToAction(nameof(Index));
        }



        private bool ContactExists(int id)
        {
            return _context.Contact.Any(e => e.contactId == id);
        }
    }
}
