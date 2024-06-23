using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjeKlasoru.Data;
using ProjeKlasoru.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeKlasoru.Controllers
{
    public class TblAlbumController : Controller
    {
        private readonly DemoDbContext _context;

        public TblAlbumController(DemoDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IActionResult> Index()
        {
            var albums = _context.Tbl_Album != null ? await _context.Tbl_Album.ToListAsync() : new List<TblAlbum>();
            return View(albums);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TblAlbum album, string MenajerBilgisi)
        {
            if (ModelState.IsValid)
            {
                album.Sanatci_bilgi += " - Menajer: " + MenajerBilgisi;

                if (_context.Tbl_Album != null)
                {
                    _context.Add(album);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(album);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Tbl_Album == null)
            {
                return NotFound();
            }

            var album = await _context.Tbl_Album.FindAsync(id);
            if (album == null)
            {
                return NotFound();
            }
            return View(album);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TblAlbum album, string MenajerBilgisi)
        {
            if (id != album.Album_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    album.Sanatci_bilgi += " - Menajer: " + MenajerBilgisi;

                    if (_context.Tbl_Album != null)
                    {
                        _context.Update(album);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlbumExists(album.Album_Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return View(album);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Tbl_Album == null)
            {
                return NotFound();
            }

            var album = await _context.Tbl_Album.FindAsync(id);
            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Tbl_Album == null)
            {
                return Problem("Entity set 'DemoDbContext.Tbl_Album' is null.");
            }

            var album = await _context.Tbl_Album.FindAsync(id);
            if (album != null)
            {
                _context.Tbl_Album.Remove(album);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Tbl_Album == null)
            {
                return NotFound();
            }

            var album = await _context.Tbl_Album.FindAsync(id);
            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }

        private bool AlbumExists(int id)
        {
            return (_context.Tbl_Album?.Any(e => e.Album_Id == id)).GetValueOrDefault();
        }
    }
}
