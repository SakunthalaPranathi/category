using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using cateringdemosample.Models;

namespace cateringdatasample.Controllers
{
    public class foodsController : Controller
    {
        private readonly CateringContext _context;

        public foodsController(CateringContext context)
        {
            _context = context;
        }

        // GET: foods
        public async Task<IActionResult> Index()
        {
            var cateringContext = _context.foods.Include(f => f.categ);
            return View(await cateringContext.ToListAsync());
        }

        // GET: foods/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = await _context.foods
                .Include(f => f.categ)
                .FirstOrDefaultAsync(m => m.id == id);
            if (food == null)
            {
                return NotFound();
            }

            return View(food);
        }

        // GET: foods/Create
        public IActionResult Create()
        {
            ViewData["categid"] = new SelectList(_context.EcomCategory, "id", "id");
            return View();
        }

        // POST: foods/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,categid,desc,photopath,check")] Food food)
        {
            if (ModelState.IsValid)
            {
                _context.Add(food);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["categid"] = new SelectList(_context.EcomCategory, "id", "id", food.categid);
            return View(food);
        }

        // GET: foods/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = await _context.foods.FindAsync(id);
            if (food == null)
            {
                return NotFound();
            }
            ViewData["categid"] = new SelectList(_context.EcomCategory, "id", "id", food.categid);
            return View(food);
        }

        // POST: foods/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,categid,desc,photopath,check")] Food food)
        {
            if (id != food.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(food);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!foodExists(food.id))
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
            ViewData["categid"] = new SelectList(_context.EcomCategory, "id", "id", food.categid);
            return View(food);
        }

        // GET: foods/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = await _context.foods
                .Include(f => f.categ)
                .FirstOrDefaultAsync(m => m.id == id);
            if (food == null)
            {
                return NotFound();
            }

            return View(food);
        }

        // POST: foods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var food = await _context.foods.FindAsync(id);
            _context.foods.Remove(food);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool foodExists(int id)
        {
            return _context.foods.Any(e => e.id == id);
        }
    }
}
