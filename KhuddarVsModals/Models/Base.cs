using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KhuddarVsModals.Models
{
  public class Base
    {
        [Display(Name = "Make Record Available")]
        public bool status { get; set; } = true;
        public bool deleteStatus { get; set; } = false;
        public DateTime date { get; set; } = DateTime.Now;

    }
}
