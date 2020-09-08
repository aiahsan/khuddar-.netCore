using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KhuddarVsModals.Models
{
    public class KhuddarQuizCompleted : Base
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("KhuddarUser")]
        public int? userId { get; set; }

        public bool? hasCompleted { get; set; } = false;
        public DateTime? completionDate { get; set; } = DateTime.Now.Date;
        public KhuddarUser KhuddarUser { get; set; }
    }
}
