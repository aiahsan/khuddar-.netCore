using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KhuddarVsModals.Models
{
   public class KhuddarQuizAnswer : Base
    {

        public int Id { get; set; }
        public string Answer { get; set; }
        [ForeignKey("KhuddarQuiz")]
        public int? QuizQuestion { get; set; }
        public KhuddarQuiz KhuddarQuiz { get; set; }

        public int ansStatus { get; set; } = 0;


    }
}
