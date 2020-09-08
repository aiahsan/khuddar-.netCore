using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KhuddarVsModals.Models.Shadi_Mubarak
{
   public class KhuddarRentAHappyCar:Base
    {
        [Key]
        public int Id { get; set; }
        public string BrideName { get; set; }
        public string GroomName { get; set; }
        public string RentACarName { get; set; }
        public string RentACarLocation { get; set; }
        public string RentACarLat { get; set; }
        public string RentACarLong { get; set; }
        public DateTime DateTime { get; set; }
        public string servicesDetails { get; set; }
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }


        [ForeignKey("KhuddarUser")]
        public int? userId { get; set; }
        public KhuddarUser KhuddarUser { get; set; }

    }
}
