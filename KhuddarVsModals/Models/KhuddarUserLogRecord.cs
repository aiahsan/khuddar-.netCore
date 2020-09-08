using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KhuddarVsModals.Models
{
   public class KhuddarUserLogRecord : Base
    {
        [Key]
        public int Id { get; set; }
        
        public string Particluer { get; set; }


        [ForeignKey("User")]
        public int? UserId { get; set; }

        public KhuddarUser User { get; set; }

    }
}

