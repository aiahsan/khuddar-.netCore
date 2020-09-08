using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KhuddarVsModals.Models
{
    public class KhuddarServicesItems : Base
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Service")]
        public int ServiceId { get; set; }
        public string serviceName { get; set; }
        public decimal unitPrice { get; set; }
        public KhuddarServices Service {get;set; }
    }
}
