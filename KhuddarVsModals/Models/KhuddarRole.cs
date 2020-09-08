using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KhuddarVsModals.Models
{
   public class KhuddarRole : Base
    {
        [Key]
        public int Id { get; set; }
    
        public string RoleType { get; set; }


        public IEnumerable<KhuddarUser> Users { get; set; }
    }
}
