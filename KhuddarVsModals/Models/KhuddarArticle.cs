using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KhuddarVsModals.Models
{
   public class KhuddarArticle:Base
    {
        [Key]
        public int Id { get; set; }
        //recomended or normal 0/1
        public int articleType { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public string article { get; set; }
        public string videoLink { get; set; }
         


    }
}
