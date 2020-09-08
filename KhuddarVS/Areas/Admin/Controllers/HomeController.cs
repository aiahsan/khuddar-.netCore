using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KhuddarVS.Areas.Admin.Models;
using KhuddarVsModals.Interfaces;
using KhuddarVsModals.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KhuddarVS.Areas.Admin.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {

        IUnitOfWork _repository = null;
        private readonly IWebHostEnvironment webHostEnvironment;

        public HomeController(IUnitOfWork repostiry, IWebHostEnvironment hostEnvironment)
        {
            _repository = repostiry;
            webHostEnvironment = hostEnvironment;

        }

        [Route("~/admin/home")]
        public IActionResult Index()
        {
            return View();
        }


        [Route("~/admin/Quiz")]

        public async Task<IActionResult> Quiz()
        {
            var data= await _repository.QuizCategory.asyncGetAll();
            ViewBag.Categories = data.Where(x=>x.deleteStatus==false);
            return View();
        }
         [Route("~/admin/Quizes/{id?}")]

        public async Task<IActionResult> Quizes(int? id)
        {
            var data = await _repository.QuizCategory.asyncGetAll();
            ViewBag.Categories = data.Where(x => x.deleteStatus == false);

            if (id != null)
            {
                var result = await _repository.Quiz.getCompleteQuizObject(id.Value);
                if (result != null)
                {
                    return View(result);
                }
            }
            return View();
        }
        

        [Route("~/admin/category")]

        public async Task<IActionResult> category()
        {
            ViewData["categories"] =await _repository.QuizCategory.asyncGetAll();
            return View();
        }
        [Route("~/admin/earnvideos")]

        public async Task<IActionResult> EarnByVideos()
        {
            ViewBag.sourse = new List<string>() { "Youtube" };
            return View();
        }
        [Route("~/admin/videoList/{id?}")]

        public async Task<IActionResult> VideoList(int? id)
        {

            if (id != null)
            {
                var result = await _repository.EarnToPLayVideo.asyncFirstOrDefault(x => x.Id == id.Value);
                if (result != null)
                {
                    return View(result);
                }
            }
            return View();
        }

        [Route("~/admin/ShadiMubarak")]

        public async Task<IActionResult> ShadiMubarak()
        {
            ViewBag.sourse = new List<string>() { "Al-Nikkah", "Baraat", "Valima", "Groom Salon", "Food and Food", "Marriage Banquet", "Furniture","Rent a Happy Car" };
            return View();
        }

        [Route("~/admin/Categories/{id?}")]

        public async Task<IActionResult> Categories(int ?id)
        {
            if(id!=null)
            {
              var result= await _repository.QuizCategory.asyncFirstOrDefault(x => x.Id == id.Value);
              if(result!=null)
                {
                    return View(result);
                }
            }
            return View();
        }
        [Route("~/admin/article")]
        public async Task<IActionResult> articles()
        {
            ViewData["articles"] = _repository.Articles.GetAll();
            return View();
        }
        [HttpPost]
        [Route("~/admin/article")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> articles(ArticleModel articlex)
        {
            string uniqueImageName = UploadedFile(articlex.Image);
            string uniqueVideoName = UploadedFile(articlex.Video);
            KhuddarArticle _article = new KhuddarArticle
            {
                articleType = articlex.articleType,
                article = articlex.Article,
                title = articlex.title,
                status = true,
                date = DateTime.Now,
                image = uniqueImageName,
                videoLink = uniqueVideoName,
            };
            _repository.Articles.Add(_article);
            await _repository.asyncComplete();

            return View();
        }

        public async Task<IActionResult> Coffin()
        {
            return View();
        }
        [Route("~/admin/coffin/service")]

        public async Task<IActionResult> Coffinservice()
        {
            return View();
        }
        [Route("~/admin/coffin/services/{id?}")]

        public async Task<IActionResult> Coffinservices(int? id)
        {
            if (id != null)
            {
                var result = await _repository.CoffinServices.asyncFirstOrDefault(x => x.Id == id.Value);
                if (result != null)
                {
                    return View(result);
                }
            }
            return View();
        }

        private string UploadedFile(IFormFile file)
        {
            string uniqueFileName = null;

            if (file != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "articleAssets");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
