using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KhuddarVsModals.Models.Shadi_Mubarak
{
   public class KhuddarBarat:Base
    {
        [Key]
        public int Id { get; set; }
        public string GroomName { get; set; }
        public DateTime Baratdate { get; set; }
        [ForeignKey("KhuddarUser")]
        public int? userId { get; set; }

        public KhuddarUser KhuddarUser { get; set; }

    }
}
