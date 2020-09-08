using KhuddarVsModals.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
namespace KhuddarVS.Areas.Admin.Models
{
    public class ArticleModel
    {

        [Display(Name = "Title")]
        public string title { get; set; }
        public int Id { get; set; }

        [Display(Name = "Article Type")]
        public int articleType { get; set; } = 0;
        public string Article { get; set; }
        public IFormFile Image { get; set; }
        public IFormFile Video { get; set; }
    }
}