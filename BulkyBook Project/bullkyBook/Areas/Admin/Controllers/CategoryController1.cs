
using BulkyBook.DataAccess;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

#nullable disable
namespace bullkyBook.Areas.Admin.Controllers
{
    public class CategoryController1 : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController1(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            IEnumerable<category> objCategoryList = _unitOfWork.Category.GetAll();

            return View(objCategoryList);
        }
        //Get
        public IActionResult Create()
        {

            return View();
        }
        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(category obj)
        {

            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("CustomError", "not matched exactly");
            }

            if (ModelState.IsValid)
            {

                _unitOfWork.Category.Add(obj);
                _unitOfWork.Save();
                return RedirectToAction("Index");

            }
            ModelState.AddModelError("customError", "Category name is required here");
            return View();
        }

        // edit section 



        //Get
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDbFirst = _unitOfWork.Category.GetFirstORDefault(u => u.id == id);

            if (categoryFromDbFirst == null) { return NotFound(); }

            return View(categoryFromDbFirst);
        }
        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(category obj)
        {

            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("CustomError", "not matched exactly");
            }

            if (ModelState.IsValid)
            {
                _unitOfWork.Category.Update(obj);
                _unitOfWork.Category.Save();
                return RedirectToAction("Index");

            }
            ModelState.AddModelError("customError", "Category name is required here");
            return View();
        }
        // delete setion 
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDbFirst = _unitOfWork.Category.GetFirstORDefault(u => u.id == id);

            if (categoryFromDbFirst == null) { return NotFound(); }

            return View(categoryFromDbFirst);
        }
        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult DeletePost(int? id)
        {
            var obj = _unitOfWork.Category.GetFirstORDefault(u => u.id == id);

            if (obj == null) { return NotFound(); }

            _unitOfWork.Category.Remove(obj);
            _unitOfWork.Save();
            return RedirectToAction("Index");


        }

    }
}

