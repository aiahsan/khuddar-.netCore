using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KhuddarVsModals.Models
{
    public class KhuddarServices : Base
    {
        [Key]
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public ICollection<KhuddarServicesItems> ServiceTypes { get; set; }
    }
}
