using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Galerry.App.Data;
using Galerry.App.Models;

namespace Galerry.App.Controllers
{
    public class PhotosController : Controller
    {
        private readonly DataContext _context;

        public PhotosController(DataContext context)
        {
            _context = context;
        }

        // GET: Photos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Photo.ToListAsync());
        }

        // GET: Photos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photos = await _context.Photo
                .SingleOrDefaultAsync(m => m.Id == id);
            if (photos == null)
            {
                return NotFound();
            }

            return View(photos);
        }

        // GET: Photos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Photos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Date,Note,Name")] Photos photos)
        {
            photos.IdOfAlbum = Guid.NewGuid();
            photos.Format = "jpg";
            photos.Resolution = "1920x500";

            if (ModelState.IsValid)
            {
                photos.Id = Guid.NewGuid();
                _context.Add(photos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(photos);
        }

        // GET: Photos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photos = await _context.Photo.SingleOrDefaultAsync(m => m.Id == id);
            if (photos == null)
            {
                return NotFound();
            }
            return View(photos);
        }

        // POST: Photos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Date,Format,Resolution,Note,IdOfAlbum,Id")] Photos photos)
        {
            if (id != photos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(photos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhotosExists(photos.Id))
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
            return View(photos);
        }

        // GET: Photos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photos = await _context.Photo
                .SingleOrDefaultAsync(m => m.Id == id);
            if (photos == null)
            {
                return NotFound();
            }

            return View(photos);
        }

        // POST: Photos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var photos = await _context.Photo.SingleOrDefaultAsync(m => m.Id == id);
            _context.Photo.Remove(photos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhotosExists(Guid id)
        {
            return _context.Photo.Any(e => e.Id == id);
        }
    }
}
