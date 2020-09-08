using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KhuddarVsModals.Models
{
  public class KhuddarCofinGrantServices : Base
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int userId { get; set; }
        public decimal total { get; set; }
        public KhuddarUser User { get; set; }
        public ICollection<KhuddarCofinGrantedServicesItems> KhuddarCofinGrantedServicesItems { get; set; }
    }
}
