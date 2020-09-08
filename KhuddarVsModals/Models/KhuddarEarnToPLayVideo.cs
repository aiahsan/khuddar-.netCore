using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KhuddarVsModals.Models
{
   public class KhuddarEarnToPLayVideo : Base
    {
        public int Id { get; set; }
        [Display(Name ="Video")]
        public string videoId { get; set; }
        public string source { get; set; }
        public string amount { get; set; }
        public string title { get; set; }
        [Display(Name = "Thumbnail Link")]
        public string thumbnail { get; set; }
        [DataType(DataType.Date)]
        public DateTime expiryDate { get; set; }

    }
}
