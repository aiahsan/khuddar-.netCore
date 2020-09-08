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

namespace KhuddarVS.Areas.user.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    [Area("User")]
    public class ArticlesApiController : ControllerBase
    {
        IUnitOfWork _repository = null;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ArticlesApiController(IUnitOfWork repository, IWebHostEnvironment hostEnvironment)
        {

            _repository = repository;
            webHostEnvironment = hostEnvironment;

        }

        [HttpGet]
        [Route("~/Api/getArticle/{id}")]
        public async Task<IActionResult> getArticle(int id)
        {
            var dataget = await _repository.Articles.asyncFirstOrDefault(x=>x.Id==id);
            if (dataget != null)
            {

                return Ok(dataget);

            }
           
            return BadRequest();



        }
        [HttpGet]
        [Route("~/Api/getArticles")]
        public async Task<IActionResult> getArticles()
        {
            var dataget = await _repository.Articles.asyncGetAll();
            return Ok(dataget);
        }

        [HttpPost]
        [Route("~/Api/postArticle")]

        public async Task<IActionResult> postArticle(ArticleModel articlex)
        {
           
            return Ok();
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
