using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KhuddarVsModals.Models.Shadi_Mubarak
{
    public class KhuddarFoodandFood:Base
    {
        [Key]
        public int Id { get; set; }
        public string GroomName { get; set; }
        public string KitchenName { get; set; }
        public string KitchenLocation { get; set; }
        public string KitchenLat { get; set; }
        public string KitchenLong { get; set; }
        public DateTime DateTime { get; set; }
        public string servicesDetails { get; set; }
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }


        [ForeignKey("KhuddarUser")]
        public int? userId { get; set; }
        public KhuddarUser KhuddarUser { get; set; }

    }
}
