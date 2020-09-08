using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KhuddarVsModals.Models
{
   public class KhuddarQuizCategory : Base
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Category { get; set; }
        

        public ICollection<KhuddarQuiz> KhuddarQuiz { get; set; }
            
    }
}
