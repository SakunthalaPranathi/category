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
    public class EcomCategoriesController : Controller
    {
        private readonly CateringContext _context;

        public EcomCategoriesController(CateringContext context)
        {
            _context = context;
        }

        // GET: EcomCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.EcomCategory.ToListAsync());
        }
        public async Task<IActionResult> GetCategories()
        {
            return View(await _context.EcomCategory.ToListAsync());
        }
        public async Task<IActionResult> FoodList(int id)
        {
            return View(await _context.foods.Where(e => e.categid == id).ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> FoodList(List<Food> food)
        {
            foreach(Food f in food)
            {
                if (f.check)
                    TempData["food"] += f.name + ",";
            }
            return RedirectToAction("GetCategories");
        }
        // GET: EcomCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ecomCategory = await _context.EcomCategory
                .FirstOrDefaultAsync(m => m.id == id);
            if (ecomCategory == null)
            {
                return NotFound();
            }

            return View(ecomCategory);
        }

        // GET: EcomCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EcomCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,desc,photopath")] EcomCategory ecomCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ecomCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ecomCategory);
        }

        // GET: EcomCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ecomCategory = await _context.EcomCategory.FindAsync(id);
            if (ecomCategory == null)
            {
                return NotFound();
            }
            return View(ecomCategory);
        }

        // POST: EcomCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,desc,photopath")] EcomCategory ecomCategory)
        {
            if (id != ecomCategory.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ecomCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EcomCategoryExists(ecomCategory.id))
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
            return View(ecomCategory);
        }

        // GET: EcomCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ecomCategory = await _context.EcomCategory
                .FirstOrDefaultAsync(m => m.id == id);
            if (ecomCategory == null)
            {
                return NotFound();
            }

            return View(ecomCategory);
        }

        // POST: EcomCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ecomCategory = await _context.EcomCategory.FindAsync(id);
            _context.EcomCategory.Remove(ecomCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EcomCategoryExists(int id)
        {
            return _context.EcomCategory.Any(e => e.id == id);
        }
    }
}
