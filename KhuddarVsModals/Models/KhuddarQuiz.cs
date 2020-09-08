using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KhuddarVsModals.Models
{
  public class KhuddarQuiz : Base
    {
        [Key]
        public int Id { get; set; }
        
        public string Question { get; set; }
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
        
        public int CorrectAnswer { get; set; }//direct Id
        [Display(Name ="Contain Video")]
        public bool HasVideo { get; set; } = false;
        [Column(TypeName = "varchar(MAX)")]
        public string VideoLink { get; set;}

        [Display(Name ="Duration")]
        public int Time { get; set; }
        [ForeignKey("KhuddarQuizCategory")]
        public int? Category { get; set; }
        public ICollection<KhuddarQuizAnswer> KhuddarQuizAnswers { get; set; }
        public KhuddarQuizCategory KhuddarQuizCategory { get; set; }

       
    }
}
