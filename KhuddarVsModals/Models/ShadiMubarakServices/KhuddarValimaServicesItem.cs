using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KhuddarVsModals.Models.ShadiMubarakServices
{
  public  class KhuddarValimaServicesItem : Base
    {
        [Key]
        public int Id { get; set; }
        public string serviceName { get; set; }
        [Column(TypeName = "money")]
        public decimal UnitCost { get; set; }

    }
}
