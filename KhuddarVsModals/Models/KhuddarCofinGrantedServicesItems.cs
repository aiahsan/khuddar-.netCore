using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KhuddarVsModals.Models
{
   public class KhuddarCofinGrantedServicesItems : Base
    {
        public int Id { get; set; }
        public int quanity { get; set; }
        [ForeignKey("KhuddarServicesItems")]
        public int serviceItemId { get; set; }

        [ForeignKey("KhuddarCofinGrantServices")]
        public int serviceId { get; set; }

        public KhuddarCofinGrantServices KhuddarCofinGrantServices { get; set; }
        public KhuddarServicesItems KhuddarServicesItems { get; set; }
        
    }
}
