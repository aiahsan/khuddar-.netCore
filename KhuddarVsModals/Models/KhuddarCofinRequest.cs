using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KhuddarVsModals.Models
{
   public class KhuddarCofinRequest : Base
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("user")]
        public int? userId { get; set; }
        public string patientName { get; set; }

        public KhuddarUser user { get; set; }
    }
}
