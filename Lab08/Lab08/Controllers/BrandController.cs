using Lab08.Models;
using Lab08.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lab08.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public IActionResult Index()
        {
            var brands = _brandService.GetAllBrands();
            return View(brands);
        }

        public IActionResult Details(int id)
        {
            var brand = _brandService.GetBrandById(id);
            if (brand == null) return NotFound();
            return View(brand);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Brand brand)
        {
            ModelState.Remove("Car");

            if (ModelState.IsValid)
            {
                _brandService.CreateBrand(brand);
                return RedirectToAction(nameof(Index));
            }
            return View(brand);
        }

        public IActionResult Edit(int id)
        {
            var brand = _brandService.GetBrandById(id);
            if (brand == null) return NotFound();
            return View(brand);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Brand brand)
        {
            ModelState.Remove("Car");

            if (ModelState.IsValid)
            {
                _brandService.UpdateBrand(brand);
                return RedirectToAction(nameof(Index));
            }
            return View(brand);
        }

        public IActionResult Delete(int id)
        {
            var brand = _brandService.GetBrandById(id);
            if (brand == null) return NotFound();
            return View(brand);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _brandService.DeleteBrand(id);
            return RedirectToAction(nameof(Index));
        }
    }
}